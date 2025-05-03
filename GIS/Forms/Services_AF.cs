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
        public string status, save_query;
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
                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query, connection);

                        command.Parameters.AddWithValue("@ID_PD_Number", comboBox1.SelectedValue);
                        command.Parameters.AddWithValue("@Services", GIS_Data.Check_C(comboBox2));
                        command.Parameters.AddWithValue("@Metod_Det_V_Servise", GIS_Data.Check_C(comboBox3));
                        command.Parameters.AddWithValue("@V_S_Count_Servise", GIS_Data.Check_TD(v_S_Count_ServiseTextBox));
                        command.Parameters.AddWithValue("@Metod_Det_V_Resourses", GIS_Data.Check_C(comboBox4));
                        command.Parameters.AddWithValue("@V_S_Count_Resourses", GIS_Data.Check_TD(v_S_Count_ResoursesTextBox));
                        command.Parameters.AddWithValue("@Tarif", GIS_Data.Check_TD(tarifTextBox));
                        command.Parameters.AddWithValue("@Accrued_Pilling_Period", GIS_Data.Check_TD(accrued_Pilling_PeriodTextBox));
                        command.Parameters.AddWithValue("@Total_Period", GIS_Data.Check_TD(total_PeriodTextBox));
                        command.Parameters.AddWithValue("@Increase_Coef", GIS_Data.Check_TD(increase_CoefTextBox));
                        command.Parameters.AddWithValue("@Value_Increase_Payment", GIS_Data.Check_T(value_Increase_PaymentTextBox));
                        command.Parameters.AddWithValue("@Benefits", GIS_Data.Check_TD(benefitsTextBox));
                        command.Parameters.AddWithValue("@Order_Payment", GIS_Data.Check_TN(order_PaymentTextBox));
                        command.Parameters.AddWithValue("@Debt_Avans", GIS_Data.Check_TD(debt_AvansTextBox));
                        command.Parameters.AddWithValue("@Penalty", GIS_Data.Check_TD(penaltyTextBox));
                        command.Parameters.AddWithValue("@Penalty_Provider", GIS_Data.Check_TD(penalty_ProviderTextBox));
                        command.Parameters.AddWithValue("@State_Duties", GIS_Data.Check_TD(state_DutiesTextBox));
                        command.Parameters.AddWithValue("@Jud_Cost", GIS_Data.Check_TD(jud_CostTextBox));
                        command.Parameters.AddWithValue("@Recalculations", GIS_Data.Check_TD(recalculationsTextBox));
                        command.Parameters.AddWithValue("@Sum_Recalculations", GIS_Data.Check_TD(sum_RecalculationsTextBox));
                        command.Parameters.AddWithValue("@Installment_Payment_Value", GIS_Data.Check_TD(installment_Payment_ValueTextBox));
                        command.Parameters.AddWithValue("@Installment_Payment_Percent", GIS_Data.Check_T(installment_Payment_PercentTextBox));
                        command.Parameters.AddWithValue("@Total", GIS_Data.Check_TD(totalTextBox));

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

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_load_edit, connection);
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

        private void Services_AF_Load(object sender, EventArgs e)
        {
 
        }

        private void CB_Fill()
        {
            string[] yesno = { "Норматив", "Приборы учета", "Иное" };

            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
        }
    }
}
