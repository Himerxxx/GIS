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
                    string querySave = "INSERT INTO Metering_Devices(ID_MKD_Premises, l_idS, Serial_Number, Type_PY, Mark_PY, Model_PY, Is_Distance_Check, Distance_Check_Info," +
                        "Is_Many_PY_Used, Place_Location_PY, GIS_Number_PY_To_Connect, Type_Kommunal_Res, Unit_Measurement_PY, Type_PU_Number_Tariffs," +
                        "T1, T2, T3, Trans_Coef, Installation_Date, Operation_Date, Last_Check_Date, Plomb_PU_Date, Is_Temperature_Sensors, Temperature_Sensors_Info," +
                        "Is_Pressure_Sensors, Pressure_Sensors_Info, Is_AutomaticCalculation) " +
                        $"VALUES({comboBox1.SelectedValue}, {comboBox2.SelectedValue}, {serial_NumberTextBox.Text}, {comboBox3.SelectedIndex}," +
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
                        $"{GIS_Data.Check_C(comboBox11)})";

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
                    MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void Load_Data()
        {
            string query = "SELECT p.ID AS ID, a.Type_Street + ' ' + a.Street + ' ' + m.House_Number + N', кв. ' + p.Info AS 'Address' FROM MKD_Premises p " +
                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                "WHERE p.ID = @p_id";

            string query1 = "SELECT l.ID AS ID, o.SecondName + ' ' + o.FirstName + ' ' + o.LastName AS FIO FROM LS l " +
                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                "WHERE l.ID = @l_id";                

            using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                List<SqlParameter> prm = new List<SqlParameter>()
                {
                    new SqlParameter("@p_id",SqlDbType.Int) { Value = p_id},
                    new SqlParameter("@l_id",SqlDbType.Int) { Value = l_id}
                };
                cmd.Parameters.AddRange(prm.ToArray());
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cmd.CommandText = query1;
                da.SelectCommand = cmd;
                DataTable dt1 = new DataTable();
                da.Fill(dt1);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Address";

                comboBox2.DataSource = dt1;
                comboBox2.ValueMember = "ID";
                comboBox2.DisplayMember = "FIO";
            }
        }

        private void IPY_AF_Load(object sender, EventArgs e)
        {
            if (p_id > 0 && l_id > 0)
            {
                Load_Data();
            }
            else
            {
                this.view_LSTableAdapter.Fill(this.gISDataSet.View_LS);
                this.view_Address_PremisesTableAdapter.Fill(this.gISDataSet.View_Address_Premises);

                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
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
