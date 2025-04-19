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
    public partial class PremisesUC : UserControl
    {
        string query1 = "SELECT p.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Адрес помещения'," +
           "p.Is_Living AS 'Помещение является жилым', p.Premises_Description AS 'Характеристика помещения', p.Total_Area AS 'Общая площадь помещения', p.Living_Total_Area AS 'Жилая площадь помещения'," +
           "p.Is_Common AS 'Является общим имуществом', p.Cadastral_Number AS 'Кадастровый номер', p.Is_Confirmed_Supplier AS 'Информация подтверждена поставщиком' " +
           "FROM MKD_Premises p " +
           "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
           "JOIN Address_Book a ON a.ID = m.ID_Address ";
        public PremisesUC()
        {
            InitializeComponent();
        }

        private void PremisesUC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query1, dataGridView1);

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

            splitContainer1.Size = new Size(1233, 394);
            splitContainer1.SplitterDistance = 229;
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 200;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var premises = new Premises_AF();
            premises.id = GIS_Data.Premises_ID;
            DialogResult result = premises.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (GIS_Data.Premises_ID > 0)
            {
                var form = new Premises_Edit();
                form.id = GIS_Data.Premises_ID;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query1, dataGridView1);
                    GIS_Data.Premises_ID = 0;
                }                    
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GIS_Data.Premises_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                GIS_Data.Premises_ID = -1;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE MKD_Premises WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(GIS_Data.Premises_ID, queryDelete, false) == true) GIS_Data.SQLFill(query1, dataGridView1);
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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
