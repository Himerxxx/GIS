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
using GIS.EditForms;
using GIS.Forms;

namespace GIS.SearchForms
{
    public partial class MKD_SearchForm : Form
    {
        public int id_house;
        string house_name;
        int id_entrance;        
        string entrance_number;
        int p_id;
        int opy_id;

        public MKD_SearchForm()
        {
            InitializeComponent();
        }

        private void MKD_SearchForm_Load(object sender, EventArgs e)
        {
            button1.Text = "Изменить";
            button1.Location = new Point(13, 99);
            button1.Size = new Size(199, 35);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");

            button2.Text = "Удалить";
            button2.Location = new Point(13, 144);
            button2.Size = new Size(199, 35);
            button2.Font = new Font("Times New Roman", 12);
            button2.BackColor = Color.FromName("InactiveCaption");

            button13.Text = "Добавить";
            button13.Location = new Point(13, 54);
            button13.Size = new Size(199, 35);
            button13.Font = new Font("Times New Roman", 12);
            button13.BackColor = Color.FromName("InactiveCaption");

            button3.Location = new Point(187, 218);
            button3.BackColor = Color.FromName("Menu");
            button3.Size = new Size(25, 25);
            button3.Text = "";

            button4.Text = "Сбросить";
            button4.Location = new Point(13, 243);
            button4.Size = new Size(199, 35);
            button4.Font = new Font("Times New Roman", 12);
            button4.BackColor = Color.FromName("InactiveCaption");

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(14, 218);
            //=======================================================
            button14.Text = "Добавить";
            button14.Location = new Point(13, 355);
            button14.Size = new Size(199, 35);
            button14.Font = new Font("Times New Roman", 12);
            button14.BackColor = Color.FromName("InactiveCaption");

            button5.Text = "Изменить";
            button5.Location = new Point(13, 400);
            button5.Size = new Size(199, 35);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");

            button6.Text = "Удалить";
            button6.Location = new Point(13, 445);
            button6.Size = new Size(199, 35);
            button6.Font = new Font("Times New Roman", 12);
            button6.BackColor = Color.FromName("InactiveCaption");

            button7.Location = new Point(187, 519);
            button7.BackColor = Color.FromName("Menu");
            button7.Size = new Size(25, 25);
            button7.Text = "";

            button8.Text = "Сбросить";
            button8.Location = new Point(13, 544);
            button8.Size = new Size(199, 35);
            button8.Font = new Font("Times New Roman", 12);
            button8.BackColor = Color.FromName("InactiveCaption");

            textBox2.Multiline = true;
            textBox2.Size = new Size(170, 25);
            textBox2.Location = new Point(14, 519);
            //==================================================
            button15.Text = "Добавить";
            button15.Location = new Point(13, 656);
            button15.Size = new Size(199, 35);
            button15.Font = new Font("Times New Roman", 12);
            button15.BackColor = Color.FromName("InactiveCaption");

            button9.Text = "Изменить";
            button9.Location = new Point(13, 701);
            button9.Size = new Size(199, 35);
            button9.Font = new Font("Times New Roman", 12);
            button9.BackColor = Color.FromName("InactiveCaption");

            button10.Text = "Удалить";
            button10.Location = new Point(13, 746);
            button10.Size = new Size(199, 35);
            button10.Font = new Font("Times New Roman", 12);
            button10.BackColor = Color.FromName("InactiveCaption");

            button11.Location = new Point(187, 820);
            button11.BackColor = Color.FromName("Menu");
            button11.Size = new Size(25, 25);
            button11.Text = "";

            button12.Text = "Сбросить";
            button12.Location = new Point(13, 845);
            button12.Size = new Size(199, 35);
            button12.Font = new Font("Times New Roman", 12);
            button12.BackColor = Color.FromName("InactiveCaption");

            textBox3.Multiline = true;
            textBox3.Size = new Size(170, 25);
            textBox3.Location = new Point(14, 820);
            
            Entrance_DataGrid_Fill();
            Premises_DataGrid_Fill();
            OPY_DG_Fill();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView3.Columns[0].Visible = false;

            GIS_Data.MKD_ID = id_house;
        }
        private void OPY_DG_Fill()
        {
            string query1 = "SELECT py.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', " +
            "py.Serial_Number AS 'Серийный номер', py.Type_PY AS 'Вид ПУ', py.Mark_PY AS 'Марка ПУ', py.Model_PY AS 'Модель ПУ', py.Is_Distance_Check AS 'Наличие возможности дистанционного снятия показаний', py.Name_DIstance_PY AS 'Наименование системы дистанционного снятия показаний', " +
            "py.Is_Many_PY_Used AS 'Объем ресурса(ов) определяется с помощью нескольких приборов учета', py.Place_Location_PY AS 'Место установки текущего ПУ', py.GIS_Number_PY_To_Connect AS 'Номер ПУ в ГИС ЖКХ', py.Type_Kommunal_Res AS 'Вид коммунального ресурса', " +
            "Unit_Measurement_PY AS 'Единица измерения', py.Type_PU_Number_Tariffs AS 'Вид ПУ по количеству тарифов', py.T1 AS 'Т1', py.T2 AS 'Т2', py.T3 AS 'Т3', py.Trans_Coef AS 'Коэффициент трансформации', py.Installation_Date AS 'Дата установки', " +
            "py.Operation_Date AS 'Дата ввода в эксплуатацию', py.Last_Check_Date AS 'Дата последней поверки', py.Plomb_PU_Date AS 'Дата опломбирования ПУ заводом-изготовителем', py.Is_Temperature_Sensors AS 'Наличие датчиков температуры', py.Temperature_Sensors_Info AS 'Информация о наличии датчиков температуры', " +
            "py.Is_Pressure_Sensors AS 'Наличие датчиков давления', py.Pressure_Sensors_Info AS 'Информация о наличии датчиков давления', py.Is_AutomaticCalculation AS 'Наличие технической возможности автоматического расчета ресурса', py.Unique_GIS_Number AS 'Номер прибора учета в ГИС ЖКХ' " +
            "FROM General_Metering_Device py " +
            "JOIN Characteristic_MKD m ON m.ID = py.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = m.ID_Address " +
            "WHERE m.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@ID", id_house);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                this.dataGridView3.DataSource = dt;
            }
        }
        private void Entrance_DataGrid_Fill()
        {
            string queryE = "SELECT e.ID, m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', e.Entrance_Number AS 'Номер подъезда'," +
            "e.Number_Of_Floors AS 'Этажность', e.Year_Of_Construction AS 'Год постройки', e.Is_Confirmed_Supplier AS 'Информация подтверждена поставщиком' " +
            "FROM Entrance e " +
            "JOIN Characteristic_MKD m ON m.ID = e.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = m.ID_Address " +
            "WHERE m.ID = @ID " +
            "ORDER BY a.Type_Street + ' ' + a.Street + ' ' + m.House_Number";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryE, connection);
                cmd.Parameters.AddWithValue("@ID", id_house);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }
        private void Premises_DataGrid_Fill()
        {
            string queryP = "SELECT p.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома'," +
            "p.Info AS 'Описание помещения', p.Is_Living AS 'Помещение является жилым', p.Premises_Description AS 'Характеристика помещения', p.Total_Area AS 'Общая площадь помещения', p.Living_Total_Area AS 'Жилая площадь помещения'," +
            "p.Is_Common AS 'Является общим имуществом', p.Cadastral_Number AS 'Кадастровый номер', p.Is_Confirmed_Supplier AS 'Информация подтверждена поставщиком' " +
            "FROM MKD_Premises p " +
            "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = m.ID_Address " +
            "WHERE m.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryP, connection);
                cmd.Parameters.AddWithValue("@ID", id_house);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                connection.Close();
            }
        }

        private void Search(TextBox textBox, DataGridView dg)
        {
            string searchValue = textBox.Text;

            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 0; j < dg.ColumnCount; j++)
                {
                    dg[j, i].Style.BackColor = Color.White;
                    dg[j, i].Style.ForeColor = Color.Black;
                }
            }
            List<int> index = new List<int>();
            int count = 0;

            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 1; j < dg.ColumnCount; j++)
                {
                    if (dg[j, i].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        dg[j, i].Style.BackColor = Color.AliceBlue;
                        dg[j, i].Style.ForeColor = Color.Blue;

                        count++;
                    }
                }
                if (count == 0) index.Add(i);
                count = 0;
            }
            index.Reverse();
            if (index.Count != 0)
            {
                foreach (var i in index)
                {
                    dg.Rows.RemoveAt(i);
                }
            }
        }

        private void MKD_SearchForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Color.Black), 0, 300, 1200, 300);
            g.DrawLine(new Pen(Color.Black), 0, 600, 1200, 600);
            g.Dispose();
        }

        private void EntranceEdit_Click(object sender, EventArgs e)
        {
            if (id_entrance > 0)
            {
                var entrance = new Entrance_AF() { Text = $"Изменение данных подъезда №{entrance_number}. {house_name}" };

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
                    //mkd_id = id;
                    Entrance_DataGrid_Fill();
                    id_entrance = 0;                    
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void EntranceRemove_Click(object sender, EventArgs e)
        {
            if (id_entrance > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE Entrance WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", id_entrance);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Запись успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Entrance_DataGrid_Fill();
                id_entrance = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_entrance = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                entrance_number = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                house_name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {
                id_entrance = -1;                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search(textBox1,dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search(textBox2, dataGridView2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Search(textBox3, dataGridView3);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox1,dataGridView1);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                Entrance_DataGrid_Fill();
                e.SuppressKeyPress = true;
            }
        }

        private void EntranceRefresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Entrance_DataGrid_Fill();
        }

        private void PremisesEdit_Click(object sender, EventArgs e)
        {
            if (p_id > 0)
            {
                //int id = mkd_id;
                //mkd_id = p_id;
                var form = new Premises_Edit();
                form.id = p_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    //mkd_id = id;
                    Premises_DataGrid_Fill();
                    p_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                p_id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                p_id = -1;
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                opy_id = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                opy_id = -1;
            }
        }

        private void PremisesRomove_Click(object sender, EventArgs e)
        {
            if (p_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE MKD_Premises WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", p_id);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Запись успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Entrance_DataGrid_Fill();
                p_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PremisesRefresh_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Premises_DataGrid_Fill();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox2,dataGridView2);
            }
            if(e.Control && e.KeyCode == Keys.R)
            {
                Premises_DataGrid_Fill();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox3, dataGridView3);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                OPY_DG_Fill();
                e.SuppressKeyPress = true;
            }
        }

        private void OPYEdit_Click(object sender, EventArgs e)
        {
            if (opy_id > 0)
            {
                //int id = mkd_id;
                //mkd_id = opy_id;
                var form = new OPY_Edit();
                form.id = opy_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    //mkd_id = id;
                    OPY_DG_Fill();
                    opy_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void OPYRemove_Click(object sender, EventArgs e)
        {
            if (opy_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE General_Metering_Device WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", opy_id);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Запись успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                OPY_DG_Fill();
                opy_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void OPYRefresh_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            OPY_DG_Fill();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var entrance = new Entrance_AF();
            //entrance.id = mkd_id;
            DialogResult result = entrance.ShowDialog();
            if (result == DialogResult.Cancel)
                Entrance_DataGrid_Fill();
        }

        private void Add_Func(string load_query, string save_query, string query_reload, DataGridView dgv, string add_obj)
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(load_query, connection);
                cmd.Parameters.AddWithValue("@ID", id_house);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            var entrance = new Entrance_AF() { Text = $"Добавление нового {add_obj}. {house_name}" };
            entrance.Load_Data(dt);
            entrance.save_query = save_query;
            entrance.status = "добавлена";
            entrance.entranceBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = entrance.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_reload, dgv);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var form = new Premises_AF();
            form.id = id_house;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                Premises_DataGrid_Fill();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var form = new OPY_AF();
            form.id = id_house;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                Premises_DataGrid_Fill();
        }
    }
}
