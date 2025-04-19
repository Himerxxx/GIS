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

namespace GIS.UC
{
    public partial class Premises_LS_Relation_UC : UserControl
    {
        string query1 = "SELECT pl.ID_LS," +
                "pl.ID_Premises," +
                "o.SecondName + ' ' + " +
                "o.FirstName + ' ' + " +
                "o.LastName AS 'ФИО Владельца'," +
                "a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Адрес помещения', " +
                "Is_Open AS 'ЛС открыт'," +
                "Number_JKY AS 'Номер ЖКУ'," +
                "o.SNILS AS 'СНИЛС'," +
                "o.Passport_Type AS 'ДУЛ'," +
                "o.Passport_Number AS 'Номер ДУЛ'," +
                "o.Passport_Series AS 'Серия ДУЛ'," +
                "o.Passport_Date AS 'Дата получения ДУЛ' " +
            "FROM Premises_LS_Relations pl " +
            "JOIN LS l ON l.ID = pl.ID_LS " +
            "JOIN MKD_Premises p ON p.ID = pl.ID_Premises " +
            "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
            "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = m.ID_Address";
        public Premises_LS_Relation_UC()
        {
            InitializeComponent();
        }

        private void Premises_LS_Relation_UC_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[1].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new Premises_LS_Relation_AF();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Premises_LS_Relations " +
                        "WHERE ID_LS = @ID AND ID_Premises = @secID";
            if(GIS_Data.RemoveClickTemp(GIS_Data.ID, queryDelete, true) == true) GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GIS_Data.ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                GIS_Data.secID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {
                GIS_Data.ID = -1;
                GIS_Data.secID = -1;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (GIS_Data.ID > 0)
            {
                var form = new Premises_LS_Relation_Edit();
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query1, dataGridView1);
                    GIS_Data.ID = 0;
                    GIS_Data.secID = 0;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void DoxFill_Click(object sender, EventArgs e)
        {
            List<int[]> id = new List<int[]>();
            
            int i = 0;
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int[] mas = { int.Parse(r.Cells[0].Value.ToString()), int.Parse(r.Cells[1].Value.ToString()) };
                //mas[i,0] = int.Parse(r.Cells[0].Value.ToString());
                //mas[i, 1] = int.Parse(r.Cells[1].Value.ToString());
                id.Add(mas);
                i += 1;
                //id.Add(int.Parse(r.Cells[0].Value.ToString()), int.Parse(r.Cells[1].Value.ToString()));
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GIS_Data.LS_Dox_Fill(id);
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            GIS_Data.ID = 0;
            GIS_Data.secID = 0;
            i = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query1,e);
        }
    }
}
