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
    public partial class LS_Edit : Form
    {
        public int id;
        public LS_Edit()
        {
            InitializeComponent();
        }

        private void LS_Load_Data()
        {
            string queryC2 = "SELECT ID, FirstName + ' ' + SecondName + ' ' + LastName AS FIO " +
                "FROM Owner_LS"; 

            string queryLoad = "SELECT Type_LS, Number_JKY, Is_Employer, Is_Splited, ShareOfPayment, Is_Open, ELS, ID_Owner FROM LS l " +
                "WHERE l.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryC2, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox6.DataSource = dt;
                comboBox6.ValueMember = "ID";
                comboBox6.DisplayMember = "FIO";
            }

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);
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

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private bool Check_Save()
        {              
            if (comboBox6.SelectedValue == null)
            {
                MessageBox.Show("Выберите значение для поля: Владелец ЛС");
                return false;
            }                
            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Тип ЛС");
                return false;
            }                
            else if (comboBox5.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Является открытым");
                return false;
            }                
            else return true;
        }

        private void Save_Edit()
        {
            if(Check_Save() == true)
            {
                try
                {
                    string querySave = $"UPDATE LS SET ID_Owner = {comboBox6.SelectedValue}, Type_LS = {comboBox2.SelectedIndex}, " +
                        $"Number_JKY = {Check_TN(number_JKYTextBox)}, Is_Employer = {comboBox3.SelectedIndex}, " +
                        $"Is_Splited = {comboBox4.SelectedIndex}, ShareOfPayment = {Check_T(shareOfPaymentTextBox)}, Is_Open = {comboBox5.SelectedIndex}, ELS = {Check_T(eLSTextBox)} " +
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
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : e.Value.ToShortDateString();

        private void CB_Fill()
        {
            string[] type = { "ЛС УО", "ЛС РСО", "ЛС ОГВ/ОМС", "ЛС КР", "ЛС РЦ", "ЛС ТКО" };
            string[] yesno = { "Да", "Нет" };

            comboBox2.Items.AddRange(type);
            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(yesno);
        }

        private void LS_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            LS_Load_Data();
        }
    }
}
