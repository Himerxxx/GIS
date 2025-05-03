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
    public partial class Penalties_AF : Form
    {
        public int pd_id;
        public string save_query, status;
        public Penalties_AF()
        {
            InitializeComponent();
        }

        public void Load_Data(DataTable dt)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "PD_Key";

            comboBox1.DropDownHeight = comboBox1.ItemHeight * 10 - 5;
        }

        public void Load_Data_Edit(DataTable dt, string query_load_edit, int id)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "PD_Key";

            comboBox1.DropDownHeight = comboBox1.ItemHeight * 10 - 5;

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_load_edit, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.SelectedIndex = int.Parse(dr.GetValue(0).ToString());
                    reason_AccrualTextBox.Text = dr.GetValue(1).ToString();
                    sumTextBox.Text = dr.GetValue(2).ToString();
                }
                connection.Close();
            }
        }

        private void Penalties_AF_Load(object sender, EventArgs e)
        {

        }

        private void penalties_And_Court_CostsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных в БД

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите номер ПД");
            else if(comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Вид начисления");
            else
            {
                /*string querySave = "INSERT INTO Penalties_And_Court_Costs(ID_PD_Number, Type_Accrual, Reason_Accrual, Sum) " +
                    $"VALUES({comboBox1.SelectedValue}, {comboBox2.SelectedIndex}, {Check_TN(reason_AccrualTextBox)}, {Check_TD(sumTextBox)})";*/

                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(save_query, connection);

                    command.Parameters.AddWithValue("@ID_PD_Number", comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@Type_Accrual", comboBox2.SelectedIndex);
                    command.Parameters.AddWithValue("@Reason_Accrual", GIS_Data.Check_T(reason_AccrualTextBox));
                    command.Parameters.AddWithValue("@Sum", GIS_Data.Check_TD(sumTextBox));                 

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                DialogResult result1 = MessageBox.Show($"Запись успешно {status}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result1 == DialogResult.OK) this.Close();
            }
        }

        private void CB_Fill()
        {
            string[] accrual = { "Пени", "Штрафы", "Государсвенный пошлины", "Судебные издержки"};

            comboBox2.Items.AddRange(accrual);
        }

    }
}
