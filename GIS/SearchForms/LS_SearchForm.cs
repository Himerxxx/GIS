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
    public partial class LS_SearchForm : Form
    {
        public int l_id, p_id;
        int ipy_id, owner_id, pd_id;
        string fio, date;
        public LS_SearchForm()
        {
            InitializeComponent();
        }

        private void LS_SearchForm_Load(object sender, EventArgs e)
        {

            dataGridView4.Size = new Size(918, 223);
            dataGridView4.Location = new Point(218, 656);

            label4.Text = "Платежные документы";
            label4.Location = new Point(610,630);

            button5.Text = "Добавить";
            button5.Location = new Point(13, 54);
            button5.Size = new Size(199, 35);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");

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
            button6.Text = "Добавить";
            button6.Location = new Point(13, 355);
            button6.Size = new Size(199, 35);
            button6.Font = new Font("Times New Roman", 12);
            button6.BackColor = Color.FromName("InactiveCaption");

            button9.Text = "Изменить";
            button9.Location = new Point(13, 400);
            button9.Size = new Size(199, 35);
            button9.Font = new Font("Times New Roman", 12);
            button9.BackColor = Color.FromName("InactiveCaption");

            button10.Text = "Удалить";
            button10.Location = new Point(13, 445);
            button10.Size = new Size(199, 35);
            button10.Font = new Font("Times New Roman", 12);
            button10.BackColor = Color.FromName("InactiveCaption");

            button11.Location = new Point(187, 519);
            button11.BackColor = Color.FromName("Menu");
            button11.Size = new Size(25, 25);
            button11.Text = "";

            button12.Text = "Сбросить";
            button12.Location = new Point(13, 544);
            button12.Size = new Size(199, 35);
            button12.Font = new Font("Times New Roman", 12);
            button12.BackColor = Color.FromName("InactiveCaption");

            textBox3.Multiline = true;
            textBox3.Size = new Size(170, 25);
            textBox3.Location = new Point(14, 519);
            //==================================================
            button7.Text = "Добавить";
            button7.Location = new Point(13, 656);
            button7.Size = new Size(199, 35);
            button7.Font = new Font("Times New Roman", 12);
            button7.BackColor = Color.FromName("InactiveCaption");

            button13.Text = "Изменить";
            button13.Location = new Point(13, 696);
            button13.Size = new Size(199, 35);
            button13.Font = new Font("Times New Roman", 12);
            button13.BackColor = Color.FromName("InactiveCaption");

            button14.Text = "Удалить";
            button14.Location = new Point(13, 736);
            button14.Size = new Size(199, 35);
            button14.Font = new Font("Times New Roman", 12);
            button14.BackColor = Color.FromName("InactiveCaption");

            button16.Text = "Перейти к ПД";
            button16.Location = new Point(13, 776);
            button16.Size = new Size(199, 35);
            button16.Font = new Font("Times New Roman", 12);
            button16.BackColor = Color.FromName("InactiveCaption");

            button15.Location = new Point(187, 820);
            button15.BackColor = Color.FromName("Menu");
            button15.Size = new Size(25, 25);
            button15.Text = "";

            button17.Text = "Сбросить";
            button17.Location = new Point(13, 845);
            button17.Size = new Size(199, 35);
            button17.Font = new Font("Times New Roman", 12);
            button17.BackColor = Color.FromName("InactiveCaption");

            textBox4.Multiline = true;
            textBox4.Size = new Size(170, 25);
            textBox4.Location = new Point(14, 820);
            //==================================================
            Owner_DG_Fill();           
            IPY_DG_Fill();
            PD_DG_Fill();

            dataGridView1.Columns[0].Visible = false;
            dataGridView3.Columns[0].Visible = false;
            dataGridView4.Columns[0].Visible = false;            
        }

        private void Owner_DG_Fill()
        {
            string query1 = "SELECT o.ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS 'ФИО', a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Адрес помещения',o.SNILS AS 'СНИЛС', " +
                "o.Passport_Type AS 'Документ удостоверяющий личность', o.Passport_Series + ' ' + o.Passport_Number AS 'Серия номер', o.Passport_Date AS 'Дата получения ДУЛ', o.OGRN AS 'ОГРН', o.NZA AS 'НЗА', o.KPP AS 'КПП' " +
                "FROM LS l " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "JOIN Premises_LS_Relations pl ON pl.ID_LS = l.ID " +
                "JOIN MKD_Premises p ON p.ID = pl.ID_Premises " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE pl.ID_Premises = @secID " +
                "ORDER BY SecondName";

            try
            {
                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("@secID", p_id);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void IPY_DG_Fill()
        {
            string query1 = "SELECT py.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес помещения', " +
                "o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS 'ФИО владельца ЛС', py.Serial_Number AS 'Серийный номер ПУ', py.Type_PY AS 'Вид ПУ', py.Mark_PY AS 'Марка ПУ', " +
                "py.Model_PY AS 'Модель ПУ', py.Is_Distance_Check AS 'Возможность дистанционного снятия показаний', py.Distance_Check_Info AS 'Наименование системы дистанционного снятия показаний', " +
                "py.Is_Many_PY_Used AS 'Объем ресурса(ов) определяется с помощью нескольких приборов учета', py.Place_Location_PY AS 'Место установки текущего ПУ', py.GIS_Number_PY_To_Connect AS 'Номер ПУ в ГИС ЖКХ', py.Type_Kommunal_Res AS 'Вид коммунального ресурса', " +
                "Unit_Measurement_PY AS 'Единица измерения', py.Type_PU_Number_Tariffs AS 'Вид ПУ по количеству тарифов', py.T1 AS 'Т1', py.T2 AS 'Т2', py.T3 AS 'Т3', py.Trans_Coef AS 'Коэффициент трансформации', py.Installation_Date AS 'Дата установки', " +
                "py.Operation_Date AS 'Дата ввода в эксплуатацию', py.Last_Check_Date AS 'Дата последней поверки', py.Plomb_PU_Date AS 'Дата опломбирования ПУ заводом-изготовителем', py.Is_Temperature_Sensors AS 'Наличие датчиков температуры', py.Temperature_Sensors_Info AS 'Информация о наличии датчиков температуры', " +
                "py.Is_Pressure_Sensors AS 'Наличие датчиков давления', py.Pressure_Sensors_Info AS 'Информация о наличии датчиков давления', py.Is_AutomaticCalculation AS 'Наличие технической возможности автоматического расчета ресурса', py.Unique_GIS_Number AS 'Номер прибора учета в ГИС ЖКХ' " +
                "FROM Metering_Devices py " +
                "JOIN MKD_Premises p ON p.ID = py.ID_MKD_Premises " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN LS l ON l.ID = py.ID_LS " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE l.ID = @ID";

            try
            {
                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("@ID", l_id);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    this.dataGridView3.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PD_DG_Fill()
        {
            string query1 = "SELECT pd.ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS 'ФИО владельца ЛС', pd.Type_PD AS 'Тип ПД', " +
                "pd.Calculation_Period AS 'Расчетный период', " +
                "pd.Period_Sum AS 'Сумма к оплате за расчетный период', pd.Cash_Paid AS 'Оплачено денежных средств', " +
                "pd.Last_Payment_Date AS 'Дата последней поступившей оплаты', pd.Social_Support AS 'Субсидии компенсации и иные меры соц. поддержки граждан', " +
                "pd.Total_Period_Debt AS 'Итого к оплате за расчетный период c учетом задолженности/ переплаты', " +
                "pd.PR_Number AS 'Номер платежного реквизита по ПД', pd.Total_Period AS 'Итого к оплате за расчетный период', " +
                "pd.Total AS 'ИТОГО К ОПЛАТЕ', pd.Total_Legal_Expenses AS 'Итого к оплате по неустойкам и судебным расходам', pd.Full_GIS_Total AS 'РАССЧИТАНО ГИС ЖКХ' " +
                "FROM Payment_Document pd " +
                "JOIN LS l ON l.ID = pd.ID_LS " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "WHERE l.ID = @ID";
            try
            {
                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("@ID", l_id);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    this.dataGridView4.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                owner_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                owner_id = -1;
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ipy_id = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                ipy_id = -1;
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pd_id = int.Parse(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
                fio = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                date = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch
            {
                pd_id = -1;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Search(textBox1,dataGridView1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Search(textBox3,dataGridView3);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Search(textBox4,dataGridView4);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            PD_DG_Fill();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            IPY_DG_Fill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Owner_DG_Fill();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox1,dataGridView1);
            }
            if(e.Control && e.KeyCode == Keys.R)
            {
                e.SuppressKeyPress = true;
                Owner_DG_Fill();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox3, dataGridView3);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                e.SuppressKeyPress = true;
                IPY_DG_Fill();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(textBox4, dataGridView4);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                e.SuppressKeyPress = true;
                PD_DG_Fill();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (owner_id > 0)
            {
                var form = new Owners_Edit();
                form.id = owner_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Owner_DG_Fill();
                    owner_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (owner_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE Owner_LS WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", owner_id);
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
                Owner_DG_Fill();
                owner_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ipy_id > 0)
            {
                var form = new IPY_Edit();
                form.id = ipy_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {                    
                    IPY_DG_Fill();
                    ipy_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ipy_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE Metering_Devices WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", ipy_id);
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
                IPY_DG_Fill();
                ipy_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pd_id > 0)
            {
                var form = new PD_Edit();
                form.id = pd_id;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {   
                    PD_DG_Fill();
                    pd_id = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (pd_id > 0)
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE Payment_Document WHERE ID = @ID";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            cmd.Parameters.AddWithValue("@ID", pd_id);
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
                PD_DG_Fill();
                pd_id = 0;
            }
            else MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (pd_id > 0)
                {
                    var form = new PD_SearchForm() { Text = $"ПД {fio} за {date.Replace(" 0:00:00", "")}" };
                    form.id = pd_id;
                    form.Show();
                }
                else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new Owners_AF();            
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                Owner_DG_Fill();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new IPY_AF();
            form.l_id = l_id;
            form.p_id = p_id;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                IPY_DG_Fill();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new PD_AF();
            form.l_id = l_id;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                PD_DG_Fill();
        }
    }
}
