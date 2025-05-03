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
    public partial class OPY_UC : UserControl
    {
        string query_load = "SELECT py.ID, py.ID_MKD_Address, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес дома', " +
           "py.Serial_Number AS 'Серийный номер', py.Type_PY AS 'Вид ПУ', py.Mark_PY AS 'Марка ПУ', py.Model_PY AS 'Модель ПУ', py.Is_Distance_Check AS 'Наличие возможности дистанционного снятия показаний', py.Name_DIstance_PY AS 'Наименование системы дистанционного снятия показаний', " +
           "py.Is_Many_PY_Used AS 'Объем ресурса(ов) определяется с помощью нескольких приборов учета', py.Place_Location_PY AS 'Место установки текущего ПУ', py.GIS_Number_PY_To_Connect AS 'Номер ПУ в ГИС ЖКХ', py.Type_Kommunal_Res AS 'Вид коммунального ресурса', " +
           "Unit_Measurement_PY AS 'Единица измерения', py.Type_PU_Number_Tariffs AS 'Вид ПУ по количеству тарифов', py.T1 AS 'Т1', py.T2 AS 'Т2', py.T3 AS 'Т3', py.Trans_Coef AS 'Коэффициент трансформации', py.Installation_Date AS 'Дата установки', " +
           "py.Operation_Date AS 'Дата ввода в эксплуатацию', py.Last_Check_Date AS 'Дата последней поверки', py.Plomb_PU_Date AS 'Дата опломбирования ПУ заводом-изготовителем', py.Is_Temperature_Sensors AS 'Наличие датчиков температуры', py.Temperature_Sensors_Info AS 'Информация о наличии датчиков температуры', " +
           "py.Is_Pressure_Sensors AS 'Наличие датчиков давления', py.Pressure_Sensors_Info AS 'Информация о наличии датчиков давления', py.Is_AutomaticCalculation AS 'Наличие технической возможности автоматического расчета ресурса', py.Unique_GIS_Number AS 'Номер прибора учета в ГИС ЖКХ' " +
           "FROM General_Metering_Device py " +
           "JOIN Characteristic_MKD m ON m.ID = py.ID_MKD_Address " +
           "JOIN Address_Book a ON a.ID = m.ID_Address";
        int id_opy, id_house;
        string house_name;
        public OPY_UC()
        {
            InitializeComponent();
        }

        private void OPY_UC_Load(object sender, EventArgs e)
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
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query_load_CB = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE m.ID = @ID";

            var opy = new OPY_AF() { Text = $"Добавление нового общедомового прибора учета. {house_name}" };
            opy.Load_Data(Add_Func(query_load_CB));
            opy.save_query = "INSERT INTO General_Metering_Device(ID_MKD_Address, Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Name_DIstance_PY," +
                         "Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs," +
                         "T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, Is_Temperature_Sensors, Temperature_Sensors_Info," +
                         "Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation, Unique_GIS_Number) " +
                         "VALUES(@ID_MKD_Address, @Serial_Number, @Type_PY, @Mark_PY, @Model_PY, @Is_Distance_Check, @Name_DIstance_PY," +
                         "@Is_Many_PY_Used, @Place_Location_PY, @GIS_Number_PY_To_Connect, @Type_Kommunal_Res, @Unit_Measurement_PY, @Type_PU_Number_Tariffs," +
                         "@T1, @T2, @T3, @Trans_Coef, @Installation_Date, @Operation_Date, @Last_Check_Date, @Plomb_PU_Date, @Is_Temperature_Sensors, @Temperature_Sensors_Info," +
                         "@Is_Pressure_Sensors, @Pressure_Sensors_Info, @Is_AutomaticCalculation, @Unique_GIS_Number)";
            opy.status = "добавлена";
            opy.general_Metering_DeviceBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = opy.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private DataTable Add_Func(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id_house);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE General_Metering_Device WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(id_opy, queryDelete, false, $"Удалить данные ОПУ: {house_name}?") == true) GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (id_opy > -1)
            {
                string query_load_CB = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
               "JOIN Address_Book a ON a.ID = m.ID_Address " +
               "WHERE m.ID = @ID";

                string query_load_edit = "SELECT Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Name_Distance_PY, Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, " +
                "Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs, T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, " +
                "Is_Temperature_Sensors, Temperature_Sensors_Info, Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation, Unique_GIS_Number, ID_MKD_Address FROM General_Metering_Device " +
                "WHERE ID = @ID";

                var opy = new OPY_AF() { Text = $"Изменение данных ОПУ. {house_name}" };
                opy.Load_Data_Edit(Add_Func(query_load_CB), id_opy, query_load_edit);
                opy.save_query = $"UPDATE General_Metering_Device SET ID_MKD_Address = @ID_MKD_Address, " +
                        $"Serial_Number = @Serial_Number, Type_PY = @Type_PY," +
                        $"Mark_PY = @Mark_PY, Model_PY = @Model_PY, " +
                        $"Is_Distance_Check = @Is_Distance_Check, Name_Distance_PY = @Name_Distance_PY," +
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
                        $"Is_AutomaticCalculation = @Is_AutomaticCalculation, Unique_GIS_Number = @Unique_GIS_Number " +
                        $"WHERE ID = {id_opy}";
                opy.status = "изменена";
                opy.general_Metering_DeviceBindingNavigatorSaveItem.Text = "Изменить данные";
                DialogResult result = opy.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query_load, dataGridView1);
                    id_opy = -1;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_opy = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                id_house = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                house_name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {
                id_opy = -1;
                id_house = -1;
            }
        }

        private void DoxFill_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                id.Add(int.Parse(r.Cells[0].Value.ToString()));
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GIS_Data.OPY_Dox_Fill(id);
                id_opy = 0;
            }
            else MessageBox.Show("Укажите запись из таблицы для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
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
