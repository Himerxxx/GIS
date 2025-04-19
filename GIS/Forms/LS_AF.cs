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
    public partial class LS_AF : Form
    {
        public LS_AF()
        {
            InitializeComponent();
        }

        private void LS_AF_Load(object sender, EventArgs e)
        {
            this.view_OwnerTableAdapter.Fill(this.gISDataSet.View_Owner);
            this.view_Address_PremisesTableAdapter.Fill(this.gISDataSet.View_Address_Premises);

            comboBox6.SelectedItem = null;

            CB_Fill();

        }

        private void lSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных в БД

            if (comboBox6.SelectedValue == null)
                MessageBox.Show("Выберите значение для поля: Владелец ЛС");
            else if (comboBox2.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Тип ЛС");
            else if (comboBox5.SelectedItem == null)
                MessageBox.Show("Выберите значение для поля: Является открытым");
            else
            {
                try
                {
                    string querySave = "INSERT INTO LS(ID_Owner, Type_LS, Number_JKY, Is_Employer, Is_Splited, ShareOfPayment, Is_Open) " +
                        $"VALUES({comboBox6.SelectedValue},{comboBox2.SelectedIndex}, " +
                        $"{Check_TN(number_JKYTextBox)}, {Check_C(comboBox3)}, " +
                        $"{Check_C(comboBox4)}, {Check_T(shareOfPaymentTextBox)}, " +
                        $"{comboBox5.SelectedIndex})";

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querySave,connection);                        
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

        private void CB_Fill()
        {
            string[] type = { "ЛС УО", "ЛС РСО", "ЛС ОГВ/ОМС", "ЛС КР", "ЛС РЦ", "ЛС ТКО" };
            string[] yesno = { "Да", "Нет" };

            comboBox2.Items.AddRange(type);
            comboBox3.Items.AddRange(yesno);
            comboBox4.Items.AddRange(yesno);
            comboBox5.Items.AddRange(yesno);
        }

        private string Check_C(ComboBox e) => e.SelectedItem == null ? "null" : e.SelectedIndex.ToString();

        private string Check_T(TextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_TN(TextBox e) => e.Text == "" ? "null" : $"N'{e.Text}'";

        private string Check_M(MaskedTextBox e) => e.Text == "" ? "null" : e.Text;

        private string Check_D(DateTimePicker e) => e.Checked == false ? "null" : $"'{e.Value.ToShortDateString().Replace(".", "-")}'";

    }
}
