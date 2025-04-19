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
    public partial class Penalties_UC : UserControl
    {
        string query1 = "SELECT p.ID, pd.ID AS 'Номер ПД', p.Type_Accrual AS 'Вид начисления', p.Reason_Accrual AS 'Основания начислений', p.Sum AS 'Сумма' " +
           "FROM Penalties_And_Court_Costs p " +
           "JOIN Payment_Document pd ON pd.ID = p.ID_PD_Number";
        public Penalties_UC()
        {
            InitializeComponent();
        }

        private void Penalties_UC_Load(object sender, EventArgs e)
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
            var form = new Penalties_AF();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (GIS_Data.ID > 0)
            {
                var form = new Penalties_Edit();
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
            string queryDelete = "DELETE Penalties_And_Court_Costs WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(GIS_Data.ID, queryDelete, false) == true) GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
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
