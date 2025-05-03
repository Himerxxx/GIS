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
        public string save_query,status;
      
        public MKD_AF()
        {
            InitializeComponent();
        }

        private void characteristic_MKDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
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
                    /*string querySave = "INSERT INTO Characteristic_MKD(ID_Address, House_Number, Statys, ID_FIAS, OKTMO, Life_Cycle_Stage, " +
                        "Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, Olson, Is_Cultural_Legacy, " +
                        "Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R) " +
                        $"VALUES({comboBox1.SelectedValue}, {house_NumberTextBox.Text}, {comboBox2.SelectedIndex}, {GIS_Data.Check_TN(iD_FIASTextBox)}, {maskedTextBox1.Text}, " +
                        $"{comboBox3.SelectedIndex}, {total_Building_AreaTextBox.Text}, {maskedTextBox2.Text}, {count_floorsTextBox.Text}, " +
                        $"{count_UnderfloorsTextBox.Text}, {comboBox4.SelectedIndex}, {comboBox5.SelectedIndex}, {GIS_Data.Check_TN(cadastral_NumberTextBox)}, " +
                        $"{payment_Account_STextBox.Text}, {maskedTextBox3.Text}, {payment_Account_RTextBox.Text}, {maskedTextBox4.Text}) ";*/

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query);

                        command.Parameters.AddWithValue("@ID_Address", comboBox1.SelectedValue);
                        command.Parameters.AddWithValue("@House_Number", house_NumberTextBox.Text);
                        command.Parameters.AddWithValue("@Statys", comboBox2.SelectedIndex);
                        command.Parameters.AddWithValue("@ID_FIAS", GIS_Data.Check_T(iD_FIASTextBox));
                        command.Parameters.AddWithValue("@OKTMO", maskedTextBox1.Text);
                        command.Parameters.AddWithValue("@Life_Cycle_Stage", comboBox3.SelectedIndex);
                        command.Parameters.AddWithValue("@Total_Building_Area", total_Building_AreaTextBox.Text);
                        command.Parameters.AddWithValue("@Year_Of_Commissioning", maskedTextBox2.Text);
                        command.Parameters.AddWithValue("@Count_floors", count_floorsTextBox.Text);
                        command.Parameters.AddWithValue("@Count_Underfloors", count_UnderfloorsTextBox.Text);
                        command.Parameters.AddWithValue("@Olson", comboBox4.SelectedIndex);
                        command.Parameters.AddWithValue("@Is_Cultural_Legacy", comboBox5.SelectedIndex);
                        command.Parameters.AddWithValue("@Cadastral_Number", GIS_Data.Check_T(cadastral_NumberTextBox));
                        command.Parameters.AddWithValue("@Payment_Account_S", payment_Account_STextBox.Text);
                        command.Parameters.AddWithValue("@BIK_S", maskedTextBox3.Text);
                        command.Parameters.AddWithValue("@Payment_Account_R", payment_Account_RTextBox.Text);
                        command.Parameters.AddWithValue("@BIK_R", maskedTextBox4.Text);                        

                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show($"Запись успешно {status}", "Успешно", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Load_Data(DataTable dt)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Street";
        }

        public void Load_Data_Edit(DataTable dt, string query_load_edit, int id)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Street";         

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_load_edit, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.SelectedValue = dr.GetValue(0);
                    house_NumberTextBox.Text = dr.GetValue(1).ToString();
                    comboBox2.SelectedIndex = int.Parse(dr.GetValue(2).ToString());
                    iD_FIASTextBox.Text = dr.GetValue(3).ToString();
                    maskedTextBox1.Text = dr.GetValue(4).ToString();
                    comboBox3.SelectedIndex = int.Parse(dr.GetValue(5).ToString());
                    total_Building_AreaTextBox.Text = dr.GetValue(6).ToString().Replace(",", ".");
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

        private void MKD_AF_Load(object sender, EventArgs e)
        {

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
