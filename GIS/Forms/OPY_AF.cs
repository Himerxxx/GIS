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
                    string querySave = "INSERT INTO General_Metering_Device(ID_MKD_Address, Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Name_DIstance_PY," +
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
                        $"{Check_C(comboBox9)})";

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querySave);
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    DialogResult result1 = MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void Load_Data()
        {
            string query = "SELECT m.ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address' FROM Characteristic_MKD m " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE m.ID = @ID";

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                comboBox10.DataSource = dt;
                comboBox10.ValueMember = "ID";
                comboBox10.DisplayMember = "Address";
            }
        }

        private void OPY_AF_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Load_Data();
            }
            else
            {
                this.view_Address_MKDTableAdapter.Fill(this.gISDataSet.View_Address_MKD);
                comboBox10.SelectedItem = null;
            }

            installation_DateDateTimePicker.Checked = false;
            operation_DateDateTimePicker.Checked = false;
            last_Check_DateDateTimePicker.Checked = false;
            plomb_PU_DateDateTimePicker.Checked = false;

            CB_Fill();
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
        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

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
