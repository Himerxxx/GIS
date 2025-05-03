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
    public partial class IPY_AF : Form
    {
        public int l_id, p_id;
        public string save_query, status;

        public IPY_AF()
        {
            InitializeComponent();
        }

        private void metering_DevicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохрание данных в БД

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите Адрес помещения");
            else if (comboBox2.SelectedValue == null)
                MessageBox.Show("Выберите Номер ЛС");
            else if (serial_NumberTextBox.Text == "")
                MessageBox.Show("Введите Серийный номер ПУ");
            else if (comboBox3.SelectedItem == null)
                MessageBox.Show("Выберите Тип ПУ");
            else if (mark_PYTextBox.Text == "")
                MessageBox.Show("Введите марку ПУ");
            else if (model_PYTextBox.Text == "")
                MessageBox.Show("Введите модель ПУ");
            else if (comboBox4.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Дистанционное снятие показаний");
            else if (comboBox5.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Объем ресурса(ов) определяется с помощью нескольких приборов учета");
            else if (comboBox7.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Вид коммунального ресурса");
            else if (comboBox9.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Наличие датчиков температуры");
            else if (comboBox10.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Наличие датчиков давления");
            else
            {
                try
                {
                    

                    /*$"VALUES({comboBox1.SelectedValue}, {comboBox2.SelectedValue}, {serial_NumberTextBox.Text}, {comboBox3.SelectedIndex}," +
                    $"{GIS_Data.Check_TN(mark_PYTextBox)}, {GIS_Data.Check_TN(model_PYTextBox)}, {comboBox4.SelectedIndex}, {GIS_Data.Check_T(distance_Check_InfoTextBox)}," +
                    $"{GIS_Data.Check_C(comboBox5)}, {GIS_Data.Check_C(comboBox6)}," +
                    $"{GIS_Data.Check_T(gIS_Number_PY_To_ConnectTextBox)}, {comboBox7.SelectedIndex}," +
                    $"{GIS_Data.Check_TN(unit_Measurement_PYTextBox)}, {GIS_Data.Check_C(comboBox8)}," +
                    $"{GIS_Data.Check_TD(t1TextBox)}, {GIS_Data.Check_TD(t2TextBox)}, {GIS_Data.Check_TD(t3TextBox)}," +
                    $"{GIS_Data.Check_TD(trans_CoefTextBox)}, CONVERT(VARCHAR,{GIS_Data.Check_D(installation_DateDateTimePicker)},103)," +
                    $"CONVERT(VARCHAR,{GIS_Data.Check_D(operation_DateDateTimePicker)},103)," +
                    $"CONVERT(VARCHAR,{GIS_Data.Check_D(last_Check_DateDateTimePicker)},103)," +
                    $"CONVERT(VARCHAR,{GIS_Data.Check_D(plomb_PU_DateDateTimePicker)},103)," +
                    $"{comboBox9.SelectedIndex}, {GIS_Data.Check_TN(temperature_Sensors_InfoTextBox)}," +
                    $"{comboBox10.SelectedIndex}, {GIS_Data.Check_TN(pressure_Sensors_InfoTextBox)}," +
                    $"{GIS_Data.Check_C(comboBox11)})";*/


                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(save_query);

                        command.Parameters.AddWithValue("@ID_MKD_Premises", comboBox1.SelectedValue);
                        command.Parameters.AddWithValue("@ID_LS", comboBox2.SelectedValue);
                        command.Parameters.AddWithValue("@Serial_Number", serial_NumberTextBox.Text);
                        command.Parameters.AddWithValue("@Type_PY", comboBox3.SelectedIndex);
                        command.Parameters.AddWithValue("@Mark_PY", GIS_Data.Check_T(mark_PYTextBox));
                        command.Parameters.AddWithValue("@Model_PY", GIS_Data.Check_T(model_PYTextBox));
                        command.Parameters.AddWithValue("@Is_Distance_Check", comboBox4.SelectedIndex);
                        command.Parameters.AddWithValue("@Distance_Check_Info", GIS_Data.Check_T(distance_Check_InfoTextBox));
                        command.Parameters.AddWithValue("@Is_Many_PY_Used", GIS_Data.Check_C(comboBox5));
                        command.Parameters.AddWithValue("@Place_Location_PY", GIS_Data.Check_C(comboBox6));
                        command.Parameters.AddWithValue("@GIS_Number_PY_To_Connect", GIS_Data.Check_T(gIS_Number_PY_To_ConnectTextBox));
                        command.Parameters.AddWithValue("@Type_Kommunal_Res", comboBox7.SelectedIndex);
                        command.Parameters.AddWithValue("@Unit_Measurement_PY", GIS_Data.Check_T(unit_Measurement_PYTextBox));
                        command.Parameters.AddWithValue("@Type_PU_Number_Tariffs", GIS_Data.Check_C(comboBox8));
                        command.Parameters.AddWithValue("@T1", GIS_Data.Check_TD(t1TextBox));
                        command.Parameters.AddWithValue("@T2", GIS_Data.Check_TD(t2TextBox));
                        command.Parameters.AddWithValue("@T3", GIS_Data.Check_TD(t3TextBox));
                        command.Parameters.AddWithValue("@Trans_Coef", GIS_Data.Check_TD(trans_CoefTextBox));
                        command.Parameters.AddWithValue("@Installation_Date", GIS_Data.Check_D(installation_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Operation_Date", GIS_Data.Check_D(operation_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Last_Check_Date", GIS_Data.Check_D(last_Check_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Plomb_PU_Date", GIS_Data.Check_D(plomb_PU_DateDateTimePicker));
                        command.Parameters.AddWithValue("@Is_Temperature_Sensors", comboBox9.SelectedIndex);
                        command.Parameters.AddWithValue("@Temperature_Sensors_Info", GIS_Data.Check_T(temperature_Sensors_InfoTextBox));
                        command.Parameters.AddWithValue("@Is_Pressure_Sensors", comboBox10.SelectedIndex);
                        command.Parameters.AddWithValue("@Pressure_Sensors_Info", GIS_Data.Check_T(pressure_Sensors_InfoTextBox));
                        command.Parameters.AddWithValue("@Is_AutomaticCalculation", GIS_Data.Check_C(comboBox11));                        
                        

                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show($"Запись успешно {status}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Load_Data(List<DataTable> dataTables)
        {

            comboBox1.DataSource = dataTables[0];
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";

            comboBox2.DataSource = dataTables[1];
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "FIO";

            CB_Fill();

            installation_DateDateTimePicker.Checked = false;
            operation_DateDateTimePicker.Checked = false;
            last_Check_DateDateTimePicker.Checked = false;
            plomb_PU_DateDateTimePicker.Checked = false;

        }

        public void Load_Data_Edit(List<DataTable> dataTables, int id_ipy, string query_load)
        {

            comboBox1.DataSource = dataTables[0];
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";

            comboBox2.DataSource = dataTables[1];
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "FIO";

            CB_Fill();

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query_load, connection);

                command.Parameters.AddWithValue("@ID", id_ipy);
                SqlDataReader dr = command.ExecuteReader();

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

                    installation_DateDateTimePicker.Checked = true;
                    operation_DateDateTimePicker.Checked = true;
                    last_Check_DateDateTimePicker.Checked = true;
                    plomb_PU_DateDateTimePicker.Checked = true;
                }
                connection.Close();
            }
        }

        private void IPY_AF_Load(object sender, EventArgs e)
        {
            /*if (p_id > 0 && l_id > 0)
            {
                //Load_Data();
            }
            else
            {
                //this.view_LSTableAdapter.Fill(this.gISDataSet.View_LS);
                //this.view_Address_PremisesTableAdapter.Fill(this.gISDataSet.View_Address_Premises);

                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
            }*/



            
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
    }
}
