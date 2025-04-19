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
    public partial class Premises_AF : Form
    {
        public int id;
        public Premises_AF()
        {
            InitializeComponent();
        }

        private void mKD_PremisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохрание данных в БД

            if (comboBox1.SelectedValue == null)
                MessageBox.Show("Выберите Адрес дома");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Помещение является жилым");
            else if (infoTextBox.Text == "")
                MessageBox.Show("Введите значение для поля: Информация о помещениии");
            else if (cadastral_NumberTextBox.Text == "")
                MessageBox.Show("Введите кадастровый номер помещения");
            else if (comboBox4.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Информация подтверждена поставщиком");
            else
            {
                try
                {
                    string querySave = "INSERT INTO MKD_Premises(ID_MKD_Address, Info,Is_Living, Premises_Description, Total_Area, Living_Total_Area, Is_Common, Cadastral_Number, Is_Confirmed_Supplier) " +
                        $"VALUES({comboBox1.SelectedValue}, {Check_TN(infoTextBox)},{comboBox2.SelectedIndex}, {Check_C(comboBox5)}, " +
                        $"{Check_TD(total_AreaTextBox)}, {Check_TD(living_Total_AreaTextBox)}, " +
                        $"{Check_C(comboBox3)}, {Check_TN(cadastral_NumberTextBox)}, {comboBox4.SelectedIndex})";

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

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Address";
            }
        }

        private void Premises_AF_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Load_Data();
            }
            else
            {
                this.view_Address_MKDTableAdapter.Fill(this.gISDataSet.View_Address_MKD);
                comboBox1.SelectedItem = null;
            }

            CB_Fill();
        }

        private void CB_Fill()
        {
            string[] yesno = { "Да", "Нет" };
            string[] description = { "Отдельная квартира", "Квартира коммунального заселения", "Общежитие" };

            comboBox2.Items.AddRange(yesno);
            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(description);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TD(TextBox e) => e.Text == "" ? "null" : e.Text.Replace(",", ".");

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : e.Value.ToShortDateString();
    }
}
