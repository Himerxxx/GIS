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
    public partial class MKD_UC : UserControl
    {
        string query1 = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', m.Statys AS 'Состояние', m.Life_Cycle_Stage AS 'Стадия жизненного цикла'," +
           "m.Total_Building_Area AS 'Общая площадь здания', m.Year_Of_Commissioning AS 'Год ввода в эксплуатацию', m.Count_floors AS 'Кол-во этажей', m.Count_Underfloors AS 'Кол-во подземных этажей'," +
           "m.Olson AS 'Часовая зона по Olson', m.Is_Cultural_Legacy AS 'Наличие статуса объекта культурного наследия', m.Cadastral_Number AS 'Кадастровый номер', m.ID_FIAS AS 'ФИАС', m.OKTMO AS 'ОКТМО'," +
           "m.Payment_Account_S AS 'Расчетный счет для услуг', m.BIK_S AS 'БИК для услуг', m.Payment_Account_R AS 'Расчетный счет для кап. ремонта', m.BIK_R  AS 'БИК для кап. ремонта' " +
           "FROM Characteristic_MKD m " +
           "JOIN Address_Book a ON a.ID = m.ID_Address";
        
        public MKD_UC()
        {
            InitializeComponent();
        }

        private void MKD_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query1, dataGridView1);

            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new MKD_AF();
            DialogResult result = form.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                GIS_Data.SQLFill(query1, dataGridView1);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (GIS_Data.MKD_ID > 0)
            {
                var form = new MKD_Edit();
                form.id = GIS_Data.MKD_ID;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query1, dataGridView1);
                    GIS_Data.MKD_ID = 0;
                }                  

            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GIS_Data.MKD_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                GIS_Data.HouseName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                GIS_Data.MKD_ID = -1;
                GIS_Data.HouseName = "";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Characteristic_MKD WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(GIS_Data.MKD_ID, queryDelete, false) == true) GIS_Data.SQLFill(query1, dataGridView1);
        }

        private void DoxFill_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            foreach(DataGridViewRow r in dataGridView1.SelectedRows)
            {
                id.Add(int.Parse(r.Cells[0].Value.ToString()));
            }
            if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count > 1)
            {
                GIS_Data.MKD_Dox_Fill(id);
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            GIS_Data.MKD_ID = 0;            
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
        private void button7_Click(object sender, EventArgs e)
        {
            if(GIS_Data.MKD_ID > 0)//if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                var form = new MKD_SearchForm() { Text = $"Дом: {GIS_Data.HouseName}" };
                form.id_house = GIS_Data.MKD_ID;
                form.Show();
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
