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
    public partial class MKD_Edit : Form
    {
        public int id;
        public MKD_Edit()
        {
            InitializeComponent();
        }

        private void MKD_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            MKD_Load_Data();
        }

        private void MKD_Load_Data()
        {
            string queryC1 = "SELECT ID, Type_Street + ' ' + Street AS 'Street' FROM Address_Book";

            string queryLoad = "SELECT ID_Address, House_Number, Statys, ID_FIAS, OKTMO, " +
                "Life_Cycle_Stage, Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, " +
                "Olson, Is_Cultural_Legacy, Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R FROM Characteristic_MKD m " +
                "WHERE m.ID = @ID";

            using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryC1, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Street";
            }

            using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);

                cmd.Parameters.AddWithValue("@ID",id);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.SelectedValue = dr.GetValue(0);
                    house_NumberTextBox.Text = dr.GetValue(1).ToString();
                    comboBox2.SelectedIndex = int.Parse(dr.GetValue(2).ToString());
                    iD_FIASTextBox.Text = dr.GetValue(3).ToString();
                    maskedTextBox1.Text = dr.GetValue(4).ToString();
                    comboBox3.SelectedIndex = int.Parse(dr.GetValue(5).ToString());
                    total_Building_AreaTextBox.Text = dr.GetValue(6).ToString().Replace(",",".");
                    maskedTextBox2.Text = dr.GetValue(7).ToString();
                    count_floorsTextBox.Text = dr.GetValue(8).ToString();
                    count_UnderfloorsTextBox.Text = dr.GetValue(9).ToString();
                    comboBox4.SelectedIndex = int.Parse(dr.GetValue(10).ToString());
                    comboBox5.SelectedIndex = dr.GetValue(11).ToString() == "False" ? 0 : 1;
                    cadastral_NumberTextBox.Text = dr.GetValue(12).ToString();
                    payment_Account_STextBox.Text = dr.GetValue(13).ToString();
                    maskedTextBox3.Text = dr.GetValue(14).ToString();
                    payment_Account_RTextBox.Text = dr.GetValue(15).ToString();
                    maskedTextBox4.Text = dr.GetValue(16).ToString();
                }

                connection.Close();
            }
        }

        private void CB_Fill()
        {
            string[] statys = { "Аварийный", "Исправный", "Ветхий" };
            string[] life_stage = { "Эксплуатация", "Реконструкция", "Капитальный ремонт с отселением", "Капитальный ремонт без отселения" };
            string[] olson = { "Калининград", "Москва", "Симферополь", "Волгоград", "Самара", "Екатеринбург", "Новосибирск", "Омск", "Красноярск", "Новокузнецк", "Иркутск", "Чита", "Якутск", "Хандыга", "Владивосток", "Сахалин", "Магадан", "Усть-Нера", "Среднеколымск", "Камчатка", "Анадырь" };
            string[] yesno = { "Да", "Нет" };

            comboBox2.Items.AddRange(statys);
            comboBox3.Items.AddRange(life_stage);
            comboBox4.Items.AddRange(olson);
            comboBox5.Items.AddRange(yesno);
        }

        private void Save_Edit()
        {
            try
            {
                string querySave = $"UPDATE Characteristic_MKD SET ID_Address = {comboBox1.SelectedValue}, House_Number = {house_NumberTextBox.Text}, Statys = {comboBox2.SelectedIndex}, ID_FIAS = {Check_TN(iD_FIASTextBox)}, OKTMO = {maskedTextBox1.Text}, " +
                    $"Life_Cycle_Stage = {comboBox3.SelectedIndex}, Total_Building_Area = {total_Building_AreaTextBox.Text}, Year_Of_Commissioning = {maskedTextBox2.Text}, Count_floors = {count_floorsTextBox.Text}, Count_Underfloors = {count_UnderfloorsTextBox.Text}, " +
                    $"Olson = {comboBox4.SelectedIndex}, Is_Cultural_Legacy = {comboBox5.SelectedIndex}, Cadastral_Number = {Check_TN(cadastral_NumberTextBox)}, Payment_Account_S = {payment_Account_STextBox.Text}, BIK_S = {maskedTextBox3.Text}, Payment_Account_R = {payment_Account_RTextBox.Text}, BIK_R = {maskedTextBox4.Text} " +
                    $"WHERE ID = {id}";

                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString)) 
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(querySave, connection);
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

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";
    }
}
