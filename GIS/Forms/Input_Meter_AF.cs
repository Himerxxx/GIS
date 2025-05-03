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
    public partial class Input_Meter_AF : Form
    {        
        public string save_query, status;
        public Input_Meter_AF()
        {
            InitializeComponent();
        }

        private void Input_Meter_AF_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM-yyyy";
            //dateTimePicker1.ShowUpDown = true;
        }


        public void Load_Data(DataTable dt)
        {

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";

            //CB_Fill();

            dateTimePicker1.Checked = false;

        }


    }
}
