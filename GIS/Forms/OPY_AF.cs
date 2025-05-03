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

namespace GIS.Forms
{
    public partial class OPY_AF : Form
    {
        public int id;
        public string status, save_query;
        public OPY_AF()
        {
            InitializeComponent();
        }

        private void general_Metering_DeviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохрание данных в БД

            if (comboBox10.SelectedValue == null)
                MessageBox.Show("Выберите Адрес поиещения");
            else if (serial_NumberTextBox.Text == "")
                MessageBox.Show("Введите Серийный номер ПУ");
            else if (comboBox1.SelectedItem == null)
                MessageBox.Show("Выберите Тип ПУ");
            else if (mark_PYTextBox.Text == "")
                MessageBox.Show("Введите марку ПУ");
            else if (model_PYTextBox.Text == "")
                MessageBox.Show("Введите модель ПУ");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Дистанционное снятие показаний");
            else if (comboBox3.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Объем ресурса(ов) определяется с помощью нескольких приборов учета");
            else if (comboBox5.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Вид коммунального ресурса");
            else if (trans_CoefTextBox.Text == "")
                MessageBox.Show("Введите Коэффициент трансформации");
            else if (operation_DateDateTimePicker.Checked == false)
                MessageBox.Show("Введите Дату ввода в эксплуатацию");
            else if (plomb_PU_DateDateTimePicker.Checked == false)
                MessageBox.Show("Введите Дату опломбирования ПУ заводом-изготовителем");
            else if (comboBox7.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Наличие датчиков температуры");
            else if (comboBox8.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Наличие датчиков давления");
            else
            {
                try
                {
                    /*string querySave = "INSERT INTO General_Metering_Device(ID_MKD_Address, Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Name_DIstance_PY," +
                        "Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs," +
                        "T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, Is_Temperature_Sensors, Temperature_Sensors_Info," +
                        "Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation) " +
                        $"VALUES({comboBox10.SelectedValue}, {serial_NumberTextBox.Text}, {comboBox1.SelectedIndex}, {Check_TN(mark_PYTextBox)}," +
                        $"{Check_TN(model_PYTextBox)}, {comboBox2.SelectedIndex}, {Check_TN(name_DIstance_PYTextBox)}, {comboBox3.SelectedIndex}," +
                        $"{Check_C(comboBox4)}, {Check_TN(gIS_Number_PY_To_ConnectTextBox)}," +
                        $"{comboBox5.SelectedIndex}, {Check_TN(unit_Measurement_PYTextBox)}," +
                        $"{Check_C(comboBox6)}, " +
                        $"{Check_TD(t1TextBox)}, {Check_TD(t2TextBox)}, {Check_TD(t3TextBox)}," +
                        $"{Check_TD(trans_CoefTextBox)}, CONVERT(VARCHAR,{Check_D(installation_DateDateTimePicker)}, 103)," +
                        $"CONVERT(VARCHAR,{Check_D(operation_DateDateTimePicker)}, 103)," +
                        $"CONVERT(VARCHAR,{Check_D(last_Check_DateDateTimePicker)}, 103)," +
                        $"CONVERT(VARCHAR,{Check_D(plomb_PU_DateDateTimePicker)}, 103)," +
                        $"{comboBox7.SelectedIndex}, {Check_T(temperature_Sensors_InfoTextBox)}," +
                        $"{comboBox8.SelectedIndex}, {Check_T(pressure_Sensors_InfoTextBox)}," +
                        $"{Check_C(comboBox9)})";*/

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query);

                        command.Parameters.AddWithValue("@ID_MKD_Address", SqlDbType.Int).Value = comboBox10.SelectedValue;
                        command.Parameters.AddWithValue("@Serial_Number", SqlDbType.NVarChar).Value = serial_NumberTextBox.Text ; 
                        command.Parameters.AddWithValue("@Type_PY", SqlDbType.TinyInt).Value = comboBox1.SelectedIndex;  
                        command.Parameters.AddWithValue("@Mark_PY", GIS_Data.Check_T(mark_PYTextBox));
                        command.Parameters.AddWithValue("@Model_PY", GIS_Data.Check_T(model_PYTextBox));
                        command.Parameters.AddWithValue("@Is_Distance_Check", comboBox2.SelectedIndex);
                        command.Parameters.AddWithValue("@Name_DIstance_PY", GIS_Data.Check_T(name_DIstance_PYTextBox));
                        command.Parameters.AddWithValue("@Is_Many_PY_Used", comboBox3.SelectedIndex);
                        command.Parameters.AddWithValue("@Place_Location_PY", GIS_Data.Check_C(comboBox4)); 
                        command.Parameters.AddWithValue("@GIS_Number_PY_To_Connect", GIS_Data.Check_T(gIS_Number_PY_To_ConnectTextBox));
                        command.Parameters.AddWithValue("@Type_Kommunal_Res", comboBox5.SelectedIndex);
                        command.Parameters.AddWithValue("@Unit_Measurement_PY", GIS_Data.Check_T(unit_Measurement_PYTextBox));
                        command.Parameters.AddWithValue("@Type_PU_Number_Tariffs",  GIS_Data.Check_C(comboBox6)); 
                        command.Parameters.AddWithValue("@T1", GIS_Data.Check_TD(t1TextBox));
                        command.Parameters.AddWithValue("@T2", GIS_Data.Check_TD(t2TextBox));
                        command.Parameters.AddWithValue("@T3", GIS_Data.Check_TD(t3TextBox));
                        command.Parameters.AddWithValue("@Trans_Coef", GIS_Data.Check_TD(trans_CoefTextBox));                       
                        command.Parameters.AddWithValue("@Installation_Date", GIS_Data.Check_D(installation_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Operation_Date", GIS_Data.Check_D(operation_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Last_Check_Date", GIS_Data.Check_D(last_Check_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Plomb_PU_Date", GIS_Data.Check_D(plomb_PU_DateDateTimePicker));                       
                        command.Parameters.AddWithValue("@Is_Temperature_Sensors", comboBox7.SelectedIndex);
                        command.Parameters.AddWithValue("@Temperature_Sensors_Info", GIS_Data.Check_T(temperature_Sensors_InfoTextBox)); 
                        command.Parameters.AddWithValue("@Is_Pressure_Sensors", comboBox8.SelectedIndex);
                        command.Parameters.AddWithValue("@Pressure_Sensors_Info", GIS_Data.Check_T(pressure_Sensors_InfoTextBox)); 
                        command.Parameters.AddWithValue("@Is_AutomaticCalculation", GIS_Data.Check_C(comboBox9)); 
                        command.Parameters.AddWithValue("@Unique_GIS_Number", GIS_Data.Check_T(unique_GIS_NumberTextBox)); 

                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show($"Запись успешно {status}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void Load_Data(DataTable dt)
        {
            comboBox10.DataSource = dt;
            comboBox10.ValueMember = "ID";
            comboBox10.DisplayMember = "Address";

            installation_DateDateTimePicker.Checked = false;
            operation_DateDateTimePicker.Checked = false;
            last_Check_DateDateTimePicker.Checked = false;
            plomb_PU_DateDateTimePicker.Checked = false;

            CB_Fill();
        }

        public void Load_Data_Edit(DataTable dt, int id_opy, string query_load)
        {

            comboBox10.DataSource = dt;
            comboBox10.ValueMember = "ID";
            comboBox10.DisplayMember = "Address";

            CB_Fill();

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query_load, connection);

                command.Parameters.AddWithValue("@ID", id_opy);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    comboBox10.SelectedValue = dr.GetValue(26);
                    serial_NumberTextBox.Text = dr.GetValue(0).ToString();
                    comboBox1.SelectedIndex = int.Parse(dr.GetValue(1).ToString());
                    mark_PYTextBox.Text = dr.GetValue(2).ToString();
                    model_PYTextBox.Text = dr.GetValue(3).ToString();
                    comboBox2.SelectedIndex = dr.GetValue(4).ToString() == "False" ? 0 : 1;
                    name_DIstance_PYTextBox.Text = dr.GetValue(5).ToString();
                    comboBox3.SelectedIndex = dr.GetValue(6).ToString() == "False" ? 0 : 1;
                    if (dr.GetValue(7).ToString() == "")
                        comboBox4.SelectedItem = null;
                    else comboBox4.SelectedIndex = int.Parse(dr.GetValue(7).ToString());
                    gIS_Number_PY_To_ConnectTextBox.Text = dr.GetValue(8).ToString();
                    comboBox5.SelectedIndex = int.Parse(dr.GetValue(9).ToString());
                    unit_Measurement_PYTextBox.Text = dr.GetValue(10).ToString();
                    if (dr.GetValue(11).ToString() == "")
                        comboBox6.SelectedItem = null;
                    else comboBox6.SelectedIndex = int.Parse(dr.GetValue(11).ToString());
                    t1TextBox.Text = dr.GetValue(12).ToString();
                    t2TextBox.Text = dr.GetValue(13).ToString();
                    t3TextBox.Text = dr.GetValue(14).ToString();
                    trans_CoefTextBox.Text = dr.GetValue(15).ToString();
                    if (dr.GetValue(16).ToString() == "")
                        installation_DateDateTimePicker.Checked = false;
                    else installation_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(16).ToString().Replace("-", "."));
                    operation_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(17).ToString().Replace("-", "."));
                    if (dr.GetValue(18).ToString() == "")
                        last_Check_DateDateTimePicker.Checked = false;
                    else last_Check_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(18).ToString().Replace("-", "."));
                    plomb_PU_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(19).ToString().Replace("-", "."));
                    comboBox7.SelectedIndex = dr.GetValue(20).ToString() == "False" ? 0 : 1;
                    temperature_Sensors_InfoTextBox.Text = dr.GetValue(21).ToString();
                    comboBox8.SelectedIndex = dr.GetValue(22).ToString() == "False" ? 0 : 1;
                    pressure_Sensors_InfoTextBox.Text = dr.GetValue(23).ToString();
                    comboBox9.SelectedIndex = dr.GetValue(24).ToString() == "False" ? 0 : 1;
                    unique_GIS_NumberTextBox.Text = dr.GetValue(25).ToString();

                    installation_DateDateTimePicker.Checked = true;
                    operation_DateDateTimePicker.Checked = true;
                    last_Check_DateDateTimePicker.Checked = true;
                    plomb_PU_DateDateTimePicker.Checked = true;
                }
                connection.Close();
            }
        }

        private void OPY_AF_Load(object sender, EventArgs e)
        {

        }

        private void CB_Fill()
        {
            string[] typePY = { "Индивидуальный", "Коллективный (общедомовой)", "Общий (квартирный)", "Комнатный" };
            string[] yesno = { "Да", "Нет" };
            string[] place = { "На входе/на подающем трубопроводе", "На входе/на подающем трубопроводе" };
            string[] typeKom = { "Холодная вода", "Горячая вода", "Электрическая энергия", "Газ", "Тепловая энергия", "Сточные бытовые воды" };
            string[] trafic = { "Однотарифный", "Двухтарифный", "Трехтарифный" };

            comboBox1.Items.AddRange(typePY);
            comboBox2.Items.AddRange(yesno);
            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(place);
            comboBox5.Items.AddRange(typeKom);
            comboBox6.Items.AddRange(trafic);
            comboBox7.Items.AddRange(yesno);
            comboBox8.Items.AddRange(yesno);
            comboBox9.Items.AddRange(yesno);            
        }
    }
}
