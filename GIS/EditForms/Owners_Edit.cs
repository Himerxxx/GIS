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
    public partial class Owners_Edit : Form
    {
        public int id;
        public Owners_Edit()
        {
            InitializeComponent();
        }

        private void Owners_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            Owners_Load_Data();
        }

        private void CB_Fill()
        {
            string[] passType = { "Паспорт гражданина Российской Федерации", "Паспорт гражданина СССР", "Паспорт гражданина иностранного государства", "Общегражданский заграничный паспорт", "Заграничный паспорт Министерства морского флота", "Дипломатический паспорт", "Паспорт моряка (удостоверение личности моряка)", "Военный билет военнослужащего", "Временное удостоверение, выданное взамен военного билета", "Удостоверение личности офицера Министерства обороны Российской Федерации, Министерства внутренних дел Российской Федерации и других воинских формирований с приложением справки о прописке (регистрации) Ф-33", "Свидетельство о рождении", "Свидетельство о рассмотрении ходатайства о признании беженцем на территории Российской Федерации по существу", "Вид на жительство иностранного гражданина или лица без гражданства", "Справка об освобождении из мест лишения свободы", "Временное удостоверение личности гражданина Российской Федерации", "Удостоверение вынужденного переселенца", "Разрешение на временное проживание в Российской Федерации", "Удостоверение беженца в Российской Федерации", "Свидетельство о рассмотрении ходатайства о признании лица вынужденным переселенцем", "Свидетельство о предоставлении временного убежища на территории Российской Федерации", "Иные документы, предусмотренные законодательством Российской Федерации или признаваемые в соответствии с международным договором Российской Федерации в качестве документов, удостоверяющих личность" };

            comboBox1.Items.AddRange(passType);
        }

        private void Owners_Load_Data()
        {
            string queryLoad = "SELECT FirstName, SecondName, LastName, SNILS, Passport_Type, Passport_Series, " +
                "Passport_Number, Passport_Date, OGRN, NZA, KPP FROM Owner_LS o " +
                "WHERE o.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    firstNameTextBox.Text = dr.GetValue(0).ToString();
                    secondNameTextBox.Text = dr.GetValue(1).ToString();
                    lastNameTextBox.Text = dr.GetValue(2).ToString();
                    maskedTextBox1.Text = dr.GetValue(3).ToString();
                    comboBox1.SelectedIndex = int.Parse(dr.GetValue(4).ToString());
                    maskedTextBox2.Text = dr.GetValue(5).ToString();
                    maskedTextBox3.Text = dr.GetValue(6).ToString();
                    passport_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(7).ToString().Replace("-","."));
                    oGRNTextBox.Text = dr.GetValue(8).ToString();
                    nZATextBox.Text = dr.GetValue(9).ToString();
                    kPPTextBox.Text = dr.GetValue(10).ToString();
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
                string querySave = $"UPDATE Owner_LS SET FirstName = {Check_TN(firstNameTextBox)}, " +
                    $"SecondName = {Check_TN(secondNameTextBox)}, LastName = {Check_TN(lastNameTextBox)}, " +
                    $"SNILS = {Check_M(maskedTextBox1)}, Passport_Type = {comboBox1.SelectedIndex}, Passport_Series = {maskedTextBox2.Text}, " +
                    $"Passport_Number = {maskedTextBox3.Text}, Passport_Date = {Check_D(passport_DateDateTimePicker)}, " +
                    $"OGRN = {Check_T(oGRNTextBox)}, NZA = {Check_T(nZATextBox)}, KPP = {Check_T(kPPTextBox)} " +
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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : $"'{e.Value.ToShortDateString().Replace(".", "-")}'";

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Count();
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.SelectionStart = maskedTextBox2.Text.Count();
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            maskedTextBox3.SelectionStart = maskedTextBox3.Text.Count();
        }
    }
}
