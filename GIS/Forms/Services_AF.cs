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
    public partial class Services_AF : Form
    {
        public int pd_id;
        public Services_AF()
        {
            InitializeComponent();
        }

        private void services_For_The_Payment_PeriodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных в БД

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите значение для поля: Номер ПД");
            else
            {
                try
                {
                    string querySave = "INSERT INTO Services_For_The_Payment_Period(ID_PD_Number, Services, Metod_Det_V_Servise, V_S_Count_Servise, Metod_Det_V_Resourses," +
                        "V_S_Count_Resourses, Tarif, Accrued_Pilling_Period, Total_Period, Increase_Coef, Value_Increase_Payment, Benefits, Order_Payment, Debt_Avans," +
                        "Penalty, Penalty_Provider, State_Duties, Jud_Cost, Recalculations, Sum_Recalculations, Installment_Payment_Value, Installment_Payment_Percent, Total) " +
                        $"VALUES({comboBox1.SelectedValue}, {Check_C(comboBox2)}, {Check_C(comboBox3)}, {Check_TD(v_S_Count_ServiseTextBox)}, {Check_C(comboBox4)}," +
                        $"{Check_TD(v_S_Count_ResoursesTextBox)},{Check_TD(tarifTextBox)},{Check_TD(accrued_Pilling_PeriodTextBox)},{Check_TD(total_PeriodTextBox)}," +
                        $"{Check_TD(increase_CoefTextBox)},{Check_T(value_Increase_PaymentTextBox)},{Check_TD(benefitsTextBox)},{Check_TN(order_PaymentTextBox)}," +
                        $"{Check_TD(debt_AvansTextBox)},{Check_TD(penaltyTextBox)},{Check_TD(penalty_ProviderTextBox)},{Check_TD(state_DutiesTextBox)},{Check_TD(jud_CostTextBox)}," +
                        $"{Check_TD(recalculationsTextBox)},{Check_TD(sum_RecalculationsTextBox)},{Check_TD(installment_Payment_ValueTextBox)},{Check_T(installment_Payment_PercentTextBox)},{Check_TD(totalTextBox)})";

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
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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

        private void Services_AF_Load(object sender, EventArgs e)
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

        private void CB_Fill()
        {
            string[] yesno = { "Норматив", "Приборы учета", "Иное"};
                      

            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
        }
        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : e.Value.ToShortDateString();

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");


    }
}
