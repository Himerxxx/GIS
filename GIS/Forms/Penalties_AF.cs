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
        public Penalties_AF()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            string query = "SELECT pd.ID AS 'ID', CONVERT(NVARCHAR,pd.Calculation_Period,103) + '-' + CONVERT(NVARCHAR,pd.ID) AS 'PD_Key' FROM Payment_Document pd " +              
                "WHERE pd.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", pd_id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "PD_Key";
            }
        }

        private void Load_Data_Full()
        {
            string query = "SELECT pd.ID AS 'ID', CONVERT(NVARCHAR,pd.Calculation_Period,103) + '-' + CONVERT(NVARCHAR,pd.ID) AS 'PD_Key' FROM Payment_Document pd ";                

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);                
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "PD_Key";
            }
        }

        private void Penalties_AF_Load(object sender, EventArgs e)
        {
            if (pd_id != 0)
            {
                Load_Data();
            }
            else
            {
                Load_Data_Full();
                comboBox1.SelectedItem = null;
            }

            CB_Fill();
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
                string querySave = "INSERT INTO Penalties_And_Court_Costs(ID_PD_Number, Type_Accrual, Reason_Accrual, Sum) " +
                    $"VALUES({comboBox1.SelectedValue}, {comboBox2.SelectedIndex}, {Check_TN(reason_AccrualTextBox)}, {Check_TD(sumTextBox)})";

                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(querySave, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                DialogResult result1 = MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result1 == DialogResult.OK) this.Close();
            }
        }

        private void CB_Fill()
        {
            string[] accrual = { "Пени", "Штрафы", "Государсвенный пошлины", "Судебные издержки"};

            comboBox2.Items.AddRange(accrual);
        }

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

    }
}
