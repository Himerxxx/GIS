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

namespace GIS.Forms
{
    public partial class Entrance_AF : Form
    {
        //public int id;
        //public string load_query;
        //public string save_query;
        public string status;

        public string save_query;
        public Entrance_AF()
        {
            InitializeComponent();
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите Адрес дома");
            else if (maskedTextBox1.Text != "" && maskedTextBox1.Text.Count() != 4)
                MessageBox.Show("Год постройки подъезда введен не корректно");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение поля: Информация подтверждена поставщиком");
            else if (entrance_NumberTextBox.Text == "")
                MessageBox.Show("Введите номер подъезда");
            else
            {
                try
                {                                
                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(save_query);

                        command.Parameters.AddWithValue("@ID_MKD_Address", comboBox1.SelectedValue);
                        command.Parameters.AddWithValue("@Number_Of_Floors", GIS_Data.Check_T(number_Of_FloorsTextBox));
                        command.Parameters.AddWithValue("@Year_Of_Construction", GIS_Data.Check_M(maskedTextBox1));
                        command.Parameters.AddWithValue("@Is_Confirmed_Supplier", comboBox2.SelectedIndex);
                        command.Parameters.AddWithValue("@Entrance_Number", entrance_NumberTextBox.Text);                       

                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show($"Запись успешно {status}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Load_Data_Edit(int id)
        {
            CB_Fill();

            string query1 = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' " +
                "FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address";

            string query = "SELECT ID_MKD_Address, Number_Of_Floors, Year_Of_Construction, Is_Confirmed_Supplier, Entrance_Number " +
                "FROM Entrance e " +
                "WHERE e.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);

                this.comboBox1.DataSource = dt;
                this.comboBox1.ValueMember = "ID";//столбец с id
                this.comboBox1.DisplayMember = "Address";// столбец для отображения
            }

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.SelectedValue = dr.GetValue(0);
                    number_Of_FloorsTextBox.Text = dr.GetValue(1).ToString();
                    maskedTextBox1.Text = dr.GetValue(2).ToString();
                    comboBox2.SelectedIndex = dr.GetValue(3).ToString() == "False" ? 0 : 1;
                    entrance_NumberTextBox.Text = dr.GetValue(4).ToString();
                }
                connection.Close();
            }
        }

        public void Load_Data(DataTable dt)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";

            comboBox1.DropDownHeight = comboBox1.ItemHeight * 10 - 5;
        }

        private void Entrance_AF_Load(object sender, EventArgs e)
        {

        }

        private void CB_Fill()
        {
            string[] yesno = new string[2] { "Да", "Нет" };            

            comboBox2.Items.AddRange(yesno);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Count();
        }
    }
}
