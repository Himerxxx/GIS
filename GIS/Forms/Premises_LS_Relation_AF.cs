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
    public partial class Premises_LS_Relation_AF : Form
    {
        public Premises_LS_Relation_AF()
        {
            InitializeComponent();
        }

        private void Premises_LS_Relation_AF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISDataSet.View_LS". При необходимости она может быть перемещена или удалена.
            this.view_LSTableAdapter.Fill(this.gISDataSet.View_LS);
            //this.premises_LS_RelationsTableAdapter.Fill(this.gISDataSet.Premises_LS_Relations);
            this.view_Address_PremisesTableAdapter.Fill(this.gISDataSet.View_Address_Premises);

            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) MessageBox.Show("Выберите ЛС");
            else if (comboBox2.SelectedValue == null) MessageBox.Show("Выберите Помещение");
            else
            {
                try
                {
                    string querySave = "INSERT INTO Premises_LS_Relations(ID_LS, ID_Premises) " +
                        $"VALUES({comboBox1.SelectedValue},{comboBox2.SelectedValue})";

                    using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querySave, connection);
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
    }
}
