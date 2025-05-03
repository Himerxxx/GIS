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
        int id_ipy = -1, id_premises = -1, id_ls = -1;
        string premises_name, ipy_mark;

        string query_load = "SELECT py.ID, py.ID_MKD_Premises, py.ID_LS, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Адрес помещения', " +
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
            GIS_Data.SQLFill(query_load, dataGridView1);

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
            dataGridView1.Columns[2].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            /*var form = new IPY_AF();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query1, dataGridView1);*/
            string query_CB1_load = "SELECT p.ID AS ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Address' FROM MKD_Premises p " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE p.ID = @p_id";

            string query_CB2_load = "SELECT l.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM LS l " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "WHERE l.ID = @l_id";

            List<string> querys = new List<string>();
            querys.Add(query_CB1_load);
            querys.Add(query_CB2_load);

            var ipy = new IPY_AF() { Text = $"Добавление нового ИПУ. {premises_name}" };
            ipy.Load_Data(Add_Func(querys));
            ipy.save_query = "INSERT INTO Metering_Devices(ID_MKD_Premises, ID_LS, Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Distance_Check_Info," +
                        "Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs," +
                        "T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, Is_Temperature_Sensors, Temperature_Sensors_Info," +
                        "Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation) " +
                        "VALUES(@ID_MKD_Premises, @ID_LS, @Serial_Number, @Type_PY, @Mark_PY, @Model_PY, @Is_Distance_Check, @Distance_Check_Info," +
                        "@Is_Many_PY_Used, @Place_Location_PY, @GIS_Number_PY_To_Connect, @Type_Kommunal_Res, @Unit_Measurement_PY, @Type_PU_Number_Tariffs," +
                        "@T1, @T2, @T3, @Trans_Coef, CONVERT(VARCHAR, @Installation_Date,103), CONVERT(VARCHAR, @Operation_Date,103), CONVERT(VARCHAR, @Last_Check_Date,103), " +
                        "CONVERT(VARCHAR, @Plomb_PU_Date,103), @Is_Temperature_Sensors, @Temperature_Sensors_Info," +
                        "@Is_Pressure_Sensors, @Pressure_Sensors_Info, @Is_AutomaticCalculation)";
            ipy.status = "добавлена";
            ipy.metering_DevicesBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = ipy.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private List<DataTable> Add_Func(List<string> querys)
        {
            List<DataTable> dataTables = new List<DataTable>();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(querys[0], connection);
                List<SqlParameter> prm = new List<SqlParameter>()
                {
                    new SqlParameter("@p_id",SqlDbType.Int) { Value = id_premises},
                    new SqlParameter("@l_id",SqlDbType.Int) { Value = id_ls}
                };
                cmd.Parameters.AddRange(prm.ToArray());
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataTables.Add(dt);

                cmd.CommandText = querys[1];
                da.SelectCommand = cmd;
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                dataTables.Add(dt1);

                return dataTables;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (id_ipy > -1)
            {
                string query_CB1_load = "SELECT p.ID AS ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Address' FROM MKD_Premises p " +
                    "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                    "JOIN Address_Book a ON a.ID = m.ID_Address " +
                    "WHERE p.ID = @p_id";

                string query_CB2_load = "SELECT l.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM LS l " +
                    "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                    "WHERE l.ID = @l_id";

                string query_load_edit = "SELECT Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Distance_Check_Info, Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, " +
                    "Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs, T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, " +
                    "Is_Temperature_Sensors, Temperature_Sensors_Info, Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation, Unique_GIS_Number FROM Metering_Devices " +
                    "WHERE ID = @ID";

                List<string> querys = new List<string>();
                querys.Add(query_CB1_load);
                querys.Add(query_CB2_load);

                var ipy = new IPY_AF() { Text = $"Изменение данных ИПУ. {premises_name}" };
                ipy.Load_Data_Edit(Add_Func(querys), id_ipy, query_load_edit);
                ipy.save_query = $"UPDATE Metering_Devices SET ID_MKD_Premises = @ID_MKD_Premises, ID_LS = @ID_LS, " +
                        $"Serial_Number = @Serial_Number, Type_PY = @Type_PY," +
                        $"Mark_PY = @Mark_PY, Model_PY = @Model_PY, " +
                        $"Is_Distance_Check = @Is_Distance_Check, Distance_Check_Info = @Distance_Check_Info," +
                        $"Is_Many_PY_Used = @Is_Many_PY_Used, Place_Location_PY = @Place_Location_PY," +
                        $"GIS_Number_PY_To_Connect = @GIS_Number_PY_To_Connect, Type_Kommunal_Res = @Type_Kommunal_Res," +
                        $"Unit_Measurement_PY = @Unit_Measurement_PY, Type_PU_Number_Tariffs = @Type_PU_Number_Tariffs," +
                        $"T1 = @T1, T2 = @T2, T3 = @T3," +
                        $"Trans_Coef = @Trans_Coef, Installation_Date = CONVERT(VARCHAR,@Installation_Date,103)," +
                        $"Operation_Date = CONVERT(VARCHAR,@Operation_Date,103)," +
                        $"Last_Check_Date = CONVERT(VARCHAR,@Last_Check_Date,103)," +
                        $"Plomb_PU_Date = CONVERT(VARCHAR,@Plomb_PU_Date,103)," +
                        $"Is_Temperature_Sensors = @Is_Temperature_Sensors, Temperature_Sensors_Info = @Temperature_Sensors_Info," +
                        $"Is_Pressure_Sensors = @Is_Pressure_Sensors, Pressure_Sensors_Info = @Pressure_Sensors_Info," +
                        $"Is_AutomaticCalculation = @Is_AutomaticCalculation " +
                        $"WHERE ID = {id_ipy}";
                ipy.status = "изменена";
                ipy.metering_DevicesBindingNavigatorSaveItem.Text = "Изменить данные";
                DialogResult result = ipy.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query_load, dataGridView1);
                    id_ipy = -1;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Metering_Devices WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(GIS_Data.ID, queryDelete, false, $"Удалить данные ИПУ: {ipy_mark}? По адресу {premises_name}") == true) GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_ipy = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                id_premises = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                id_ls = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                premises_name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                ipy_mark = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            {
                id_ipy = -1;
                id_premises = -1;
                id_ls = -1;
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
            GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query_load, e);
        }
    }
}
