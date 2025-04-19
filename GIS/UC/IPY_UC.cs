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
    public partial class IPY_UC : UserControl
    {
        string query1 = "SELECT py.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Адрес помещения', " +
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
           "JOIN Address_Book a ON a.ID = m.ID_Address";
        public IPY_UC()
        {
            InitializeComponent();
        }

        private void PY_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query1, dataGridView1);

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

            button4.Location = new Point(15, 188);
            button4.Font = new Font("Times New Roman", 12);
            button4.BackColor = Color.FromName("InactiveCaption");
            button4.Size = new Size(199, 35);

            button5.Location = new Point(189, 311);
            button5.BackColor = Color.FromName("Menu");
            button5.Size = new Size(25, 25);

            button6.Location = new Point(15, 337);
            button6.Font = new Font("Times New Roman", 12);
            button6.BackColor = Color.FromName("InactiveCaption");
            button6.Size = new Size(199, 35);

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new IPY_AF();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (GIS_Data.ID > 0)
            {
                var form = new IPY_Edit();
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query1, dataGridView1);
                    GIS_Data.ID = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Metering_Devices WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(GIS_Data.ID, queryDelete, false) == true) GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GIS_Data.ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                GIS_Data.ID = -1;
            }
        }

        private void DoxFill_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GIS_Data.IPY_Dox_Fill();
                GIS_Data.ID = 0;
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query1, e);
        }
    }
}
