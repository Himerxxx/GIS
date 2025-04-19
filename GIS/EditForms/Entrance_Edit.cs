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

namespace GIS.EditForms
{     
    public partial class Entrance_Edit : Form
    {
        public int id;

        public Entrance_Edit()
        {
            InitializeComponent();
        }

        private void Entrance_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            Entrance_Load_Data();
        }

        private void Entrance_Load_Data()
        {
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

        private void CB_Fill()
        {
            string[] yesno = new string[2] { "Да", "Нет" };

            comboBox2.Items.AddRange(yesno);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void Save_Edit()
        {
            try
            {
                string query = $"UPDATE Entrance SET ID_MKD_Address = {comboBox1.SelectedValue}, Number_Of_Floors = {number_Of_FloorsTextBox.Text}, Year_Of_Construction = {maskedTextBox1.Text}, Is_Confirmed_Supplier = {comboBox2.SelectedIndex}, Entrance_Number = {entrance_NumberTextBox.Text} " +
                    $"WHERE ID = {id}";

                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Данные изменены");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Count();
        }
    }
}
