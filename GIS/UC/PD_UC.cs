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
using GIS.Forms;
using GIS.EditForms;
using GIS.SearchForms;

namespace GIS.UC
{
    public partial class PD_UC : UserControl
    {
        string query_load = "SELECT pd.ID, pd.ID_LS, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS 'ФИО владельца ЛС', pd.Type_PD AS 'Тип ПД', " +
           "pd.Calculation_Period AS 'Расчетный период', " +
           "pd.Period_Sum AS 'Сумма к оплате за расчетный период', pd.Cash_Paid AS 'Оплачено денежных средств', " +
           "pd.Last_Payment_Date AS 'Дата последней поступившей оплаты', pd.Social_Support AS 'Субсидии компенсации и иные меры соц. поддержки граждан', " +
           "pd.Total_Period_Debt AS 'Итого к оплате за расчетный период c учетом задолженности/ переплаты', " +
           "pd.PR_Number AS 'Номер платежного реквизита по ПД', pd.Total_Period AS 'Итого к оплате за расчетный период', " +
           "pd.Total AS 'ИТОГО К ОПЛАТЕ', pd.Total_Legal_Expenses AS 'Итого к оплате по неустойкам и судебным расходам', pd.Full_GIS_Total AS 'РАССЧИТАНО ГИС ЖКХ' " +
           "FROM Payment_Document pd " +
           "JOIN LS l ON l.ID = pd.ID_LS " +
           "JOIN Owner_LS o ON o.ID = l.ID_Owner ";
        int id_pd, id_ls;
        string date, fio;
        public PD_UC()
        {
            InitializeComponent();
        }

        private void PD_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query_load, dataGridView1);

            splitContainer1.Size = new Size(1233, 394);
            
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.SplitterDistance = 229;

            button1.Location = new Point(15, 53);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");
            button1.Size = new Size(199, 35);

            button2.Location = new Point(15, 98);
            button2.Font = new Font("Times New Roman", 12);
            button2.BackColor = Color.FromName("InactiveCaption");
            button2.Size = new Size(199, 35);

            button3.Location = new Point(15, 143);
            button3.Font = new Font("Times New Roman", 12);
            button3.BackColor = Color.FromName("InactiveCaption");
            button3.Size = new Size(199, 35);

            button4.Location = new Point(189, 311);
            button4.BackColor = Color.FromName("Menu");
            button4.Size = new Size(25, 25);

            button5.Location = new Point(15, 337);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");
            button5.Size = new Size(199, 35);

            button6.Location = new Point(15, 188);
            button6.Font = new Font("Times New Roman", 12);
            button6.BackColor = Color.FromName("InactiveCaption");
            button6.Size = new Size(199, 35);

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }



        private void Add_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT l.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM LS l " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "WHERE l.ID = @ID";

            var pd = new PD_AF() { Text = $"Добавление нового платежного документа. {fio}" };
            pd.Load_Data(Add_Func(query_load_CB));
            pd.save_query = "INSERT INTO Payment_Document(ID_LS, Type_PD, Calculation_Period, Total_Area_LS, Living_Area, Heated_Area, Count_Livivng_People, " +
                        "Period_Sum, Cash_Paid, Last_Payment_Date, Social_Support, Total_Period_Debt, PR_Number, Total_Period, Total, Total_Legal_Expenses, Full_GIS_Total) " +
                        $"VALUES(@ID_LS, @Type_PD, CONVERT(VARCHAR,@Calculation_Period,103)," +
                        $"@Total_Area_LS, @Living_Area, @Heated_Area, @Count_Livivng_People," +
                        $"@Period_Sum, @Cash_Paid, CONVERT(VARCHAR,@Last_Payment_Date,103), @Social_Support," +
                        $"@Total_Period_Debt, @PR_Number, @Total_Period, @Total, @Total_Legal_Expenses, @Full_GIS_Total)";
            pd.status = "добавлена";
            pd.payment_DocumentBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private DataTable Add_Func(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id_ls);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_pd = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                id_ls = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                date = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                fio = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {
                id_pd = -1;
                id_ls = -1;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (id_pd > -1)
            {
                string query_load_CB = "SELECT l.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM LS l " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "WHERE l.ID = @ID";

                string query_load_edit = "SELECT ID_LS, Type_PD, Calculation_Period, Total_Area_LS, Living_Area, Heated_Area," +
                "Count_Livivng_People, Period_Sum, Cash_Paid, Last_Payment_Date, Social_Support, " +
                "Total_Period_Debt, PR_Number, Total_Period, Total, Total_Legal_Expenses, Full_GIS_Total " +
                "FROM Payment_Document p " +
                "WHERE p.ID = @ID";

                var pd = new PD_AF() { Text = $"Изменение данных платежного документа. {fio} за {date.Replace(" 0:00:00", "")}" };
                pd.Load_Data_Edit(Add_Func(query_load_CB), id_pd, query_load_edit);
                pd.save_query = $"UPDATE Payment_Document SET ID_LS = @ID_LS, Type_PD = @Type_PD," +
                        $"Calculation_Period = CONVERT(VARCHAR,@Calculation_Period,103), Total_Area_LS = @Total_Area_LS, " +
                        $"Living_Area = @Living_Area, Heated_Area = @Heated_Area," +
                        $"Count_Livivng_People = @Count_Livivng_People, Period_Sum = @Period_Sum, " +
                        $"Cash_Paid = @Cash_Paid, Last_Payment_Date = CONVERT(VARCHAR,@Last_Payment_Date,103)," +
                        $"Social_Support = @Social_Support," +
                        $"Total_Period_Debt = @Total_Period_Debt, PR_Number = @PR_Number, Total = @Total, " +
                        $"Total_Legal_Expenses = @Total_Legal_Expenses, Full_GIS_Total = @Full_GIS_Total " +
                        $"WHERE ID = {id_pd}";
                pd.status = "изменена";
                pd.payment_DocumentBindingNavigatorSaveItem.Text = "Изменить данные";
                DialogResult result = pd.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query_load, dataGridView1);
                    id_pd = -1;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Payment_Document WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(id_pd, queryDelete, false, $"Удалить данные платежного документа: {fio} за {date.Replace(" 0:00:00", "")}?") == true) GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query_load, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (id_pd > 0)
            {
                var form = new PD_SearchForm() { Text = $"ПД {fio} за {date.Replace(" 0:00:00","")}" };
                form.id = id_pd;
                form.Show();
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
