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
using System.IO;

namespace GIS.UC
{
    public partial class PD_Dox_UC : UserControl
    {
        string query1 = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', m.Statys AS 'Состояние', m.Life_Cycle_Stage AS 'Стадия жизненного цикла'," +
           "m.Total_Building_Area AS 'Общая площадь здания', m.Year_Of_Commissioning AS 'Год ввода в эксплуатацию', m.Count_floors AS 'Кол-во этажей', m.Count_Underfloors AS 'Кол-во подземных этажей'," +
           "m.Olson AS 'Часовая зона по Olson', m.Is_Cultural_Legacy AS 'Наличие статуса объекта культурного наследия', m.Cadastral_Number AS 'Кадастровый номер', m.ID_FIAS AS 'ФИАС', m.OKTMO AS 'ОКТМО'," +
           "m.Payment_Account_S AS 'Расчетный счет для услуг', m.BIK_S AS 'БИК для услуг', m.Payment_Account_R AS 'Расчетный счет для кап. ремонта', m.BIK_R  AS 'БИК для кап. ремонта' " +
           "FROM Characteristic_MKD m " +
           "JOIN Address_Book a ON a.ID = m.ID_Address";
        int id;
        public PD_Dox_UC()
        {
            InitializeComponent();
        }

        private void PD_Dox_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query1, dataGridView1);

            splitContainer1.Size = new Size(1233, 394);

            splitContainer1.Location = new Point(3, 3);
            splitContainer1.SplitterDistance = 229;

            button1.Location = new Point(15, 53);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");
            button1.Size = new Size(199, 35);

            button2.Location = new Point(189, 311);
            button2.BackColor = Color.FromName("Menu");
            button2.Size = new Size(25, 25);

            button3.Location = new Point(15, 337);
            button3.Font = new Font("Times New Roman", 12);
            button3.BackColor = Color.FromName("InactiveCaption");
            button3.Size = new Size(199, 35);

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
        }

        private void Dox_Fill_Click(object sender, EventArgs e)
        {

            var form = new Period_PD_F();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<int> id = new List<int>();
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    id.Add(int.Parse(r.Cells[0].Value.ToString()));
                }
                if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    GIS_Data.PD_Dox_Fill(id);
                }
                else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                id.Clear();
            }

            //GIS_Data.secID = 0;

        }
        //private string Date()
        //{
        //    string date = DateTime.Now.ToShortDateString().Replace(".","");            
        //    return date.Substring(4) + date.Substring(2, 2);
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //GIS_Data.secID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {
                id = -1;
                //GIS_Data.secID = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
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
