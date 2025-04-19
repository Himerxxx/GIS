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
        public Owners_AF()
        {
            InitializeComponent();
        }

        private void Owners_AF_Load(object sender, EventArgs e)
        {          
            passport_DateDateTimePicker.Checked = false;

            CB_Fill();
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
                    string querySave = "INSERT INTO Owner_LS(FirstName, SecondName, LastName, SNILS, Passport_Type, " +
                        "Passport_Series, Passport_Number, Passport_Date) " +
                        $"VALUES({Check_TN(firstNameTextBox)}, {Check_TN(secondNameTextBox)}, {Check_TN(lastNameTextBox)}, " +
                        $"{Check_M(maskedTextBox1)}, {comboBox1.SelectedIndex}, " +
                        $"{maskedTextBox2.Text}, {maskedTextBox3.Text}, CONVERT(VARCHAR,{Check_D(passport_DateDateTimePicker)},103))";
                    
                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querySave,connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }            
            }
        }
        private void CB_Fill()
        {
            string[] passType = { "Паспорт гражданина Российской Федерации", "Паспорт гражданина СССР", "Паспорт гражданина иностранного государства", "Общегражданский заграничный паспорт", "Заграничный паспорт Министерства морского флота", "Дипломатический паспорт", "Паспорт моряка (удостоверение личности моряка)", "Военный билет военнослужащего", "Временное удостоверение, выданное взамен военного билета", "Удостоверение личности офицера Министерства обороны Российской Федерации, Министерства внутренних дел Российской Федерации и других воинских формирований с приложением справки о прописке (регистрации) Ф-33", "Свидетельство о рождении", "Свидетельство о рассмотрении ходатайства о признании беженцем на территории Российской Федерации по существу", "Вид на жительство иностранного гражданина или лица без гражданства", "Справка об освобождении из мест лишения свободы", "Временное удостоверение личности гражданина Российской Федерации", "Удостоверение вынужденного переселенца", "Разрешение на временное проживание в Российской Федерации", "Удостоверение беженца в Российской Федерации", "Свидетельство о рассмотрении ходатайства о признании лица вынужденным переселенцем", "Свидетельство о предоставлении временного убежища на территории Российской Федерации", "Иные документы, предусмотренные законодательством Российской Федерации или признаваемые в соответствии с международным договором Российской Федерации в качестве документов, удостоверяющих личность" };

            comboBox1.Items.AddRange(passType);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text.Trim()}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e)
        {
            if (e.Checked == false) return "null";
            else
            {
                string date = e.Value.ToShortDateString().Replace(".","");             
                return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);
            }
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
