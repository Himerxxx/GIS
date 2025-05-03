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
    public partial class LS_AF : Form
    {
        public string save_query, status;
        public LS_AF()
        {
            InitializeComponent();
        }

        private void LS_AF_Load(object sender, EventArgs e)
        {

        }

        private void lSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных в БД

            if (comboBox6.SelectedValue == null)
                MessageBox.Show("Выберите значение для поля: Владелец ЛС");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Тип ЛС");
            else if (comboBox5.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Является открытым");
            else
            {
                try
                {
                    /*string querySave = "INSERT INTO LS(ID_Owner, Type_LS, Number_JKY, Is_Employer, Is_Splited, ShareOfPayment, Is_Open) " +
                        $"VALUES({comboBox6.SelectedValue},{comboBox2.SelectedIndex}, " +
                        $"{GIS_Data.Check_TN(number_JKYTextBox)}, {GIS_Data.Check_C(comboBox3)}, " +
                        $"{GIS_Data.Check_C(comboBox4)}, {GIS_Data.Check_TD(shareOfPaymentTextBox)}, " +
                        $"{comboBox5.SelectedIndex})";
                    string queryUpdate = $"UPDATE LS SET ID_Owner = {comboBox6.SelectedValue}, Type_LS = {comboBox2.SelectedIndex}, " +
                        $"Number_JKY = {GIS_Data.Check_TN(number_JKYTextBox)}, Is_Employer = {comboBox3.SelectedIndex}, " +
                        $"Is_Splited = {comboBox4.SelectedIndex}, ShareOfPayment = {GIS_Data.Check_TD(shareOfPaymentTextBox)}, Is_Open = {comboBox5.SelectedIndex}, ELS = {GIS_Data.Check_T(eLSTextBox)} " +
                        $"WHERE ID = id";

                    number_JKYTextBox.Text = queryUpdate;*/

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query,connection);

                        command.Parameters.AddWithValue("@ID_Owner", comboBox6.SelectedValue);
                        command.Parameters.AddWithValue("@Type_LS", comboBox2.SelectedIndex);
                        command.Parameters.AddWithValue("@Number_JKY", GIS_Data.Check_T(number_JKYTextBox));
                        command.Parameters.AddWithValue("@Is_Employer", GIS_Data.Check_C(comboBox3));
                        command.Parameters.AddWithValue("@Is_Splited", GIS_Data.Check_C(comboBox4));
                        command.Parameters.AddWithValue("@ShareOfPayment", GIS_Data.Check_TD(shareOfPaymentTextBox));
                        command.Parameters.AddWithValue("@Is_Open", comboBox5.SelectedIndex);
                        command.Parameters.AddWithValue("@ELS", GIS_Data.Check_T(eLSTextBox));

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

        public void Load_Data(DataTable dt)
        {
            CB_Fill();

            comboBox6.DataSource = dt;
            comboBox6.ValueMember = "ID";
            comboBox6.DisplayMember = "FIO";
        }

        public void Load_Data_Edit(DataTable dt, string query_load_edit, int id)
        {
            CB_Fill();

            comboBox6.DataSource = dt;
            comboBox6.ValueMember = "ID";
            comboBox6.DisplayMember = "FIO";

            comboBox6.DropDownHeight = comboBox6.ItemHeight * 10 - 5;            

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_load_edit, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox6.SelectedValue = dr.GetValue(7);
                    comboBox2.SelectedIndex = int.Parse(dr.GetValue(0).ToString());
                    number_JKYTextBox.Text = dr.GetValue(1).ToString();
                    if (dr.GetValue(2).ToString() == "")
                        comboBox3.SelectedItem = null;
                    else comboBox3.SelectedIndex = dr.GetValue(2).ToString() == "False" ? 0 : 1;
                    if (dr.GetValue(3).ToString() == "")
                        comboBox4.SelectedItem = null;
                    else comboBox4.SelectedIndex = dr.GetValue(3).ToString() == "False" ? 0 : 1;
                    shareOfPaymentTextBox.Text = dr.GetValue(4).ToString();
                    comboBox5.SelectedIndex = dr.GetValue(5).ToString() == "False" ? 0 : 1;
                    eLSTextBox.Text = dr.GetValue(6).ToString();
                }
                connection.Close();
            }
        }

        private void CB_Fill()
        {
            string[] type = { "ЛС УО", "ЛС РСО", "ЛС ОГВ/ОМС", "ЛС КР", "ЛС РЦ", "ЛС ТКО" };
            string[] yesno = { "Да", "Нет" };

            comboBox2.Items.AddRange(type);
            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(yesno);
        }
    }
}
