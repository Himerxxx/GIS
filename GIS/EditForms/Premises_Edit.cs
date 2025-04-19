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
    public partial class Premises_Edit : Form
    {
        public int id;
        public Premises_Edit()
        {
            InitializeComponent();
        }

        private void Premises_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            Premises_Load_Data();
        }

        private void Premises_Load_Data()
        {
            string queryC1 = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "ORDER BY a.Street";

            string queryLoad = "SELECT ID_MKD_Address, Is_Living, Premises_Description, Total_Area, Living_Total_Area,Is_Common, Cadastral_Number, Is_Confirmed_Supplier, Info FROM MKD_Premises p " +
                "WHERE p.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryC1, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Address";
            }

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);
                cmd.Parameters.AddWithValue("@ID",id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.SelectedValue = dr.GetValue(0);
                    infoTextBox.Text = dr.GetValue(8).ToString();
                    comboBox2.SelectedIndex = dr.GetValue(1).ToString() == "False" ? 0 : 1;
                    if (dr.GetValue(2).ToString() == "")
                        comboBox3.SelectedItem = null;
                    else comboBox3.SelectedIndex = int.Parse(dr.GetValue(2).ToString());
                    total_AreaTextBox.Text = dr.GetValue(3).ToString().Replace(",", ".");
                    living_Total_AreaTextBox.Text = dr.GetValue(4).ToString();
                    if (dr.GetValue(5).ToString() == "")
                        comboBox4.SelectedItem = null;
                    else comboBox4.SelectedIndex = dr.GetValue(5).ToString() == "False" ? 0 : 1;
                    cadastral_NumberTextBox.Text = dr.GetValue(6).ToString();
                    comboBox5.SelectedIndex = dr.GetValue(7).ToString() == "False" ? 0 : 1;
                }
                connection.Close();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void Save_Edit()
        {
            try
            {
                string querySave = $"UPDATE MKD_Premises SET ID_MKD_Address = {comboBox1.SelectedValue}, Info = {Check_TN(infoTextBox)}," +
                    $"Is_Living = {comboBox2.SelectedIndex}, Premises_Description = {Check_C(comboBox3)}, " +
                    $"Total_Area = {Check_TD(total_AreaTextBox)}, Living_Total_Area = {Check_TD(living_Total_AreaTextBox)}, Is_Common = {comboBox4.SelectedIndex}, " +
                    $"Cadastral_Number = {Check_TN(cadastral_NumberTextBox)}, Is_Confirmed_Supplier = {comboBox5.SelectedIndex} " +
                    $"WHERE ID = {id}";

                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(querySave, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();                  
                }
                MessageBox.Show("Данные сохранены");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_Fill()
        {
            string[] yesno = { "Да", "Нет" };
            string[] description = { "Отдельная квартира", "Квартира коммунального заселения", "Общежитие" };

            comboBox2.Items.AddRange(yesno);
            comboBox3.Items.AddRange(description);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(yesno);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : $"'{e.Value.ToShortDateString().Replace(".", "-")}'";

    }
}
