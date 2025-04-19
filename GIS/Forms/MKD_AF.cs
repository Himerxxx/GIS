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
    public partial class MKD_AF : Form
    {

        public MKD_AF()
        {
            InitializeComponent();
        }

        private void characteristic_MKDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.characteristic_MKDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gISDataSet);*/

            //Сохранение данных, с проверкой

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите Адрес дома");
            else if (house_NumberTextBox.Text == "")
                MessageBox.Show("Введите номер дома");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите состояние дома");
            else if (iD_FIASTextBox.Text == "")
                MessageBox.Show("Введите код ФИАС");
            else if (maskedTextBox1.Text == "")
                MessageBox.Show("Введите код ОКТМО");
            else if (maskedTextBox1.Text.Count() != 11)
                MessageBox.Show("Код ОКТМО содержит 11 символов");
            else if (comboBox3.SelectedItem == null)
                MessageBox.Show("Выберите стадию жизненного цикла");
            else if (total_Building_AreaTextBox.Text == "")
                MessageBox.Show("Введите общую площадь здания");
            else if (maskedTextBox2.Text == "")
                MessageBox.Show("Введите год ввода в эксплуатацию");
            else if (maskedTextBox2.Text.Count() != 4)
                MessageBox.Show("Год ввода в эксплуатацию введен не корректно");
            else if (count_floorsTextBox.Text == "")
                MessageBox.Show("Введите количество этажей");
            else if (count_UnderfloorsTextBox.Text == "")
                MessageBox.Show("Введите количество подземных этажей");
            else if (comboBox4.SelectedItem == null)
                MessageBox.Show("Выберите часовой пояс Olson");
            else if (comboBox5.SelectedItem == null)
                MessageBox.Show("Выберите статус объекта культурного наследия");
            else if (cadastral_NumberTextBox.Text == "")
                MessageBox.Show("Введите кадастровый номер");
            else if (payment_Account_STextBox.Text == "")
                MessageBox.Show("Введите расчетный счет для обычных услуг");
            else if (maskedTextBox3.Text == "")
                MessageBox.Show("Введите БИК для обычных услуг");
            else if (maskedTextBox3.Text.Count() != 9)
                MessageBox.Show("БИК должен содержать 9 символов");
            else if (payment_Account_RTextBox.Text == "")
                MessageBox.Show("Введите расчетный счет для капитального ремонта");
            else if (maskedTextBox4.Text == "")
                MessageBox.Show("Введите БИК для капитального ремонта");
            else if (maskedTextBox4.Text.Count() != 9)
                MessageBox.Show("БИК должен содержать 9 символов");
            else
            {
                try
                {
                    string querySave = "INSERT INTO Characteristic_MKD(ID_Address, House_Number, Statys, ID_FIAS, OKTMO, Life_Cycle_Stage, " +
                        "Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, Olson, Is_Cultural_Legacy, " +
                        "Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R) " +
                        $"VALUES({comboBox1.SelectedValue}, {house_NumberTextBox.Text}, {comboBox2.SelectedIndex}, {GIS_Data.Check_TN(iD_FIASTextBox)}, {maskedTextBox1.Text}, " +
                        $"{comboBox3.SelectedIndex}, {total_Building_AreaTextBox.Text}, {maskedTextBox2.Text}, {count_floorsTextBox.Text}, " +
                        $"{count_UnderfloorsTextBox.Text}, {comboBox4.SelectedIndex}, {comboBox5.SelectedIndex}, {GIS_Data.Check_TN(cadastral_NumberTextBox)}, " +
                        $"{payment_Account_STextBox.Text}, {maskedTextBox3.Text}, {payment_Account_RTextBox.Text}, {maskedTextBox4.Text}) ";

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querySave);
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MKD_AF_Load(object sender, EventArgs e)
        {
            this.view_Address_BookTableAdapter.Fill(this.gISDataSet.View_Address_Book);
            comboBox1.SelectedItem = null;

            CB_Fill();
        }

        private void CB_Fill()
        {
            string[] statys = { "Аварийный", "Исправный", "Ветхий" };
            string[] life_stage = { "Эксплуатация", "Реконструкция", "Капитальный ремонт с отселением", "Капитальный ремонт без отселения" };
            string[] olson = { "Калининград", "Москва", "Симферополь", "Волгоград", "Самара", "Екатеринбург", "Новосибирск", "Омск", "Красноярск", "Новокузнецк", "Иркутск", "Чита", "Якутск", "Хандыга", "Владивосток", "Сахалин", "Магадан", "Усть-Нера", "Среднеколымск", "Камчатка", "Анадырь" };
            string[] yesno = { "Да", "Нет" };

            /*string queryC1 = "SELECT ID, Type_Street + ' ' + Street AS 'Street' FROM Address_Book";

            using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryC1, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Street";
                comboBox1.SelectedItem = null;
            }*/

            comboBox2.Items.AddRange(statys);
            comboBox3.Items.AddRange(life_stage);
            comboBox4.Items.AddRange(olson);
            comboBox5.Items.AddRange(yesno);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;
  
        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : e.Value.ToShortDateString();

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text.Trim()}'";

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

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            maskedTextBox4.SelectionStart = maskedTextBox4.Text.Count();
        }
    }
}
