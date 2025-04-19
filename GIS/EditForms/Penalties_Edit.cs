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
    public partial class Penalties_Edit : Form
    {
        public int id;
        public Penalties_Edit()
        {
            InitializeComponent();
        }

        private void Penalties_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            Penalties_Load_Data();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void Penalties_Load_Data()
        {
            string queryC1 = "SELECT ID FROM Payment_Document";

            string queryLoad = "SELECT Type_Accrual, Reason_Accrual, Sum FROM Penalties_And_Court_Costs p " +
                "WHERE p.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryC1, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "ID";
            }

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);
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

        private void Save_Edit()
        {
            if(Check_Save() == true)
            {
                try
                {
                    string querySave = $"UPDATE Penalties_And_Court_Costs SET ID_PD_Number = {comboBox1.SelectedValue}, " +
                        $"Type_Accrual = {comboBox2.SelectedIndex}, Reason_Accrual = {Check_TN(reason_AccrualTextBox)}, " +
                        $"Sum = {Check_TD(sumTextBox)} " +
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


        private bool Check_Save()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Выберите номер ПД");
                return false;
            }

            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Вид начисления");
                return false;
            }
            else return true;
        }

        private void CB_Fill()
        {
            string[] accrual = { "Пени", "Штрафы", "Государсвенный пошлины", "Судебные издержки" };

            comboBox2.Items.AddRange(accrual);
        }

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

    }
}
