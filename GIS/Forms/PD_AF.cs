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
    public partial class PD_AF : Form
    {
        public int l_id;
        public string status, save_query;
        public PD_AF()
        {
            InitializeComponent();
        }

        private void PD_AF_Load(object sender, EventArgs e)
        {

        }

        public void Load_Data(DataTable dt)
        {
            CB_Fill();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "FIO";

            calculation_PeriodDateTimePicker.Checked = false;
            last_Payment_DateDateTimePicker.Checked = false;
        }

        private void payment_DocumentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохраниние данных в БД

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите значение для поля: Номер ЛС");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Тип ПД");
            else if (calculation_PeriodDateTimePicker.Checked == false)
                MessageBox.Show("Выберите значение для поля: Расчетный период");
            else
            {
                try
                {
                    /*string querySave = "INSERT INTO Payment_Document(ID_LS, Type_PD, Calculation_Period, Total_Area_LS, Living_Area, Heated_Area, Count_Livivng_People, " +
                        "Period_Sum, Cash_Paid, Last_Payment_Date, Social_Support, Total_Period_Debt, PR_Number, Total_Period, Total, Total_Legal_Expenses) " +
                        $"VALUES({comboBox1.SelectedValue}, {comboBox2.SelectedIndex}, CONVERT(VARCHAR,{GIS_Data.Check_D(calculation_PeriodDateTimePicker)},103)," +
                        $"{GIS_Data.Check_TD(total_Area_LSTextBox)}, {GIS_Data.Check_TD(living_AreaTextBox)}, {GIS_Data.Check_TD(heated_AreaTextBox)}, {GIS_Data.Check_T(count_Livivng_PeopleTextBox)}," +
                        $"{GIS_Data.Check_TD(period_SumTextBox)}, {GIS_Data.Check_TD(cash_PaidTextBox)}, CONVERT(VARCHAR,{GIS_Data.Check_D(last_Payment_DateDateTimePicker)},103), {GIS_Data.Check_T(social_SupportTextBox)}," +
                        $"{GIS_Data.Check_TD(total_Period_DebtTextBox)}, {GIS_Data.Check_TN(pR_NumberTextBox)}, {GIS_Data.Check_TD(total_PeriodTextBox)}, {GIS_Data.Check_TD(totalTextBox)}, {GIS_Data.Check_TD(total_Legal_ExpensesTextBox)})";
                    cash_PaidTextBox.Text = querySave;*/
                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query);

                        command.Parameters.AddWithValue("@ID_LS", comboBox1.SelectedValue);
                        command.Parameters.AddWithValue("@Type_PD", comboBox2.SelectedIndex);
                        command.Parameters.AddWithValue("@Calculation_Period", GIS_Data.Check_D(calculation_PeriodDateTimePicker));
                        command.Parameters.AddWithValue("@Total_Area_LS", GIS_Data.Check_TD(total_Area_LSTextBox));
                        command.Parameters.AddWithValue("@Living_Area", GIS_Data.Check_TD(living_AreaTextBox));
                        command.Parameters.AddWithValue("@Heated_Area", GIS_Data.Check_TD(heated_AreaTextBox));
                        command.Parameters.AddWithValue("@Count_Livivng_People", GIS_Data.Check_TD(count_Livivng_PeopleTextBox));
                        command.Parameters.AddWithValue("@Period_Sum", GIS_Data.Check_TD(period_SumTextBox));
                        command.Parameters.AddWithValue("@Cash_Paid", GIS_Data.Check_TD(cash_PaidTextBox));
                        command.Parameters.AddWithValue("@Last_Payment_Date", GIS_Data.Check_D(last_Payment_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Social_Support", GIS_Data.Check_TD(social_SupportTextBox));
                        command.Parameters.AddWithValue("@Total_Period_Debt", GIS_Data.Check_TD(period_SumTextBox));
                        command.Parameters.AddWithValue("@PR_Number", GIS_Data.Check_T(pR_NumberTextBox));
                        command.Parameters.AddWithValue("@Total_Period", GIS_Data.Check_TD(total_PeriodTextBox));
                        command.Parameters.AddWithValue("@Total", GIS_Data.Check_TD(totalTextBox));
                        command.Parameters.AddWithValue("@Total_Legal_Expenses", GIS_Data.Check_TD(total_Legal_ExpensesTextBox));
                        command.Parameters.AddWithValue("@Full_GIS_Total", GIS_Data.Check_TD(full_GIS_TotalTextBox));

                        command.Connection = connection;
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

        public void Load_Data_Edit(DataTable dt, int id_pd, string query_load)
        {

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "FIO";

            CB_Fill();

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query_load, connection);

                command.Parameters.AddWithValue("@ID", id_pd);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.SelectedValue = dr.GetValue(0);
                    comboBox2.SelectedIndex = int.Parse(dr.GetValue(1).ToString());
                    calculation_PeriodDateTimePicker.Value = DateTime.Parse(dr.GetValue(2).ToString());
                    total_Area_LSTextBox.Text = dr.GetValue(3).ToString();
                    living_AreaTextBox.Text = dr.GetValue(4).ToString();
                    heated_AreaTextBox.Text = dr.GetValue(5).ToString();
                    count_Livivng_PeopleTextBox.Text = dr.GetValue(6).ToString();
                    period_SumTextBox.Text = dr.GetValue(7).ToString();
                    cash_PaidTextBox.Text = dr.GetValue(8).ToString();
                    if (dr.GetValue(9).ToString() == "") last_Payment_DateDateTimePicker.Checked = false;
                    else last_Payment_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(9).ToString());
                    social_SupportTextBox.Text = dr.GetValue(10).ToString();
                    total_Period_DebtTextBox.Text = dr.GetValue(11).ToString();
                    pR_NumberTextBox.Text = dr.GetValue(12).ToString();
                    total_PeriodTextBox.Text = dr.GetValue(13).ToString();
                    totalTextBox.Text = dr.GetValue(14).ToString();
                    total_Legal_ExpensesTextBox.Text = dr.GetValue(15).ToString();
                    full_GIS_TotalTextBox.Text = dr.GetValue(16).ToString();

                    calculation_PeriodDateTimePicker.Checked = true;
                    last_Payment_DateDateTimePicker.Checked = true;
                }
                connection.Close();
            }
        }

        private void CB_Fill()
        {
            string[] typePD = { "Текущий", "Долговой" };

            comboBox2.Items.AddRange(typePD);
        }
    }
}
