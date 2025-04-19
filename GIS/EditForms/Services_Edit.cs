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
    public partial class Services_Edit : Form
    {
        public int id;
        public Services_Edit()
        {
            InitializeComponent();
        }

        private void Services_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            Services_Load_Data();
        }

        private void Services_Load_Data()
        {
            string queryC1 = "SELECT ID FROM Payment_Document";

            string queryLoad = "SELECT ID_PD_Number, Services,Metod_Det_V_Servise, V_S_Count_Servise, Metod_Det_V_Resourses, V_S_Count_Resourses, Tarif, Accrued_Pilling_Period, " +
                "Total_Period, Increase_Coef, Value_Increase_Payment, Benefits, Order_Payment, Debt_Avans, Penalty, Penalty_Provider, State_Duties, " +
                "Jud_Cost, Recalculations, Sum_Recalculations, Installment_Payment_Value, Installment_Payment_Percent, Total " +
                "FROM Services_For_The_Payment_Period s " +
                "WHERE s.ID = @ID";

            using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
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
                    comboBox1.SelectedValue = dr.GetValue(0);
                    //comboBox2.SelectedIndex = 
                    if (dr.GetValue(2).ToString() == "")
                        comboBox3.SelectedItem = null;
                    else comboBox3.SelectedIndex = int.Parse(dr.GetValue(2).ToString());
                    v_S_Count_ServiseTextBox.Text = dr.GetValue(3).ToString();
                    if (dr.GetValue(4).ToString() == "")
                        comboBox4.SelectedItem = null;
                    else comboBox4.SelectedIndex = int.Parse(dr.GetValue(4).ToString());
                    v_S_Count_ResoursesTextBox.Text = dr.GetValue(5).ToString();
                    tarifTextBox.Text = dr.GetValue(6).ToString();
                    accrued_Pilling_PeriodTextBox.Text = dr.GetValue(7).ToString();
                    total_PeriodTextBox.Text = dr.GetValue(8).ToString();
                    increase_CoefTextBox.Text = dr.GetValue(9).ToString();
                    value_Increase_PaymentTextBox.Text = dr.GetValue(10).ToString();
                    benefitsTextBox.Text = dr.GetValue(11).ToString();
                    order_PaymentTextBox.Text = dr.GetValue(12).ToString();
                    debt_AvansTextBox.Text = dr.GetValue(13).ToString();
                    penaltyTextBox.Text = dr.GetValue(14).ToString();
                    penalty_ProviderTextBox.Text = dr.GetValue(15).ToString();
                    state_DutiesTextBox.Text = dr.GetValue(16).ToString();
                    jud_CostTextBox.Text = dr.GetValue(17).ToString();
                    recalculationsTextBox.Text = dr.GetValue(18).ToString();
                    sum_RecalculationsTextBox.Text = dr.GetValue(19).ToString();
                    installment_Payment_ValueTextBox.Text = dr.GetValue(20).ToString();
                    installment_Payment_PercentTextBox.Text = dr.GetValue(21).ToString();
                    totalTextBox.Text = dr.GetValue(22).ToString();
                }
                connection.Close();
            }
        }

        private void Save_Edit()
        {
            if(Chech_Save() == true)
            {
                try
                {
                    string querySave = $"UPDATE Services_For_The_Payment_Period SET " +
                        $"ID_PD_Number = {comboBox1.SelectedValue}, Services = null, Metod_Det_V_Servise = {Check_C(comboBox3)}, " +
                        $"V_S_Count_Servise = {Check_TD(v_S_Count_ServiseTextBox)}, Metod_Det_V_Resourses = {Check_C(comboBox4)}, " +
                        $"V_S_Count_Resourses = {Check_TD(v_S_Count_ResoursesTextBox)}, Tarif = {Check_TD(tarifTextBox)}, " +
                        $"Accrued_Pilling_Period = {Check_TD(accrued_Pilling_PeriodTextBox)}, Total_Period = {Check_TD(total_PeriodTextBox)}, " +
                        $"Increase_Coef = {Check_TD(increase_CoefTextBox)}, Value_Increase_Payment = {Check_T(value_Increase_PaymentTextBox)}, " +
                        $"Benefits = {Check_TD(benefitsTextBox)}, Order_Payment = {Check_TN(order_PaymentTextBox)}, Debt_Avans = {Check_TD(debt_AvansTextBox)}, " +
                        $"Penalty = {Check_TD(penaltyTextBox)}, Penalty_Provider = {Check_TD(penalty_ProviderTextBox)}, State_Duties = {Check_TD(state_DutiesTextBox)}, " +
                        $"Jud_Cost = {Check_TD(jud_CostTextBox)}, Recalculations = {Check_TD(recalculationsTextBox)}, Sum_Recalculations = {Check_TD(sum_RecalculationsTextBox)}, " +
                        $"Installment_Payment_Value = {Check_TD(installment_Payment_ValueTextBox)}, Installment_Payment_Percent = {Check_T(installment_Payment_PercentTextBox)}, Total = {Check_TD(totalTextBox)} " +
                        $"WHERE ID = {id}";

                    using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
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

        private bool Chech_Save()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Выберите значение для поля: Номер ПД");
                return false;
            }
            else return true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void CB_Fill()
        {
            string[] yesno = { "Норматив", "Приборы учета", "Иное" };


            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");


    }
}
