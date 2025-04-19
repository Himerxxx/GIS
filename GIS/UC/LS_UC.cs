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
    public partial class LS_UC : UserControl
    {
        string query1 = "SELECT l.ID, p.ID, o.FirstName + ' ' + o.SecondName + ' ' + o.LastName AS 'ФИО Владельца', ab.Type_Street + ' ' + ab.Street + ' ' + mkd.House_Number + N', кв. ' + p.Info AS 'Адрес помещения' ," +
           "l.Type_LS AS 'Тип лицевого счета', l.Number_JKY AS 'Идентификатор ЖКУ', l.Is_Employer AS 'Является нанимателем', l.Is_Splited AS 'Лицевые счета на помещение(я) разделены', " +
           "l.ShareOfPayment AS 'Доля внесения платы размер доли в %', l.Is_Open AS 'ЛС открыт', l.ELS AS 'ЕЛС' " +
           "FROM LS l " +
           "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
           "JOIN Premises_LS_Relations pl ON pl.ID_LS = l.ID " +
           "JOIN MKD_Premises p ON p.ID = pl.ID_Premises " +
           "JOIN Characteristic_MKD mkd ON mkd.ID = p.ID_MKD_Address " +
           "JOIN Address_Book ab ON ab.ID = mkd.ID_Address";
        int sec_id;
        string fio, address;
        public LS_UC()
        {
            InitializeComponent();
        }

        private void LS_UC_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 200;
        }



        private void Add_Click(object sender, EventArgs e)
        {
            var form = new LS_AF();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE LS WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(GIS_Data.LS_ID, queryDelete, false) == true) GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GIS_Data.LS_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                sec_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                fio = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                address = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                GIS_Data.LS_ID = -1;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (GIS_Data.LS_ID > 0)
            {
                var form = new LS_Edit();
                form.id = GIS_Data.LS_ID;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query1, dataGridView1);
                    GIS_Data.LS_ID = 0;
                }
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
            GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query1, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (GIS_Data.LS_ID > 0)
            {
                var form = new LS_SearchForm() { Text = $"ФИО Владельца ЛС: {fio}, Адрес помещения: {address}" };
                form.l_id = GIS_Data.LS_ID;
                form.p_id = sec_id;
                form.Show();                
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
