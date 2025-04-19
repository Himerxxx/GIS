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
    public partial class Premises_LS_Relation_Edit : Form
    {
        public Premises_LS_Relation_Edit()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void Premises_LS_Load_Data()
        {
            string queryLoad = "SELECT pl.ID_LS, pl.ID_Premises FROM Premises_LS_Relations pl " +
                "WHERE pl.ID_LS = @ID AND pl.ID_Premises = @secID";

            try
            {
                using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(queryLoad, connection);

                    List<SqlParameter> prm = new List<SqlParameter>()
                    {
                        new SqlParameter("@ID", SqlDbType.Int) {Value = GIS_Data.ID},
                        new SqlParameter("@secID", SqlDbType.Int) {Value = GIS_Data.secID}
                    };
                    cmd.Parameters.AddRange(prm.ToArray());

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBox1.SelectedValue = dr.GetValue(0);
                        comboBox2.SelectedValue = dr.GetValue(1);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool Check_Save()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Выберите ЛС");
                return false;
            }
            else if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Выберите Помещение");
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
                    string querySave = $"UPDATE Premises_LS_Relations SET ID_LS = {comboBox1.SelectedValue}, ID_Premises = {comboBox2.SelectedValue} " +
                        $"WHERE ID_LS = {GIS_Data.ID} AND ID_Premises = {GIS_Data.secID}";

                    using(SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(querySave, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Данные сохранены");
                }
                catch (Exception ex) { MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void Premises_LS_Relation_Edit_Load(object sender, EventArgs e)
        {
            this.view_Address_PremisesTableAdapter.Fill(this.gISDataSet.View_Address_Premises);
            this.view_LSTableAdapter.Fill(this.gISDataSet.View_LS);

            Premises_LS_Load_Data();
        }
    }
}
