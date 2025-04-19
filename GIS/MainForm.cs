using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIS.UC;
using GIS.Forms;
using System.IO;
using System.Data.SqlClient;

namespace GIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void мКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new MKD_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void подъездыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new EntranceUC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void помещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new PremisesUC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void лицевойСчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new LS_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void владельцыЛСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new Owner_LS_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void иПУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new IPY_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void оПУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new OPY_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void пДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new PD_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new Services_PD_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void судебныеНеустойкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new Penalties_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void лСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new Premises_LS_Relation_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void сформироватьПДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIS_Data.ID = 0;
            var uc = new PD_Dox_UC();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(uc);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                this.Close();
                this.Dispose();
            } 
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Spravka_F();
            form.Show();
        }

        private void свернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sFileName = "";

            OpenFileDialog fd = new OpenFileDialog();
            //fd.Filter = "Office Files|*.xlsx;";
            //fd.FilterIndex = 1;


            if (fd.ShowDialog() == DialogResult.OK)
            {
                sFileName = fd.FileName;
                string address = "";
                List<string> addressList = new List<string>();                

                using(StreamReader sr = new StreamReader(sFileName))
                {
                    address = sr.ReadLine();
                }

                foreach(var i in address.Split('/'))
                {
                    addressList.Add(i);
                }

                /*string query = "INSERT INTO Characteristic_MKD(ID_Address, House_Number, ID_FIAS, OKTMO, Statys, Life_Cycle_Stage, " +
                "Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, Olson, Is_Cultural_Legacy, " +
                "Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R) " +
                "VALUES(0,1,'2','3',4,5,6,'7','8',9,10,11,'12','13','14','15','16')";*/

                using (SqlConnection connection = new SqlConnection(GIS_Data.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    foreach(var i in addressList)
                    {
                        string[] street = i.Split('|');                        
                        cmd.CommandText = "INSERT INTO Characteristic_MKD(ID_Address, House_Number, ID_FIAS, OKTMO, Statys, Life_Cycle_Stage, " +
                "Total_Building_Area, Year_Of_Commissioning, Count_floors, Count_Underfloors, Olson, Is_Cultural_Legacy, " +
                "Cadastral_Number, Payment_Account_S, BIK_S, Payment_Account_R, BIK_R) " +
                $"VALUES({street[0]},{street[1]},'{street[2]}','{street[3]}',{street[4]},{street[5]},{street[6]},'{street[7]}','{street[8]}',{street[9]}," +
                $"{street[10]},{street[11]},'{street[12]}','{street[13]}','{street[14]}','{street[15]}','{street[16]}')";
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
        }
    }
}
