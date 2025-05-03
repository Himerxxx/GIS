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
using GIS.Forms;
using GIS.EditForms;

namespace GIS.UC
{
    public partial class Owner_LS_UC : UserControl
    {
        string query_load = "SELECT ID, SecondName + ' ' + FirstName + ' ' + LastName AS 'ФИО', SNILS AS 'СНИЛС', " +
           "Passport_Type AS 'Документ удостоверяющий личность', Passport_Series + ' ' + Passport_Number AS 'Серия номер', Passport_Date AS 'Дата получения ДУЛ', OGRN AS 'ОГРН', NZA AS 'НЗА', KPP AS 'КПП' " +
           "FROM Owner_LS " +
           "ORDER BY SecondName";
        int id_owner;
        string owner_name;
        public Owner_LS_UC()
        {
            InitializeComponent();
        }

        private void Owner_LS_UC_Load(object sender, EventArgs e)
        {
            GIS_Data.SQLFill(query_load, dataGridView1);

            splitContainer1.Size = new Size(1233, 394);
            
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.SplitterDistance = 229;

            button1.Location = new Point(15, 53);
            button1.Font = new Font("Times New Roman", 12);
            button1.BackColor = Color.FromName("InactiveCaption");
            button1.Size = new Size(199, 35);

            button2.Location = new Point(15, 98);
            button2.Font = new Font("Times New Roman", 12);
            button2.BackColor = Color.FromName("InactiveCaption");
            button2.Size = new Size(199, 35);

            button3.Location = new Point(15, 143);
            button3.Font = new Font("Times New Roman", 12);
            button3.BackColor = Color.FromName("InactiveCaption");
            button3.Size = new Size(199, 35);

            button4.Location = new Point(189, 311);
            button4.BackColor = Color.FromName("Menu");
            button4.Size = new Size(25, 25);

            button5.Location = new Point(15, 337);
            button5.Font = new Font("Times New Roman", 12);
            button5.BackColor = Color.FromName("InactiveCaption");
            button5.Size = new Size(199, 35);

            textBox1.Multiline = true;
            textBox1.Size = new Size(170, 25);
            textBox1.Location = new Point(16, 311);

            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Size = new Size(967, 336);

            dataGridView1.Columns[0].Visible = false;
        }



        private void Add_Click(object sender, EventArgs e)
        {
            Add_Func();
        }

        public void Add_Func()
        {
            var owners = new Owners_AF() { Text = $"Добавление нового владельца." };
            owners.Load_Data();
            owners.save_query = "INSERT INTO Owner_LS(FirstName, SecondName, LastName, SNILS, Passport_Type, " +
                        "Passport_Series, Passport_Number, Passport_Date) " +
                        $"VALUES(@FirstName, @SecondName, @LastName, " +
                        $"@SNILS, @Passport_Type, " +
                        $"@Passport_Series, @Passport_Number, CONVERT(VARCHAR,@Passport_Date,103))";
            owners.status = "добавлена";
            owners.owner_LSBindingNavigatorSaveItem.Text = "Сохранить данные";
            DialogResult result = owners.ShowDialog();
            if (result == DialogResult.Cancel)
                GIS_Data.SQLFill(query_load, dataGridView1);        
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string query_load_edit = "SELECT FirstName, SecondName, LastName, SNILS, Passport_Type, Passport_Series, " +
                "Passport_Number, Passport_Date, OGRN, NZA, KPP FROM Owner_LS o " +
                $"WHERE o.ID = {id_owner}";

            if (id_owner > -1)
            {
                var owners = new Owners_AF() { Text = $"Изменение данных владельца: {owner_name}." };

                owners.Load_Data_Edit(id_owner, query_load_edit);
                owners.save_query = $"UPDATE Owner_LS SET FirstName = @FirstName, " +
                    $"SecondName = @SecondName, LastName = @LastName, " +
                    $"SNILS = @SNILS, Passport_Type = @Passport_Type, Passport_Series = @Passport_Series, " +
                    $"Passport_Number = @Passport_Number, Passport_Date = @Passport_Date, " +
                    $"OGRN = @OGRN, NZA = @NZA, KPP = @KPP " +
                    $"WHERE ID = {id_owner}";
                owners.status = "изменена";
                owners.owner_LSBindingNavigatorSaveItem.Text = "Изменить данные";

                DialogResult result = owners.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    GIS_Data.SQLFill(query_load, dataGridView1);
                    id_owner = -1;
                }
            }
            else MessageBox.Show("Укажите запись из таблицы для изменения");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_owner = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                owner_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                id_owner = -1;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE Owner_LS WHERE ID = @ID";
            if (GIS_Data.RemoveClickTemp(id_owner, queryDelete, false, $"Удалить данные владельца: {owner_name}?") == true) GIS_Data.SQLFill(query_load, dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GIS_Data.Search(textBox1, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GIS_Data.SQLFill(query_load, dataGridView1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GIS_Data.SearchBind(textBox1, dataGridView1, query_load, e);
        }
    }
}
