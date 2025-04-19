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

    public partial class EntranceUC : UserControl
    {
        int id_house = -1;
        int id_entrance = -1;
        string house_name = "";
        string entrance_number = "";

        string query1 = "SELECT e.ID, m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', e.Entrance_Number AS 'Номер подъезда'," +
            "e.Number_Of_Floors AS 'Этажность', e.Year_Of_Construction AS 'Год постройки', e.Is_Confirmed_Supplier AS 'Информация подтверждена поставщиком' " +
            "FROM Entrance e " +
            "JOIN Characteristic_MKD m ON m.ID = e.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = m.ID_Address " +
            "ORDER BY a.Type_Street + ' ' + a.Street + ' ' + m.House_Number";
        public EntranceUC()
        {
            InitializeComponent();            
        }

        private void EntranceUC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query1, dataGridView1);

            button1.Location = new Point(15, 53);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");
            button1.Size = new Size(199, 35);

            button2.Location = new Point(15, 98);
            button2.Font = new Font("Times New Roman", 12);
            button2.BackColor = Color.FromName("InactiveCaption");
            button2.Size = new Size(199, 35);

            button3.Location = new Point(15, 143);
            button3.Font = new Font("Times New Roman", 12);
            button3.BackColor = Color.FromName("InactiveCaption");
            button3.Size = new Size(199, 35);

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

            splitContainer1.SplitterDistance = 229;
            splitContainer1.Size = new Size(1233, 394);

            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(id_house >= 0)
            {
                string query = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE m.ID = @ID";

                Add_Func(query);
            }
            else
            {
                string query = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "ORDER BY a.Type_Street + ' ' + a.Street + ' ' + m.House_Number";

                Add_Func(query);
            }

        }

        private void Add_Func(string query)
        {           

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id_house);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            var entrance = new Entrance_AF() { Text = $"Добавление нового подъезда. {house_name}"};
            entrance.Load_Data(dt);
            entrance.save_query = "INSERT INTO Entrance(ID_MKD_Address, " +
                        "Number_Of_Floors, Year_Of_Construction, Is_Confirmed_Supplier, Entrance_Number) " +
                        "VALUES(@ID_MKD_Address, @Number_Of_Floors, @Year_Of_Construction, @Is_Confirmed_Supplier, @Entrance_Number)";
            entrance.status = "добавлена";
            entrance.entranceBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = entrance.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*GIS_Data.Entrance_ID*/ id_house = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                id_entrance = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                house_name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                entrance_number = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                /*GIS_Data.Entrance_ID*/ id_house = -1;
                id_entrance = -1;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (id_entrance > -1)
            {
                var entrance = new Entrance_AF() { Text = $"Изменение данных подъезда №{entrance_number}. {house_name}"};
                
                entrance.Load_Data_Edit(id_entrance);
                entrance.save_query = "UPDATE Entrance SET ID_MKD_Address = @ID_MKD_Address, " +
                    "Number_Of_Floors = @Number_Of_Floors, " +
                    "Year_Of_Construction = @Year_Of_Construction, " +
                    "Is_Confirmed_Supplier = @Is_Confirmed_Supplier, " +
                    "Entrance_Number = @Entrance_Number " +
                    $"WHERE ID = {id_entrance}";
                entrance.status = "изменена";
                entrance.entranceBindingNavigatorSaveItem.Text = "Изменить данные";

                DialogResult result = entrance.ShowDialog();
                
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query1, dataGridView1);
                    GIS_Data.Entrance_ID = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Entrance WHERE ID = @ID";
            if(GIS_Data.RemoveClickTemp(GIS_Data.Entrance_ID, queryDelete,false) == true) GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1,dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query1, e);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
