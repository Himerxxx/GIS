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

namespace GIS.UC
{
    public partial class Services_PD_UC : UserControl
    {
        string query_load = "SELECT s.ID, SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),5,4) + SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),3,2) + SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),1,2)" +
            " + '-' + CONVERT(NVARCHAR,pd.ID) AS 'Номер ПД', s.Services AS 'Услуга', s.Metod_Det_V_Servise AS 'Способ определения объемов КУ', " +
           "s.V_S_Count_Servise AS 'Объем/ площадь/ количество', s.Metod_Det_V_Resourses AS 'Способ определения объемов КУ', s.V_S_Count_Resourses AS 'Объем/ площадь/ количество', " +
           "s.Tarif AS 'Тариф', s.Accrued_Pilling_Period AS 'Начислено за расчетный период', s.Total_Period AS 'К оплате за расчетный период', s.Increase_Coef AS 'Размер повышающего коэффициента', " +
           "s.Value_Increase_Payment AS 'Размер превышения платы', s.Benefits AS 'Льготы/ субсидии', s.Order_Payment AS 'Порядок расчетов', s.Debt_Avans AS 'Задолженность за предыдущие периоды / Аванс на начало расчетного периода', " +
           "s.Penalty AS 'Неустойка', s.Penalty_Provider AS 'Штраф исполнителя работ', s.State_Duties AS 'Государственные пошлины', s.Jud_Cost AS 'Судебные издержки', s.Recalculations AS 'Основания перерасчетов', " +
           "s.Sum_Recalculations AS 'Сумма перерасчетов', s.Installment_Payment_Value AS 'Плата за рассрочку', s.Installment_Payment_Percent AS 'Процент за рассрочку', s.Total AS 'ИТОГО К ОПЛАТЕ' " +
           "FROM Services_For_The_Payment_Period s " +
           "JOIN Payment_Document pd ON pd.ID = s.ID_PD_Number ";

        int id_services;
        string pd_name;
        public Services_PD_UC()
        {
            InitializeComponent();
        }

        private void Services_PD_UC_Load(object sender, EventArgs e)
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

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            /*var form = new Services_AF();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);*/

            string query_load_CB = "SELECT pd.ID AS 'ID', SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),5,4) + SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),3,2) + SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),1,2) + '-' + CONVERT(NVARCHAR,s.ID_PD_Number) AS 'PD_Key' " +
                "FROM Services_For_The_Payment_Period s " +
                "JOIN Payment_Document pd ON pd.ID = s.ID_PD_Number " +
                "WHERE s.ID = @ID";

            var services = new Services_AF() { Text = $"Добавление новых услуг за период. {pd_name}" };
            services.Load_Data(Add_Func(query_load_CB));
            services.save_query = "INSERT INTO Services_For_The_Payment_Period(ID_PD_Number, Services, Metod_Det_V_Servise, V_S_Count_Servise, Metod_Det_V_Resourses," +
                        "V_S_Count_Resourses, Tarif, Accrued_Pilling_Period, Total_Period, Increase_Coef, Value_Increase_Payment, Benefits, Order_Payment, Debt_Avans," +
                        "Penalty, Penalty_Provider, State_Duties, Jud_Cost, Recalculations, Sum_Recalculations, Installment_Payment_Value, Installment_Payment_Percent, Total) " +
                        $"VALUES(@ID_PD_Number, @Services, @Metod_Det_V_Servise, @V_S_Count_Servise, @Metod_Det_V_Resourses," +
                        $"@V_S_Count_Resourses,@Tarif,@Accrued_Pilling_Period,@Total_Period," +
                        $"@Increase_Coef,@Value_Increase_Payment,@Benefits,Order_Payment," +
                        $"@Debt_Avans,@Penalty,@Penalty_Provider,@State_Duties,@Jud_Cost," +
                        $"@Recalculations,@Sum_Recalculations,@Installment_Payment_Value,@Installment_Payment_Percent,@Total)"; 
            services.status = "добавлена";
            services.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = services.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private DataTable Add_Func(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id_services);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_services = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                pd_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                id_services = -1;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Services_For_The_Payment_Period WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(id_services, queryDelete, false, $"Удалить запись услуг за период: {pd_name}?") == true) GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT pd.ID AS 'ID', SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),5,4) + SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),3,2) + SUBSTRING(REPLACE(CONVERT(NVARCHAR,pd.Calculation_Period,103), '/', ''),1,2) + '-' + CONVERT(NVARCHAR,s.ID_PD_Number) AS 'PD_Key' " +
                "FROM Services_For_The_Payment_Period s " +
                "JOIN Payment_Document pd ON pd.ID = s.ID_PD_Number " +
                "WHERE s.ID = @ID";

            string query_load_edit = "SELECT ID_PD_Number, Services,Metod_Det_V_Servise, V_S_Count_Servise, Metod_Det_V_Resourses, V_S_Count_Resourses, Tarif, Accrued_Pilling_Period, " +
                "Total_Period, Increase_Coef, Value_Increase_Payment, Benefits, Order_Payment, Debt_Avans, Penalty, Penalty_Provider, State_Duties, " +
                "Jud_Cost, Recalculations, Sum_Recalculations, Installment_Payment_Value, Installment_Payment_Percent, Total " +
                "FROM Services_For_The_Payment_Period s " +
                $"WHERE s.ID = {id_services}";

            if (id_services > -1)
            {
                var services = new Services_AF() { Text = $"Изменение записи услуг за период. {pd_name}" };
                services.Load_Data_Edit(Add_Func(query_load_CB), query_load_edit, id_services);
                services.save_query = $"UPDATE Services_For_The_Payment_Period SET " +
                        $"ID_PD_Number = @ID_PD_Number, Services = @Services, Metod_Det_V_Servise = @Metod_Det_V_Servise, " +
                        $"V_S_Count_Servise = @V_S_Count_Servise, Metod_Det_V_Resourses = @Metod_Det_V_Resourses, " +
                        $"V_S_Count_Resourses = @V_S_Count_Resourses, Tarif = @Tarif, " +
                        $"Accrued_Pilling_Period = @Accrued_Pilling_Period, Total_Period = @Total_Period, " +
                        $"Increase_Coef = @Increase_Coef, Value_Increase_Payment = @Value_Increase_Payment, " +
                        $"Benefits = @Benefits, Order_Payment = @Order_Payment, Debt_Avans = @Debt_Avans, " +
                        $"Penalty = @Penalty, Penalty_Provider = @Penalty_Provider, State_Duties = @State_Duties, " +
                        $"Jud_Cost = @Jud_Cost, Recalculations = @Recalculations, Sum_Recalculations = @Sum_Recalculations, " +
                        $"Installment_Payment_Value = @Installment_Payment_Value, Installment_Payment_Percent = @Installment_Payment_Percent, Total = @Total " +
                        $"WHERE ID = {id_services}";
                services.status = "изменена";
                services.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Text = "Изменить данные";
                DialogResult result = services.ShowDialog();
                if (result == DialogResult.Cancel)
                    GIS_Data.SQLFill(query_load, dataGridView1);
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
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
    }
}
