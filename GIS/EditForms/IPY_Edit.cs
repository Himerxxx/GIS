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

namespace GIS.EditForms
{
    public partial class IPY_Edit : Form
    {
        public int id;
        public IPY_Edit()
        {
            InitializeComponent();
        }

        private void IPY_Edit_Load(object sender, EventArgs e)
        {
            CB_Fill();
            IPY_Load_Data();
        }

        private void IPY_Load_Data()
        {
            string queryC1 = "SELECT p.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM MKD_Premises p " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN Address_Book a ON a.ID = m.ID_Address ";

            string queryC2 = "SELECT ID, ELS FROM LS";

            string queryLoad = "SELECT Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Distance_Check_Info, Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, " +
                "Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs, T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, " +
                "Is_Temperature_Sensors, Temperature_Sensors_Info, Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation, Unique_GIS_Number FROM Metering_Devices " +
                "WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryC1,connection);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt1);

                comboBox1.DataSource = dt1;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Address";

                cmd.CommandText = queryC2;
                da.SelectCommand = cmd;
                DataTable dt2 = new DataTable();

                da.Fill(dt2);

                comboBox2.DataSource = dt2;
                comboBox2.ValueMember = "ID";
                comboBox2.DisplayMember = "ELS";
            }

            using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(queryLoad, connection);
                cmd.Parameters.AddWithValue("ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    serial_NumberTextBox.Text = dr.GetValue(0).ToString();
                    comboBox3.SelectedIndex = int.Parse(dr.GetValue(1).ToString());
                    mark_PYTextBox.Text = dr.GetValue(2).ToString();
                    model_PYTextBox.Text = dr.GetValue(3).ToString();
                    comboBox4.SelectedIndex = dr.GetValue(4).ToString() == "False" ? 0 : 1;
                    distance_Check_InfoTextBox.Text = dr.GetValue(5).ToString();
                    comboBox5.SelectedIndex = dr.GetValue(6).ToString() == "False" ? 0 : 1;
                    if (dr.GetValue(7).ToString() == "")
                        comboBox6.SelectedItem = null;
                    else comboBox6.SelectedIndex = int.Parse(dr.GetValue(7).ToString());
                    gIS_Number_PY_To_ConnectTextBox.Text = dr.GetValue(8).ToString();
                    comboBox7.SelectedIndex = int.Parse(dr.GetValue(9).ToString());
                    unit_Measurement_PYTextBox.Text = dr.GetValue(10).ToString();
                    if (dr.GetValue(11).ToString() == "")
                        comboBox8.SelectedItem = null;
                    else comboBox8.SelectedIndex = int.Parse(dr.GetValue(11).ToString());
                    t1TextBox.Text = dr.GetValue(12).ToString();
                    t2TextBox.Text = dr.GetValue(13).ToString();
                    t3TextBox.Text = dr.GetValue(14).ToString();
                    trans_CoefTextBox.Text = dr.GetValue(15).ToString();
                    if (dr.GetValue(16).ToString() == "")
                        installation_DateDateTimePicker.Checked = false;
                    else installation_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(16).ToString().Replace("-", "."));
                    if (dr.GetValue(17).ToString() == "")
                        operation_DateDateTimePicker.Checked = false;
                    else operation_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(17).ToString().Replace("-", "."));
                    if (dr.GetValue(18).ToString() == "")
                        last_Check_DateDateTimePicker.Checked = false;
                    else last_Check_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(18).ToString().Replace("-", "."));
                    if (dr.GetValue(19).ToString() == "")
                        plomb_PU_DateDateTimePicker.Checked = false;
                    else plomb_PU_DateDateTimePicker.Value = DateTime.Parse(dr.GetValue(19).ToString().Replace("-", "."));
                    comboBox9.SelectedIndex = dr.GetValue(20).ToString() == "False" ? 0 : 1;
                    temperature_Sensors_InfoTextBox.Text = dr.GetValue(21).ToString();
                    comboBox10.SelectedIndex = dr.GetValue(22).ToString() == "False" ? 0 : 1;
                    pressure_Sensors_InfoTextBox.Text = dr.GetValue(23).ToString();
                    comboBox11.SelectedIndex = dr.GetValue(24).ToString() == "False" ? 0 : 1;
                    unique_GIS_NumberTextBox.Text = dr.GetValue(25).ToString();
                }
                connection.Close();
            }
        }

        private bool Check_Save()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Выберите Адрес поиещения");
                return false;
            }                
            else if (comboBox2.SelectedValue == null)
            { 
                MessageBox.Show("Выберите Номер ЛС");
                return false;
            }  
            else if (serial_NumberTextBox.Text == "")
            {
                MessageBox.Show("Введите Серийный номер ПУ");
                return false;
            }
            else if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Выберите Тип ПУ");
                return false;
            }
            else if (mark_PYTextBox.Text == "")
            {
                MessageBox.Show("Введите марку ПУ");
                return false;
            }
            else if (model_PYTextBox.Text == "")
            {
                MessageBox.Show("Введите модель ПУ");
                return false;
            }
            else if (comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Дистанционное снятие показаний");
                return false;
            }
            else if (comboBox5.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Объем ресурса(ов) определяется с помощью нескольких приборов учета");
                return false;
            }
            else if (comboBox7.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Вид коммунального ресурса");
                return false;
            }
            else if (comboBox9.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Наличие датчиков температуры");
                return false;
            }
            else if (comboBox10.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение для поля: Наличие датчиков давления");
                return false;
            }
            else return true;
        }

        private void Save_Edit()
        {
            if(Check_Save() == true)
            {
                try
                {
                    string querySave = $"UPDATE Metering_Devices SET ID_MKD_Premises = {comboBox1.SelectedValue}, ID_LS = {comboBox2.SelectedValue}, " +
                        $"Serial_Number = {serial_NumberTextBox.Text}, Type_PY = {comboBox3.SelectedIndex}," +
                        $"Mark_PY = {Check_TN(mark_PYTextBox)}, Model_PY = {Check_TN(model_PYTextBox)}, " +
                        $"Is_Distance_Check = {comboBox4.SelectedIndex}, Distance_Check_Info = {Check_TN(distance_Check_InfoTextBox)}," +
                        $"Is_Many_PY_Used = {Check_C(comboBox5)}, Place_Location_PY = {Check_C(comboBox6)}," +
                        $"GIS_Number_PY_To_Connect = {Check_T(gIS_Number_PY_To_ConnectTextBox)}, Type_Kommunal_Res = {comboBox7.SelectedIndex}," +
                        $"Unit_Measurement_PY = {Check_TN(unit_Measurement_PYTextBox)}, Type_PU_Number_Tariffs = {Check_C(comboBox8)}," +
                        $"T1 = {Check_TD(t1TextBox)}, T2 = {Check_TD(t2TextBox)}, T3 = {Check_TD(t3TextBox)}," +
                        $"Trans_Coef = {Check_TD(trans_CoefTextBox)}, Installation_Date = CONVERT(VARCHAR,{Check_D(installation_DateDateTimePicker)},103)," +
                        $"Operation_Date = CONVERT(VARCHAR,{Check_D(operation_DateDateTimePicker)},103)," +
                        $"Last_Check_Date = CONVERT(VARCHAR,{Check_D(last_Check_DateDateTimePicker)},103)," +
                        $"Plomb_PU_Date = CONVERT(VARCHAR,{Check_D(plomb_PU_DateDateTimePicker)},103)," +
                        $"Is_Temperature_Sensors = {comboBox9.SelectedIndex}, Temperature_Sensors_Info = {Check_TN(temperature_Sensors_InfoTextBox)}," +
                        $"Is_Pressure_Sensors = {comboBox10.SelectedIndex}, Pressure_Sensors_Info = {Check_TN(pressure_Sensors_InfoTextBox)}," +
                        $"Is_AutomaticCalculation = {Check_C(comboBox11)} " +
                        $"WHERE ID = {id}";

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(querySave, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Данные сохранены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void CB_Fill()
        {
            string[] typePY = { "Индивидуальный", "Коллективный (общедомовой)", "Общий (квартирный)", "Комнатный" };
            string[] yesno = { "Да", "Нет" };
            string[] place = { "На входе/на подающем трубопроводе", "На входе/на подающем трубопроводе" };
            string[] typeKom = { "Холодная вода", "Горячая вода", "Электрическая энергия", "Газ", "Тепловая энергия", "Сточные бытовые воды" };
            string[] trafic = { "Однотарифный", "Двухтарифный", "Трехтарифный" };

            comboBox3.Items.AddRange(typePY);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(yesno);
            comboBox6.Items.AddRange(place);
            comboBox7.Items.AddRange(typeKom);
            comboBox8.Items.AddRange(trafic);
            comboBox9.Items.AddRange(yesno);
            comboBox10.Items.AddRange(yesno);
            comboBox11.Items.AddRange(yesno);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_D(DateTimePicker e)
        {
            if (e.Checked == false) return "null";
            else
            {
                string date = e.Value.ToShortDateString().Replace(".", "");
                return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);
            }
        }

    }
}
