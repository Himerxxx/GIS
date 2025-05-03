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
    public partial class Owners_AF : Form
    {
        public string save_query, status;
        public Owners_AF()
        {
            InitializeComponent();
        }

        private void Owners_AF_Load(object sender, EventArgs e)
        {          

        }

        private void owner_LSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохрание данных в БД

            if (firstNameTextBox.Text == "")
                MessageBox.Show("Введите имя");
            else if (secondNameTextBox.Text == "")
                MessageBox.Show("Введите фамилию");
            else if (lastNameTextBox.Text == "")
                MessageBox.Show("Введите отчество");
            else if (maskedTextBox1.Text != "" && maskedTextBox1.Text.Count() != 11)
                MessageBox.Show("Введите СНИЛС коректно");
            else if (comboBox1.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Тип паспорта");
            else if (maskedTextBox2.Text == "")
                MessageBox.Show("Введите серию паспорта");
            else if (maskedTextBox2.Text != "" && maskedTextBox2.Text.Count() != 4)
                MessageBox.Show("Серия паспорта состоит из четырех цифр");
            else if (maskedTextBox3.Text == "")
                MessageBox.Show("Введите номер паспорта");
            else if (maskedTextBox3.Text != "" && maskedTextBox3.Text.Count() != 6)
                MessageBox.Show("Номер паспорта состоит из шести цифр");
            else if (passport_DateDateTimePicker.Checked == false)
                MessageBox.Show("Введите дату документа");
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query, connection);

                        command.Parameters.AddWithValue("@FirstName", GIS_Data.Check_T(firstNameTextBox));
                        command.Parameters.AddWithValue("@SecondName", GIS_Data.Check_T(secondNameTextBox));
                        command.Parameters.AddWithValue("@LastName", GIS_Data.Check_T(lastNameTextBox));
                        command.Parameters.AddWithValue("@SNILS", GIS_Data.Check_M(maskedTextBox1));
                        command.Parameters.AddWithValue("@Passport_Type", comboBox1.SelectedIndex);
                        command.Parameters.AddWithValue("@Passport_Series", maskedTextBox2.Text);
                        command.Parameters.AddWithValue("@Passport_Number", maskedTextBox3.Text);
                        command.Parameters.AddWithValue("@Passport_Date", GIS_Data.Check_D(passport_DateDateTimePicker));
                        command.Parameters.AddWithValue("@OGRN", GIS_Data.Check_T(oGRNTextBox));
                        command.Parameters.AddWithValue("@NZA", GIS_Data.Check_T(nZATextBox));
                        command.Parameters.AddWithValue("@KPP", GIS_Data.Check_T(kPPTextBox));

                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show($"Запись успешно {status}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }            
            }
        }

        public void Load_Data()
        {
            passport_DateDateTimePicker.Checked = false;

            CB_Fill();
        }

        public void Load_Data_Edit(int id_owner, string query_load)
        {
            CB_Fill();

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query_load, connection);

                command.Parameters.AddWithValue("@ID", id_owner);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    firstNameTextBox.Text = dr.GetValue(0).ToString();
                    secondNameTextBox.Text = dr.GetValue(1).ToString();
                    lastNameTextBox.Text = dr.GetValue(2).ToString();
                    maskedTextBox1.Text = dr.GetValue(3).ToString();
                    comboBox1.SelectedIndex = int.Parse(dr.GetValue(4).ToString());
                    maskedTextBox2.Text = dr.GetValue(5).ToString();
                    maskedTextBox3.Text = dr.GetValue(6).ToString();
                    passport_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(7).ToString().Replace("-", "."));
                    oGRNTextBox.Text = dr.GetValue(8).ToString();
                    nZATextBox.Text = dr.GetValue(9).ToString();
                    kPPTextBox.Text = dr.GetValue(10).ToString();

                    passport_DateDateTimePicker.Checked = true;
                }
                connection.Close();
            }
        }

        private void CB_Fill()
        {
            string[] passType = { "Паспорт гражданина Российской Федерации", 
                "Паспорт гражданина СССР", 
                "Паспорт гражданина иностранного государства", 
                "Общегражданский заграничный паспорт", 
                "Заграничный паспорт Министерства морского флота", 
                "Дипломатический паспорт", 
                "Паспорт моряка (удостоверение личности моряка)", 
                "Военный билет военнослужащего", 
                "Временное удостоверение, выданное взамен военного билета", 
                "Удостоверение личности офицера МО РФ, МВД РФ и других воинских формирований", 
                "Свидетельство о рождении", 
                "Свидетельство о рассмотрении ходатайства о признании беженцем на территории Российской Федерации по существу", 
                "Вид на жительство иностранного гражданина или лица без гражданства", 
                "Справка об освобождении из мест лишения свободы", 
                "Временное удостоверение личности гражданина Российской Федерации", 
                "Удостоверение вынужденного переселенца", 
                "Разрешение на временное проживание в Российской Федерации", 
                "Удостоверение беженца в Российской Федерации", 
                "Свидетельство о рассмотрении ходатайства о признании лица вынужденным переселенцем", 
                "Свидетельство о предоставлении временного убежища на территории Российской Федерации", 
                "Иные документы, удостоверяющие личность" };

            comboBox1.Items.AddRange(passType);
        }

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
