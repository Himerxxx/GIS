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
using GIS.EditForms;
using GIS.Forms;

namespace GIS.SearchForms
{
    public partial class PD_SearchForm : Form
    {
        public int id;
        int s_id, pen_id;
        public PD_SearchForm()
        {
            InitializeComponent();
        }

        private void PD_SearchForm_Load(object sender, EventArgs e)
        {
            button9.Text = "Добавить";
            button9.Location = new Point(13, 54);
            button9.Size = new Size(199, 35);
            button9.Font = new Font("Times New Roman", 12);
            button9.BackColor = Color.FromName("InactiveCaption");

            button1.Text = "Изменить";
            button1.Location = new Point(13, 99);
            button1.Size = new Size(199, 35);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");

            button2.Text = "Удалить";
            button2.Location = new Point(13, 144);
            button2.Size = new Size(199, 35);
            button2.Font = new Font("Times New Roman", 12);
            button2.BackColor = Color.FromName("InactiveCaption");

            button3.Location = new Point(187, 218);
            button3.BackColor = Color.FromName("Menu");
            button3.Size = new Size(25, 25);
            button3.Text = "";

            button4.Text = "Сбросить";
            button4.Location = new Point(13, 243);
            button4.Size = new Size(199, 35);
            button4.Font = new Font("Times New Roman", 12);
            button4.BackColor = Color.FromName("InactiveCaption");

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(14, 218);
            //=======================================================
            button10.Text = "Добавить";
            button10.Location = new Point(13, 355);
            button10.Size = new Size(199, 35);
            button10.Font = new Font("Times New Roman", 12);
            button10.BackColor = Color.FromName("InactiveCaption");

            button5.Text = "Изменить";
            button5.Location = new Point(13, 400);
            button5.Size = new Size(199, 35);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");

            button6.Text = "Удалить";
            button6.Location = new Point(13, 445);
            button6.Size = new Size(199, 35);
            button6.Font = new Font("Times New Roman", 12);
            button6.BackColor = Color.FromName("InactiveCaption");

            button7.Location = new Point(187, 519);
            button7.BackColor = Color.FromName("Menu");
            button7.Size = new Size(25, 25);
            button7.Text = "";

            button8.Text = "Сбросить";
            button8.Location = new Point(13, 544);
            button8.Size = new Size(199, 35);
            button8.Font = new Font("Times New Roman", 12);
            button8.BackColor = Color.FromName("InactiveCaption");

            textBox2.Multiline = true;
            textBox2.Size = new Size(170, 25);
            textBox2.Location = new Point(14, 519);
            //=======================================================            

            Services_PD_DG_Fill();
            Penalties_DG_Fill();

            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
        }

        private void Services_PD_DG_Fill()
        {
            string query1 = "SELECT s.ID, pd.ID AS 'Номер ПД', s.Services AS 'Услуга', s.Metod_Det_V_Servise AS 'Способ определения объемов КУ', " +
                "s.V_S_Count_Servise AS 'Объем/ площадь/ количество', s.Metod_Det_V_Resourses AS 'Способ определения объемов КУ', s.V_S_Count_Resourses AS 'Объем/ площадь/ количество', " +
                "s.Tarif AS 'Тариф', s.Accrued_Pilling_Period AS 'Начислено за расчетный период', s.Total_Period AS 'К оплате за расчетный период', s.Increase_Coef AS 'Размер повышающего коэффициента', " +
                "s.Value_Increase_Payment AS 'Размер превышения платы', s.Benefits AS 'Льготы/ субсидии', s.Order_Payment AS 'Порядок расчетов', s.Debt_Avans AS 'Задолженность за предыдущие периоды / Аванс на начало расчетного периода', " +
                "s.Penalty AS 'Неустойка', s.Penalty_Provider AS 'Штраф исполнителя работ', s.State_Duties AS 'Государственные пошлины', s.Jud_Cost AS 'Судебные издержки', s.Recalculations AS 'Основания перерасчетов', " +
                "s.Sum_Recalculations AS 'Сумма перерасчетов', s.Installment_Payment_Value AS 'Плата за рассрочку', s.Installment_Payment_Percent AS 'Процент за рассрочку', s.Total AS 'ИТОГО К ОПЛАТЕ' " +
                "FROM Services_For_The_Payment_Period s " +
                "JOIN Payment_Document pd ON pd.ID = s.ID_PD_Number " +
                "WHERE pd.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@ID", id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
        }

        private void Penalties_DG_Fill()
        {
            string query1 = "SELECT p.ID, pd.ID AS 'Номер ПД', p.Type_Accrual AS 'Вид начисления', p.Reason_Accrual AS 'Основания начислений', p.Sum AS 'Сумма' " +
                "FROM Penalties_And_Court_Costs p " +
                "JOIN Payment_Document pd ON pd.ID = p.ID_PD_Number " +
                "WHERE pd.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@ID", id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                this.dataGridView2.DataSource = dt;
            }
        }

        private void PD_SearchForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Color.Black), 0, 300, 1200, 300);            
            g.Dispose();
        }

        private void Search(TextBox textBox, DataGridView dg)
        {
            string searchValue = textBox.Text;

            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 0; j < dg.ColumnCount; j++)
                {
                    dg[j, i].Style.BackColor = Color.White;
                    dg[j, i].Style.ForeColor = Color.Black;
                }
            }
            List<int> index = new List<int>();
            int count = 0;

            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 1; j < dg.ColumnCount; j++)
                {
                    if (dg[j, i].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        dg[j, i].Style.BackColor = Color.AliceBlue;
                        dg[j, i].Style.ForeColor = Color.Blue;

                        count++;
                    }
                }
                if (count == 0) index.Add(i);
                count = 0;
            }
            index.Reverse();
            if (index.Count != 0)
            {
                foreach (var i in index)
                {
                    dg.Rows.RemoveAt(i);
                }
            }
        }

        private void ServicesEdit_Click(object sender, EventArgs e)
        {
            if (s_id > 0)
            {
                var form = new Services_Edit();
                form.id = s_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {                   
                    Services_PD_DG_Fill();
                    s_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE Services_For_The_Payment_Period WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", s_id);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Запись успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Services_PD_DG_Fill();
                s_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search(textBox1,dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search(textBox2, dataGridView2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                s_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                s_id = -1;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pen_id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                pen_id = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Services_PD_DG_Fill();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Penalties_DG_Fill();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pen_id > 0)
            {
                var form = new Penalties_Edit();
                form.id = pen_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {                  
                    Penalties_DG_Fill();
                    pen_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pen_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE Penalties_And_Court_Costs WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", pen_id);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Запись успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Penalties_DG_Fill();
                pen_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox1,dataGridView1);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                Services_PD_DG_Fill();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox2, dataGridView2);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                Penalties_DG_Fill();
                e.SuppressKeyPress = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new Services_AF();
            form.pd_id = id;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                Services_PD_DG_Fill();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var form = new Penalties_AF();
            form.pd_id = id;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                Penalties_DG_Fill();
        }
    }
}
