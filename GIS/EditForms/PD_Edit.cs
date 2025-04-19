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
    public partial class PD_Edit : Form
    {
        public int id;
        public PD_Edit()
        {
            InitializeComponent();
        }

        private void PD_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();            

            this.view_Address_Premises_For_PDTableAdapter.Fill(this.gISDataSet.View_Address_Premises_For_PD);

            PD_Load_Data();
            //comboBox1.SelectedItem = null;
        }       

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void Save_Edit()
        {
            if(Check_Save() == true)
            {
                try
                {
                    string querySave = $"UPDATE Payment_Document SET ID_LS = {comboBox1.SelectedValue}, Type_PD = {comboBox2.SelectedIndex}," +
                        $"Calculation_Period = CONVERT(VARCHAR,{Check_D(calculation_PeriodDateTimePicker)},103), Total_Area_LS = {Check_TD(total_Area_LSTextBox)}, " +
                        $"Living_Area = {Check_TD(living_AreaTextBox)}, Heated_Area = {Check_TD(heated_AreaTextBox)}," +
                        $"Count_Livivng_People = {Check_T(count_Livivng_PeopleTextBox)}, Period_Sum = {Check_TD(period_SumTextBox)}, " +
                        $"Cash_Paid = {Check_TD(cash_PaidTextBox)}, Last_Payment_Date = CONVERT(VARCHAR,{Check_D(last_Payment_DateDateTimePicker)},103)," +
                        $"Social_Support = {Check_TD(social_SupportTextBox)}," +
                        $"Total_Period_Debt = {Check_TD(total_Period_DebtTextBox)}, PR_Number = {Check_TN(pR_NumberTextBox)}, Total = {Check_TD(totalTextBox)}, " +
                        $"Total_Legal_Expenses = {Check_TD(total_Legal_ExpensesTextBox)}, Full_GIS_Total = {Check_TD(full_GIS_TotalTextBox)} " +
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
                MessageBox.Show("Выберите значение для поля: Номер ЛС");
                return false;
            }                
            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Тип ПД");
                return false;
            }                
            else if (calculation_PeriodDateTimePicker.Checked == false)
            {
                MessageBox.Show("Выберите значение для поля: Расчетный период");
                return false;
            }
                
            else return true;
        }

        private void PD_Load_Data()
        {         

            string queryLoad = "SELECT ID_LS, Type_PD, Calculation_Period, Total_Area_LS, Living_Area, Heated_Area," +
                "Count_Livivng_People, Period_Sum, Cash_Paid, Last_Payment_Date, Social_Support, " +
                "Total_Period_Debt, PR_Number, Total_Period, Total, Total_Legal_Expenses, Full_GIS_Total " +
                "FROM Payment_Document p " +
                "WHERE p.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

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
                }
                connection.Close();
            }
        }

        private void CB_Fill()
        {
            string[] typePD = { "Текущий", "Долговой" };

            comboBox2.Items.AddRange(typePD);
        }

        private string Check_D(DateTimePicker e)
        {
            if (e.Checked == false) return "null";
            else
            {
                string date = e.Value.ToShortDateString().Replace(".", "");
                return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);
            }
        }
        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;
        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"'N{e.Text}'";
        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",",".");
    }
}
