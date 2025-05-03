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
        string query_load = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', m.Statys AS 'Состояние', m.Life_Cycle_Stage AS 'Стадия жизненного цикла'," +
           "m.Total_Building_Area AS 'Общая площадь здания', m.Year_Of_Commissioning AS 'Год ввода в эксплуатацию', m.Count_floors AS 'Кол-во этажей', m.Count_Underfloors AS 'Кол-во подземных этажей'," +
           "m.Olson AS 'Часовая зона по Olson', m.Is_Cultural_Legacy AS 'Наличие статуса объекта культурного наследия', m.Cadastral_Number AS 'Кадастровый номер', m.ID_FIAS AS 'ФИАС', m.OKTMO AS 'ОКТМО'," +
           "m.Payment_Account_S AS 'Расчетный счет для услуг', m.BIK_S AS 'БИК для услуг', m.Payment_Account_R AS 'Расчетный счет для кап. ремонта', m.BIK_R  AS 'БИК для кап. ремонта' " +
           "FROM Characteristic_MKD m " +
           "JOIN Address_Book a ON a.ID = m.ID_Address";
        int id_house;
        string house_name;

        public MKD_UC()
        {
            InitializeComponent();
        }

        private void MKD_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query_load, dataGridView1);

            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT ID, Type_Street + ' ' + Street AS 'Street' FROM Address_Book " +
                "ORDER BY Street";

            var mkd = new MKD_AF() { Text = $"Добавление нового многоквартирного дома." };
            mkd.Load_Data(Add_Func(query_load_CB));
            mkd.save_query = "INSERT INTO Characteristic_MKD(ID_Address, House_Number, Statys, ID_FIAS, OKTMO, Life_Cycle_Stage, " +
                        "Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, Olson, Is_Cultural_Legacy, " +
                        "Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R) " +
                        $"VALUES(@ID_Address, @House_Number, @Statys, @ID_FIAS, @OKTMO, " +
                        $"@Life_Cycle_Stage, @Total_Building_Area, @Year_Of_Commissioning, @Count_floors, " +
                        $"@Count_Underfloors, @Olson, @Is_Cultural_Legacy, @Cadastral_Number, " +
                        $"@Payment_Account_S, @BIK_S, @Payment_Account_R, @BIK_R) ";
            mkd.status = "добавлена";
            mkd.characteristic_MKDBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = mkd.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private DataTable Add_Func(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("@ID", id_owner);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT ID, Type_Street + ' ' + Street AS 'Street' FROM Address_Book " +
                "ORDER BY Street";

            string query_load_edit = "SELECT ID_Address, House_Number, Statys, ID_FIAS, OKTMO, " +
                "Life_Cycle_Stage, Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, " +
                "Olson, Is_Cultural_Legacy, Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R FROM Characteristic_MKD m " +
                $"WHERE m.ID = {id_house}";

            if (id_house > -1)
            {
                var mkd = new MKD_AF() { Text = $"Изменение данных многоквартирного дома. {house_name}" };
                mkd.Load_Data_Edit(Add_Func(query_load_CB),query_load_edit, id_house);
                mkd.save_query = $"UPDATE Characteristic_MKD SET ID_Address = @ID_Address, House_Number = @House_Number, Statys = @Statys, ID_FIAS = @ID_FIAS, OKTMO = @OKTMO, " +
                    $"Life_Cycle_Stage = @Life_Cycle_Stage, Total_Building_Area = @Total_Building_Area, Year_Of_Commissioning = @Year_Of_Commissioning, Count_floors = @Count_floors, Count_Underfloors = @Count_Underfloors, " +
                    $"Olson = @Olson, Is_Cultural_Legacy = @Is_Cultural_Legacy, Cadastral_Number = @Cadastral_Number, Payment_Account_S = @Payment_Account_S, BIK_S = @BIK_S, Payment_Account_R = @Payment_Account_R, BIK_R = @BIK_R " +
                    $"WHERE ID = {id_house}";
                mkd.status = "изменена";
                mkd.characteristic_MKDBindingNavigatorSaveItem.Text = "Изменить данные";
                DialogResult result = mkd.ShowDialog();
                if (result == DialogResult.Cancel)
                    GIS_Data.SQLFill(query_load, dataGridView1);
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_house = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                house_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                id_house = -1;
                house_name = "";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Characteristic_MKD WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(id_house, queryDelete, false, $"Удалить данные многоквартирного дома: {house_name}?") == true) GIS_Data.SQLFill(query_load, dataGridView1);
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
            id_house = 0;            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query_load, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if(id_house > 0)//if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                var form = new MKD_SearchForm() { Text = $"Дом: {house_name}" };
                form.id_house = id_house;
                form.Show();
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
