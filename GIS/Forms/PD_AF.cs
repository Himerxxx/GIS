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
        public PD_AF()
        {
            InitializeComponent();
        }

        private void PD_AF_Load(object sender, EventArgs e)
        {
            if (l_id > 0)
            {
                Load_Data();
            }
            else
            {
                this.view_Address_Premises_For_PDTableAdapter.Fill(this.gISDataSet.View_Address_Premises_For_PD);

                comboBox1.SelectedItem = null;
            }


            comboBox2.SelectedItem = null;

            calculation_PeriodDateTimePicker.Checked = false;
            last_Payment_DateDateTimePicker.Checked = false;

            CB_Fill();

        }

        private void Load_Data()
        {
            string query = "SELECT l.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM LS l " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "WHERE l.ID = @l_id";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@l_id", l_id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "FIO";
            }
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
                    string querySave = "INSERT INTO Payment_Document(l_idS, Type_PD, Calculation_Period, Total_Area_LS, Living_Area, Heated_Area, Count_Livivng_People, " +
                        "Period_Sum, Cash_Paid, Last_Payment_Date, Social_Support, Total_Period_Debt, PR_Number, Total_Period, Total, Total_Legal_Expenses) " +
                        $"VALUES({comboBox1.SelectedValue}, {comboBox2.SelectedIndex}, CONVERT(VARCHAR,{Check_D(calculation_PeriodDateTimePicker)},103)," +
                        $"{Check_TD(total_Area_LSTextBox)}, {Check_TD(living_AreaTextBox)}, {Check_TD(heated_AreaTextBox)}, {Check_T(count_Livivng_PeopleTextBox)}," +
                        $"{Check_TD(period_SumTextBox)}, {Check_TD(cash_PaidTextBox)}, CONVERT(VARCHAR,{Check_D(last_Payment_DateDateTimePicker)},103), {Check_T(social_SupportTextBox)}," +
                        $"{Check_TD(total_Period_DebtTextBox)}, {Check_TN(pR_NumberTextBox)}, {Check_TD(total_PeriodTextBox)}, {Check_TD(totalTextBox)}, {Check_TD(total_Legal_ExpensesTextBox)})";

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querySave);
                        command.Connection = connection;
                        command.ExecuteNonQuery();
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



        private void CB_Fill()
        {
            string[] typePD = { "Текущий", "Долговой" };

            comboBox2.Items.AddRange(typePD);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e)
        {
            if (e.Checked == false) return "null";
            else
            {
                string date = e.Value.ToShortDateString().Replace(".", "");
                return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);
            }
        }

    }
}
