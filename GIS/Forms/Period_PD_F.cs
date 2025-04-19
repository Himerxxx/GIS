using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIS.Forms
{
    public partial class Period_PD_F : Form
    {
        public Period_PD_F()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GIS_Data.Start_Date = $"{Date(dateTimePicker1)}";
            GIS_Data.End_Date = $"{Date(dateTimePicker2)}";
            MessageBox.Show($"{GIS_Data.Start_Date} {GIS_Data.End_Date}");
        }

        private string Date(DateTimePicker e)
        {
            string date = e.Value.ToShortDateString().Replace(".", "");
            return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);
        }

        private void Period_PD_F_Load(object sender, EventArgs e)
        {

        }
    }
}
