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
    public partial class Premises_AF : Form
    {
        //public int id;
        public string save_query, status;

        public Premises_AF()
        {
            InitializeComponent();
        }

        private void mKD_PremisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохрание данных в БД

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите Адрес дома");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Помещение является жилым");
            else if (infoTextBox.Text == "")
                MessageBox.Show("Введите значение для поля: Информация о помещениии");
            else if (cadastral_NumberTextBox.Text == "")
                MessageBox.Show("Введите кадастровый номер помещения");
            else if (comboBox4.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Информация подтверждена поставщиком");
            else
            {
                try
                {
                    /*string querySave = "INSERT INTO MKD_Premises(ID_MKD_Address, Info,Is_Living, Premises_Description, Total_Area, Living_Total_Area, Is_Common, Cadastral_Number, Is_Confirmed_Supplier) " +
                        $"VALUES({comboBox1.SelectedValue}, {Check_TN(infoTextBox)},{comboBox2.SelectedIndex}, {Check_C(comboBox5)}, " +
                        $"{Check_TD(total_AreaTextBox)}, {Check_TD(living_Total_AreaTextBox)}, " +
                        $"{Check_C(comboBox3)}, {Check_TN(cadastral_NumberTextBox)}, {comboBox4.SelectedIndex})";*/

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query);

                        command.Parameters.AddWithValue("@ID_MKD_Address", comboBox1.SelectedValue);
                        command.Parameters.AddWithValue("@Info", GIS_Data.Check_T(infoTextBox));
                        command.Parameters.AddWithValue("@Is_Living", comboBox2.SelectedIndex);
                        command.Parameters.AddWithValue("@Premises_Description", GIS_Data.Check_C(comboBox5));
                        command.Parameters.AddWithValue("@Total_Area", GIS_Data.Check_TD(total_AreaTextBox));
                        command.Parameters.AddWithValue("@Living_Total_Area", GIS_Data.Check_TD(living_Total_AreaTextBox));
                        command.Parameters.AddWithValue("@Is_Common", GIS_Data.Check_C(comboBox3));
                        command.Parameters.AddWithValue("@Cadastral_Number", GIS_Data.Check_T(cadastral_NumberTextBox));
                        command.Parameters.AddWithValue("@Is_Confirmed_Supplier", comboBox4.SelectedIndex);

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

        public void Load_Data(DataTable dt)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";
        }

        public void Load_Data_Edit(DataTable dt, string query_load_edit, int id)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";

            comboBox1.DropDownHeight = comboBox1.ItemHeight * 10 - 5;

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_load_edit, connection);
                cmd.Parameters.AddWithValue("@ID", id);

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

        private void Premises_AF_Load(object sender, EventArgs e)
        {

        }

        private void CB_Fill()
        {
            string[] yesno = { "Да", "Нет" };
            string[] description = { "Отдельная квартира", "Квартира коммунального заселения", "Общежитие" };

            comboBox2.Items.AddRange(yesno);
            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(description);
        }
    }
}
