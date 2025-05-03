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

namespace GIS.UC
{
    public partial class Meter_Reading_UC : UserControl
    {
        public string query_load = "SELECT i.ID, i.ID_Premises, o.ID, a.Type_Street + ' ' + a.Street + ' ' + mkd.House_Number AS 'Адрес помещения', p.Info AS 'Номер помещения', i.Month_of_metering AS 'Дата показаний', i.Cold_water AS 'ХВС', i.Hot_water AS 'ГВС', i.Electic_energy AS 'ЭС', i.Heating AS 'ОТ' " +
            "FROM Input_meter_readings i " +
            "JOIN MKD_Premises p ON p.ID = i.ID_Premises " +
            "JOIN Characteristic_MKD mkd ON mkd.ID = p.ID_MKD_Address " +
            "JOIN Address_Book a ON a.ID = mkd.ID_Address " +
            "JOIN Premises_LS_Relations p_ls ON p_ls.ID_Premises = p.ID " +
            "JOIN LS ls ON ls.ID = p_ls.ID_LS " +
            "JOIN Owner_LS o ON o.ID = ls.ID_Owner " +
            "ORDER BY i.Month_of_metering DESC";
        int id_input, id_premises, id_owner;
        string premises_name, owner_fio, premises_number;

        public Meter_Reading_UC()
        {
            InitializeComponent();
        }

        private void Meter_Reading_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query_load, dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 30;
            dataGridView1.Columns[4].Width = 30;

            splitContainer1.Size = new Size(1233, 394);

            splitContainer1.Location = new Point(3, 3);
            splitContainer1.SplitterDistance = 229;

            button1.Location = new Point(15, 53);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");
            button1.Size = new Size(199, 35);
            button1.Text = "Добавить";

            button2.Location = new Point(15, 98);
            button2.Font = new Font("Times New Roman", 12);
            button2.BackColor = Color.FromName("InactiveCaption");
            button2.Size = new Size(199, 35);
            button2.Text = "Изменить";

            button3.Location = new Point(15, 143);
            button3.Font = new Font("Times New Roman", 12);
            button3.BackColor = Color.FromName("InactiveCaption");
            button3.Size = new Size(199, 35);
            button3.Text = "Удалить";

            button4.Location = new Point(189, 311);
            button4.BackColor = Color.FromName("Menu");
            button4.Size = new Size(25, 25);

            button5.Location = new Point(15, 337);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");
            button5.Size = new Size(199, 35);
            button5.Text = "Сбросить";

            button6.Location = new Point(15, 188);
            button6.Font = new Font("Times New Roman", 12);
            button6.BackColor = Color.FromName("InactiveCaption");
            button6.Size = new Size(199, 35);
            button6.Text = "Импортировать показания";

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Size = new Size(967, 336);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //GIS_Data.Template_Meter_Housemain_Create();
            Call_Input_Meter_From_Document_Async();

            //GIS_Data.ProgressForm();

        }

        private async void Call_Input_Meter_From_Document_Async()
        {
            await GIS_Data.Input_Meter_From_Document();
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
                    new SqlParameter("@o_id",SqlDbType.Int) { Value = id_owner},
                    new SqlParameter("@i_id",SqlDbType.Int) { Value = id_input}
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ipy_mark = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            try
            {
                id_input = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                id_premises = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                id_owner = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                premises_name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                premises_number = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                id_input = -1;
                id_premises = -1;
                id_owner = -1;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query_CB1_load = "SELECT p.ID AS ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Address' FROM MKD_Premises p " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE p.ID = @p_id";

            string query_CB2_load = "SELECT o.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM Owner_LS o " +               
                "WHERE o.ID = @o_id";

            List<string> querys = new List<string>();
            querys.Add(query_CB1_load);
            querys.Add(query_CB2_load);

            var input = new Input_Meter_AF() { Text = $"Внесение новых показаний счетчиков. Адрес: {premises_name}, кв. {premises_number}" };
            //input.Load_Data(Add_Func(querys));
            input.save_query = "INSERT INTO Metering_Devices(ID_MKD_Premises, ID_LS, Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Distance_Check_Info," +
                        "Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs," +
                        "T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, Is_Temperature_Sensors, Temperature_Sensors_Info," +
                        "Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation) " +
                        "VALUES(@ID_MKD_Premises, @ID_LS, @Serial_Number, @Type_PY, @Mark_PY, @Model_PY, @Is_Distance_Check, @Distance_Check_Info," +
                        "@Is_Many_PY_Used, @Place_Location_PY, @GIS_Number_PY_To_Connect, @Type_Kommunal_Res, @Unit_Measurement_PY, @Type_PU_Number_Tariffs," +
                        "@T1, @T2, @T3, @Trans_Coef, CONVERT(VARCHAR, @Installation_Date,103), CONVERT(VARCHAR, @Operation_Date,103), CONVERT(VARCHAR, @Last_Check_Date,103), " +
                        "CONVERT(VARCHAR, @Plomb_PU_Date,103), @Is_Temperature_Sensors, @Temperature_Sensors_Info," +
                        "@Is_Pressure_Sensors, @Pressure_Sensors_Info, @Is_AutomaticCalculation)";
            input.status = "добавлена";
            input.toolStripButton1.Text = "Сохранить данные";
            DialogResult result = input.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);
        }
    }
}
