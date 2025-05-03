using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GIS.Forms;

namespace GIS.UC
{
    public partial class PremisesUC : UserControl
    {
        string query_load = "SELECT p.ID , p.ID_MKD_Address, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес помещения', p.Info AS 'Номер помещения'," +
           "p.Is_Living AS 'Помещение является жилым', p.Premises_Description AS 'Характеристика помещения', p.Total_Area AS 'Общая площадь помещения', p.Living_Total_Area AS 'Жилая площадь помещения'," +
           "p.Is_Common AS 'Является общим имуществом', p.Cadastral_Number AS 'Кадастровый номер', p.Is_Confirmed_Supplier AS 'Информация подтверждена поставщиком' " +
           "FROM MKD_Premises p " +
           "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
           "JOIN Address_Book a ON a.ID = m.ID_Address " +
           "ORDER BY a.Street + ' ' + m.House_Number + ' ' + p.Info";
        string house_name, premises_number;
        int id_premises, id_house;
        public PremisesUC()
        {
            InitializeComponent();
        }

        private void PremisesUC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query_load, dataGridView1);

            button4.Location = new Point(189, 311);
            button4.BackColor = Color.FromName("Menu");
            button4.Size = new Size(25, 25);

            button5.Location = new Point(15, 337);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");
            button5.Size = new Size(199, 35);

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            splitContainer1.Size = new Size(1233, 394);
            splitContainer1.SplitterDistance = 229;
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Width = 200;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE m.ID = @ID";

            var premises = new Premises_AF() { Text = $"Добавление нового помещения. {house_name}" };
            premises.Load_Data(Add_Func(query_load_CB));
            premises.save_query = "INSERT INTO MKD_Premises(ID_MKD_Address, Info,Is_Living, Premises_Description, Total_Area, Living_Total_Area, Is_Common, Cadastral_Number, Is_Confirmed_Supplier) " +
                        $"VALUES(@ID_MKD_Address, @Info,Is_Living, @Premises_Description, " +
                        $"@Total_Area, @Living_Total_Area, " +
                        $"@Is_Common, @Cadastral_Number, @Is_Confirmed_Supplier)";
            premises.status = "добавлена";
            premises.mKD_PremisesBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = premises.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private DataTable Add_Func(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id_house);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE m.ID = @ID";

            string query_load_edit = "SELECT ID_MKD_Address, Is_Living, Premises_Description, Total_Area, " +
                "Living_Total_Area,Is_Common, Cadastral_Number, Is_Confirmed_Supplier, Info FROM MKD_Premises p " +
                $"WHERE p.ID = {id_premises}";

            if (id_premises > -1)
            {
                var premises = new Premises_AF() { Text = $"Изменение данных помещения. {house_name}" };
                premises.Load_Data_Edit(Add_Func(query_load_CB), query_load_edit, id_premises);
                premises.save_query = $"UPDATE MKD_Premises SET ID_MKD_Address = @ID_MKD_Address, Info = @Info," +
                    $"Is_Living = @Is_Living, Premises_Description = @Premises_Description, " +
                    $"Total_Area = @Total_Area, Living_Total_Area = @Living_Total_Area, Is_Common = @Is_Common, " +
                    $"Cadastral_Number = @Cadastral_Number, Is_Confirmed_Supplier = @Is_Confirmed_Supplier " +
                    $"WHERE ID = {id_premises}";
                premises.status = "изменена";
                premises.mKD_PremisesBindingNavigatorSaveItem.Text = "Изменить данные";
                DialogResult result = premises.ShowDialog();
                if (result == DialogResult.Cancel)
                    GIS_Data.SQLFill(query_load, dataGridView1);
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_premises = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                id_house = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                house_name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                premises_number = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                id_premises = -1;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE MKD_Premises WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(id_premises, queryDelete, false, $"Удалить данные помещения: {house_name}, кв. {premises_number}?") == true) GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query_load, e);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                id_house = int.Parse(dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[1].Value.ToString());
                id_premises = int.Parse(dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[0].Value.ToString());
                house_name = dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[2].Value.ToString();
                premises_number = dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[3].Value.ToString();

                ContextMenu m = new ContextMenu();

                MenuItem add = new MenuItem() { Text = $"(+) Добавить новую квартиру для дома: {house_name}" };
                MenuItem edit = new MenuItem() { Text = $"(=) Изменить данные квартиры №{premises_number}, дом: {house_name}" };
                MenuItem remove = new MenuItem() { Text = $"(-) Удалить данные квартиры №{premises_number}, дом: {house_name}" };

                MenuItem input_meter = new MenuItem() { Text = $"Показания счетчиков" };
                MenuItem input_meter_for_flat = new MenuItem() { Text = $"(+) Внести показания счетчиков квартиры №{premises_number}, дом: {house_name}" };
                MenuItem view_meter_for_flat = new MenuItem() { Text = $"Просмотр показаний счетчиков квартиры №{premises_number}, дом: {house_name}" };
                MenuItem input_meter_document = new MenuItem() { Text = "Импортировать документ с показаниями" };

                add.Click += Add_Click;
                edit.Click += Edit_Click;
                remove.Click += Remove_Click;
                input_meter_for_flat.Click += Input_meter_for_flat_Click;
                view_meter_for_flat.Click += View_meter_for_flat_Click;

                input_meter.MenuItems.Add(input_meter_for_flat);
                input_meter.MenuItems.Add(view_meter_for_flat);
                //input_meter.MenuItems.Add(input_meter_document);

                
                

                if (id_house >= -0)
                {
                    m.MenuItems.Add(add);
                    m.MenuItems.Add(edit);
                    m.MenuItems.Add(remove);
                    m.MenuItems.Add("-");
                    m.MenuItems.Add(input_meter);
                    m.MenuItems.Add(input_meter_document);
                }

                m.Show(dataGridView1, new Point(e.X, e.Y + 15));
            }
        }

        private void Input_meter_for_flat_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT p.ID AS ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Address' FROM MKD_Premises p " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE p.ID = @p_id";

            var input_Meter = new Input_Meter_AF() { Text = $"Внесение показаний счетчиков, дом {house_name}, кв. {premises_number}" };
            input_Meter.Load_Data(Add_Func_For_Meters(query_load_CB));
            input_Meter.save_query = "INSERT INTO Input_meter_readings(ID_Premises, Month_of_metering, Cold_water, Hot_water, Electic_energy, Heating) " +
                        $"VALUES(@ID_Premises, @Month_of_metering, @Cold_water, @Hot_water, @Electic_energy, @Heating)";
            input_Meter.status = "добавлена";
            input_Meter.toolStripButton1.Text = "Сохранить данные";
            DialogResult result = input_Meter.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void View_meter_for_flat_Click(object sender, EventArgs e)
        {
            string query_load = "SELECT i.ID, i.ID_Premises, o.ID, a.Type_Street + ' ' + a.Street + ' ' + mkd.House_Number AS 'Адрес помещения', p.Info AS 'Номер помещения', i.Month_of_metering AS 'Дата показаний', i.Cold_water AS 'ХВС', i.Hot_water AS 'ГВС', i.Electic_energy AS 'ЭС', i.Heating AS 'ОТ' " +
            "FROM Input_meter_readings i " +
            "JOIN MKD_Premises p ON p.ID = i.ID_Premises " +
            "JOIN Characteristic_MKD mkd ON mkd.ID = p.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = mkd.ID_Address " +
            "JOIN Premises_LS_Relations p_ls ON p_ls.ID_Premises = p.ID " +
            "JOIN LS ls ON ls.ID = p_ls.ID_LS " +
            "JOIN Owner_LS o ON o.ID = ls.ID_Owner " +
            "ORDER BY i.Month_of_metering DESC " +
            $"WHERE i.ID_Premises = {id_premises}";

            MainForm mainForm = this.Parent as MainForm;
            
            if (mainForm == null)
            {
                // Call a method in the parent window
                mainForm.View_Meter_For_Flat(query_load);
            }           
        }

        private DataTable Add_Func_For_Meters(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p_id", id_premises);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
