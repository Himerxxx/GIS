using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace GIS
{
    static class GIS_Data
    {
        public static int ID;
        public static int secID;
        public static string HouseName;

        public static int MKD_ID;
        public static int Entrance_ID = -1;
        //public static int Premises_ID;
        public static int OPY_ID;

        public static int PD_ID;
        //public static int LS_ID;

        public static string Start_Date;
        public static string End_Date;

        public static string Check_C(ComboBox e) => e.SelectedItem == null ? "" : e.SelectedIndex.ToString();

        public static string Check_T(TextBox e) => e.Text == "" ? "" : e.Text;

        public static string Check_M(MaskedTextBox e) => e.Text == "" ? "" : e.Text;

        public static object Check_TD(TextBox e) => e.Text == "" ? "0" : e.Text.Replace(",", ".");
        public static object Check_String_D(string e) => e == "" ? "0" : e.Replace(",", ".");
        public static string Check_D(DateTimePicker e)
        {
            if (e.Checked == false) return "null";
            else
            {
                string date = e.Value.ToShortDateString().Replace(".", "");
                return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);
            }
        }
        /*public static string Check_String_D(string e)
        {

            string date = e.Replace(".", "");
            return date.Substring(4) + date.Substring(2, 2) + date.Substring(0, 2);

        }*/
        public static string Check_TN(TextBox e) => e.Text == "" ? "" : $"N'{e.Text.Trim()}'";


        //SQL запрос для заполнения DataGridView
        public static void SQLFill(string query, DataGridView dataGrid)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    dataGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Шаблон кнопки редактирования

        //Шаблон кнопки удаления
        public static bool RemoveClickTemp(int class_id, string queryDelete, bool flag, string message)
        {
            if (class_id > 0)
            {
                DialogResult result = MessageBox.Show(message, "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(queryDelete, connection);
                            if (flag == false)
                            {
                                cmd.Parameters.AddWithValue("@ID", class_id);
                            }
                            else
                            {
                                List<SqlParameter> prm = new List<SqlParameter>()
                                {
                                    new SqlParameter("@ID", SqlDbType.Int) {Value = ID},
                                    new SqlParameter("@secID", SqlDbType.Int) {Value = secID}
                                };
                                cmd.Parameters.AddRange(prm.ToArray());
                            }
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Запись успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    class_id = 0;
                    return true;
                }
                else return false;
            }
            else
            {
                MessageBox.Show("Запись для удаления не указана!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //Метод для поиска данных в таблицах DataGridView
        public static void Search(TextBox TB, DataGridView dataGV)
        {
            string searchValue = TB.Text;

            for (int i = 0; i < dataGV.RowCount; i++)
            {
                for (int j = 0; j < dataGV.ColumnCount; j++)
                {
                    dataGV[j, i].Style.BackColor = Color.White;
                    dataGV[j, i].Style.ForeColor = Color.Black;
                }
            }
            List<int> index = new List<int>();
            int count = 0;

            for (int i = 0; i < dataGV.RowCount; i++)
            {
                for (int j = 1; j < dataGV.ColumnCount; j++)
                {
                    if (dataGV[j, i].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        dataGV[j, i].Style.BackColor = Color.AliceBlue;
                        dataGV[j, i].Style.ForeColor = Color.Blue;

                        count++;
                    }
                }
                if (count == 0) index.Add(i);
                count = 0;
            }
            index.Reverse();
            if (index.Count != 0)
            {
                foreach (var i in index)
                {
                    dataGV.Rows.RemoveAt(i);
                }
            }
        }

        //Метод для задания горячих клавиш поиска
        //(Ctrl + R - Reload, Enter - Search)
        public static void SearchBind(TextBox TB, DataGridView dataGV, string query, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(TB, dataGV);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                SQLFill(query, dataGV);
                e.SuppressKeyPress = true;
            }
        }
        //Создание шаблона для подачи показаний счетчиков за месяц
        public static void Template_Meter_Housemain_Create()
        {
            List<string> streets = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Type_Street + ' ' + Street FROM Address_Book ORDER BY Type_Street + ' ' + Street", connection);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    streets.Add(dr.GetString(0));
                }
                connection.Close();
            }

            string sFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Template_Meter_Housemain.xlsx");

            string newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string.Format("Документ подачи показаний счетчиков за {0}.xlsx", DateTime.Now.ToShortDateString().Remove(0, 3)));

            File.Copy(sFileName, newPath);

            try
            {
                string sheetName_1 = "Информация о доме";
                string sheetName_3 = "Вспомогательная информация";

                using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                {

                    if (helper.Open(filePath: newPath))
                    {
                        helper.Set(sheetName_1, 1, 2, helper.Get(sheetName_1, 1, 2).ToString().Replace("{City}", "Рубцовск"));

                        for (int i = 1; i < 13; i++)
                        {
                            string date = $"0{i}-{DateTime.Now.Year}";
                            helper.Set(sheetName_3, 1, i, date.Count() == 7 ? date : date.Remove(0, 1));
                        }
                        int j = 1;
                        foreach (var street in streets)
                        {
                            helper.Set(sheetName_3, 2, j, street);
                            j++;
                        }
                    }

                    helper.Save();

                    helper.Dispose();
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //Метод считывания показаний ИПУ и внесение данных в БД
        public static async Task Input_Meter_From_Document()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    await Task.Run(() =>
                    {
                        Read_Document_Meters(folderBrowserDialog.SelectedPath);
                    });
                }
                else
                {
                    MessageBox.Show("Выбор папки отменен.");
                }
            }
        }

        private static void Read_Document_Meters(string folder_path)
        {
            string selectedFolder = folder_path;
            List<string> excelFiles = GetExcelFiles(selectedFolder);
            int max_value = excelFiles.Count;
            Form progressForm = new Form() { Text = $"Загрузка данных", Size = new Size(300, 150), StartPosition = FormStartPosition.CenterScreen };

            ProgressBar progress_bar = new ProgressBar() { Size = new Size(275, 40), Location = new Point(5, 50), Minimum = 0, Maximum = max_value, Value = 0 };
            Label progress_text = new Label() { Text = $"Загрузка файлов... ", Location = new Point(5, 5), Size = new Size(250, 30) };

            progressForm.Controls.Add(progress_bar);
            progressForm.Controls.Add(progress_text);
            
            progressForm.Show();

            int fileCounter = 0;  //Счетчик обработанных файлов
            int uploadFileCounter = 0;
            progress_text.Text = $"Загрузка файлов {fileCounter} из {max_value}";
            string sheetName_1 = "Информация о доме";
            string sheetName_2 = "Показания";

            try
            {
                foreach (string filePath in excelFiles)
                {
                    string house_name = "", house_number = "", date = "";

                    List<string[]> meters = new List<string[]>();

                    using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                    {
                        try
                        {
                            if (helper.Open(filePath))
                            {
                                house_name = helper.Get(sheetName_1, 4, 2).ToString();      //определение выбранного адреса дома
                                house_number = helper.Get(sheetName_1, 7, 2).ToString();    //определение номера дома
                                date = helper.Get(sheetName_1, 4, 3).ToString();             //определение выбранной даты                    

                                int i = 2;

                                while (helper.Get(sheetName_2, 1, i) != null)
                                {
                                    string[] row_meters = new string[6];
                                    for (int j = 1; j < 7; j++)
                                    {
                                        row_meters[j - 1] = helper.Get(sheetName_2, j, i) == null ? "0" : helper.Get(sheetName_2, j, i).ToString();

                                        if (j == 6)
                                        {
                                            meters.Add(row_meters);
                                            i++;
                                        }
                                    }
                                }
                            }
                            helper.Save();
                            helper.Dispose();
                        }
                        catch
                        {
                            fileCounter++;
                            progress_text.Text = $"Загрузка файлов {fileCounter} из {max_value}";
                            progress_bar.Value = fileCounter;                            
                            continue; 
                        }

                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (var meter in meters)
                        {
                            string query_save_from_document =
                                "DECLARE @ID_Premises Int " +
                                "SELECT @ID_Premises = p.ID " +
                                "FROM MKD_Premises p " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                                "WHERE UPPER(LTRIM(RTRIM(a.Street))) = UPPER(LTRIM(RTRIM(@Address))) " +
                                "AND m.House_Number = @House_Number " +
                                "AND p.Info = @Flat_Number " +
                                "INSERT INTO Input_meter_readings(ID_Premises, Month_of_metering, Cold_water, Hot_water, Electic_energy, Heating) " +
                                "VALUES (@ID_Premises, @Month_of_metering, @Cold_water, @Hot_water, @Electic_energy, @Heating) ";

                            SqlCommand command = new SqlCommand(query_save_from_document, connection);

                            command.Parameters.AddWithValue("@Flat_Number", meter[0]);
                            command.Parameters.AddWithValue("@Address", house_name.Split(' ')[1]);
                            command.Parameters.AddWithValue("@House_Number", house_number);
                            command.Parameters.Add("@Month_of_metering", SqlDbType.Date).Value = date;
                            command.Parameters.AddWithValue("@Cold_water", Check_String_D(meter[2]));
                            command.Parameters.AddWithValue("@Hot_water", Check_String_D(meter[3]));
                            command.Parameters.AddWithValue("@Electic_energy", Check_String_D(meter[4]));
                            command.Parameters.AddWithValue("@Heating", Check_String_D(meter[5]));

                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                    fileCounter++;
                    uploadFileCounter++;
                    progress_text.Text = $"Загрузка файлов {fileCounter} из {max_value}";
                    progress_bar.Value = fileCounter; 
                    Application.DoEvents();         // Даем UI потоку возможность обновиться                    
                }
                progressForm.Close(); //Закрываем форму ProgressBar после завершения
                MessageBox.Show($"Загружено файлов {uploadFileCounter} из {max_value}");
            }
            catch { }


        }

        private static List<string> GetExcelFiles(string folderPath)
        {
            List<string> excelFiles = new List<string>();
            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.xlsx", SearchOption.TopDirectoryOnly); // Только в текущей папке

                excelFiles.AddRange(files);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении списка файлов: {ex.Message}");
            }
            return excelFiles;
        }
        //Метод отображения прогресса загрузки данных
        public static async void ProgressForm(int progress_bar_max_value)
        {
            var progress_form = new Form() { Text = $"Загрузка данных", Size = new Size(300, 150), StartPosition = FormStartPosition.CenterScreen };
            ProgressBar progress_bar = new ProgressBar() { Size = new Size(275, 40), Location = new Point(5, 50), Maximum = progress_bar_max_value, Value = 0 };
            Label progress_text = new Label() { Text = $"Загрузка файлов... ", Location = new Point(5, 5), Size = new Size(250, 30) };
            progress_form.Controls.Add(progress_bar);
            progress_form.Controls.Add(progress_text);
            progress_form.Show();

            await Test_Async(1, progress_bar_max_value, progress_bar, progress_text);
            await Test_Async(2, progress_bar_max_value, progress_bar, progress_text);
            await Test_Async(3, progress_bar_max_value, progress_bar, progress_text);
            await Test_Async(4, progress_bar_max_value, progress_bar, progress_text);
            /*progress_text.Text = await Test_Async(1);
            progress_bar.Value = 1;
            
            progress_text.Text = await Test_Async(2);
            progress_bar.Value = 2;
           
            progress_text.Text = await Test_Async(3);
            progress_bar.Value = 3;*/


        }
        private static async Task Test_Async(int i, int max,ProgressBar progress_bar, Label label)
        {
            await Task.Delay(2000);
            progress_bar.Value = i;
            label.Text = $"Загрузка файлов {i} из {max}";
            
            //return $"Загрузка файлов {i} из 4";
        }


        //Метод заполнения шаблона о МКД
        public static void MKD_Dox_Fill(List<int> id)
        {
            string sFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Шаблон импорта сведений о МКД-УО-13.0.1.1.xlsx");

            string newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Шаблон импорта сведений о МКД-УО.xlsx");

            File.Copy(sFileName, newPath);

            if (sFileName.Contains("Шаблон импорта сведений о МКД-УО") == true)
            {
                foreach (var j in id)
                {
                    try
                    {
                        string sheetName_living = "Жилые помещения";
                        string sheetName_unliving = "Нежилые помещения";
                        string sheetName_mkd = "Характеристики МКД";
                        string sheetName_entrance = "Подъезды";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(DoxFill_MKD_premises, connection);
                            cmd.Parameters.AddWithValue("@ID", j);

                            SqlDataReader dr = cmd.ExecuteReader();

                            using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                            {
                                if (helper.Open(filePath: newPath))
                                {
                                    while (dr.Read())
                                    {
                                        if (dr.GetValue(0).ToString() == "False")
                                        {
                                            int i = 3;

                                            while (helper.Get(sheetName_living, 2, i) != null)
                                            {
                                                i++;
                                            }
                                            helper.Set(sheetName_living, 1, i, dr.GetValue(1).ToString());
                                            helper.Set(sheetName_living, 2, i, dr.GetValue(2).ToString());
                                            helper.Set(sheetName_living, 4, i, dr.GetValue(3).ToString());
                                            helper.Set(sheetName_living, 5, i, dr.GetValue(5).ToString());
                                            helper.Set(sheetName_living, 6, i, dr.GetValue(4).ToString());
                                            helper.Set(sheetName_living, 7, i, dr.GetValue(7).ToString());
                                            helper.Set(sheetName_living, 8, i, dr.GetValue(8).ToString() == "False" ? "Да" : "Нет");
                                        }
                                        else
                                        {
                                            int i = 3;
                                            while (helper.Get(sheetName_unliving, 2, i) != null)
                                            {
                                                i++;
                                            }
                                            helper.Set(sheetName_unliving, 1, i, dr.GetValue(1).ToString());
                                            helper.Set(sheetName_unliving, 2, i, dr.GetValue(2).ToString());
                                            helper.Set(sheetName_unliving, 3, i, dr.GetValue(6).ToString() == "False" ? "Да" : "Нет");
                                            helper.Set(sheetName_unliving, 4, i, dr.GetValue(4).ToString());
                                            helper.Set(sheetName_unliving, 5, i, dr.GetValue(7).ToString());
                                            helper.Set(sheetName_unliving, 6, i, dr.GetValue(8).ToString() == "False" ? "Да" : "Нет");
                                        }
                                    }
                                    dr.Close();

                                    cmd.CommandText = DoxFill_MKD_mkd;

                                    dr = cmd.ExecuteReader();

                                    while (dr.Read())
                                    {
                                        int i = 3;

                                        while (helper.Get(sheetName_mkd, 1, i) != null)
                                        {
                                            i++;
                                        }
                                        helper.Set(sheetName_mkd, 1, i, dr.GetValue(0).ToString());
                                        helper.Set(sheetName_mkd, 2, i, dr.GetValue(1).ToString());
                                        helper.Set(sheetName_mkd, 3, i, dr.GetValue(2).ToString());
                                        helper.Set(sheetName_mkd, 4, i, dr.GetValue(3).ToString());
                                        helper.Set(sheetName_mkd, 5, i, dr.GetValue(4).ToString());
                                        helper.Set(sheetName_mkd, 6, i, dr.GetValue(5).ToString());
                                        helper.Set(sheetName_mkd, 7, i, dr.GetValue(6).ToString());
                                        helper.Set(sheetName_mkd, 8, i, dr.GetValue(7).ToString());
                                        helper.Set(sheetName_mkd, 9, i, dr.GetValue(8).ToString());
                                        helper.Set(sheetName_mkd, 10, i, dr.GetValue(9).ToString());
                                        helper.Set(sheetName_mkd, 11, i, dr.GetValue(10).ToString() == "False" ? "Да" : "Нет");
                                        helper.Set(sheetName_mkd, 12, i, dr.GetValue(11).ToString());
                                    }

                                    dr.Close();

                                    cmd.CommandText = DoxFill_MKD_entrance;

                                    dr = cmd.ExecuteReader();

                                    while (dr.Read())
                                    {
                                        int i = 3;

                                        while (helper.Get(sheetName_entrance, 1, i) != null)
                                        {
                                            i++;
                                        }
                                        helper.Set(sheetName_entrance, 1, i, dr.GetValue(0).ToString());
                                        helper.Set(sheetName_entrance, 2, i, dr.GetValue(1).ToString());
                                        helper.Set(sheetName_entrance, 3, i, dr.GetValue(2).ToString());
                                        helper.Set(sheetName_entrance, 4, i, dr.GetValue(3).ToString());
                                        helper.Set(sheetName_entrance, 5, i, dr.GetValue(4).ToString() == "False" ? "Да" : "Нет");
                                    }

                                    helper.Save();

                                    helper.Dispose();
                                }
                            }
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }

                }
            }
            else MessageBox.Show("Выбран не верный файл! \nВыберите файл: Шаблон импорта сведений о МКД-УО", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Метод заполнения шаблона о ЛС
        public static void LS_Dox_Fill(List<int[]> id)
        {
            string sFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Шаблон импорта ЛС-11.13.0.5.xlsx");

            string newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Шаблон импорта ЛС.xlsx");

            File.Copy(sFileName, newPath);

            if (sFileName.Contains("Шаблон импорта ЛС") == true)
            {
                foreach (var j in id)
                {
                    try
                    {
                        string sheetName_info = "Основные сведения";
                        string sheetName_premises = "Помещения";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(DoxFill_LS_info, connection);

                            List<SqlParameter> prm = new List<SqlParameter>()
                        {
                            new SqlParameter("@ID", SqlDbType.Int) {Value = j[0]},
                            new SqlParameter("@secID", SqlDbType.Int) {Value = j[1]}
                        };

                            cmd.Parameters.AddRange(prm.ToArray());

                            SqlDataReader dr = cmd.ExecuteReader();

                            using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                            {
                                if (helper.Open(filePath: newPath))
                                {
                                    while (dr.Read())
                                    {
                                        int i = 3;

                                        while (helper.Get(sheetName_info, 2, i) != null)
                                        {
                                            i++;
                                        }
                                        helper.Set(sheetName_info, 1, i, $"{i - 2}");//Номер записи
                                        helper.Set(sheetName_info, 2, i, dr.GetValue(0).ToString());//ID ЛС
                                        helper.Set(sheetName_info, 3, i, dr.GetValue(1).ToString());//Идентификатор ЖКУ
                                        helper.Set(sheetName_info, 4, i, dr.GetValue(2).ToString());//Тип лицевого счета С
                                        helper.Set(sheetName_info, 5, i, dr.GetValue(3).ToString() == "False" ? "Да" : "Нет");//Является нанимателем?
                                        helper.Set(sheetName_info, 6, i, dr.GetValue(4).ToString() == "False" ? "Да" : "Нет");//Лицевые счета на помещение(я) разделены?
                                        helper.Set(sheetName_info, 7, i, dr.GetValue(5).ToString()); //Фамилия
                                        helper.Set(sheetName_info, 8, i, dr.GetValue(6).ToString());//Имя
                                        helper.Set(sheetName_info, 9, i, dr.GetValue(7).ToString());//Отчество
                                        helper.Set(sheetName_info, 10, i, dr.GetValue(8).ToString());//СНИЛС потребителя
                                        helper.Set(sheetName_info, 11, i, dr.GetValue(9).ToString());//Вид документа, удостоверяющего личность С
                                        helper.Set(sheetName_info, 12, i, dr.GetValue(10).ToString());//Номер документа, удостоверяющего личность
                                        helper.Set(sheetName_info, 13, i, dr.GetValue(11).ToString());//Серия документа, удостоверяющего личность
                                        helper.Set(sheetName_info, 14, i, dr.GetValue(12).ToString() == "" ? "" : dr.GetValue(12).ToString().Replace(" 0:00:00", ""));//Дата документа, удостоверяющего личность
                                        helper.Set(sheetName_info, 15, i, dr.GetValue(13).ToString());//ОГРН/ОГРНИП потребителя (для ЮЛ / ИП)
                                        helper.Set(sheetName_info, 16, i, dr.GetValue(14).ToString());//НЗА потребителя (для ФПИЮЛ)
                                        helper.Set(sheetName_info, 17, i, dr.GetValue(15).ToString());//КПП потребителя (для ОП)

                                        i = 3;
                                        while (helper.Get(sheetName_premises, 2, i) != null)
                                        {
                                            i++;
                                        }
                                        helper.Set(sheetName_info, 1, i, $"{i - 2}");//Номер записи
                                        helper.Set(sheetName_premises, 2, i, dr.GetValue(16).ToString());
                                        helper.Set(sheetName_premises, 3, i, dr.GetValue(17).ToString());
                                        helper.Set(sheetName_premises, 4, i, dr.GetValue(18).ToString());
                                    }

                                    connection.Close();

                                    helper.Save();

                                    helper.Dispose();
                                }
                            }
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }

                }
            }
            else MessageBox.Show("Выбран не верный файл! \nВыберите файл: Шаблон импорта ЛС", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Метод заполнения шаблона о ОПУ
        public static void OPY_Dox_Fill(List<int> id)
        {
            string sFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Шаблон импорта сведений о ПУ-11.13.0.10.xlsx");

            string newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Шаблон импорта сведений о ПУ.xlsx");

            File.Copy(sFileName, newPath);

            if (sFileName.Contains("Шаблон импорта сведений о ПУ") == true)
            {
                foreach (var j in id)
                {
                    try
                    {
                        string sheetName_py = "Сведения о ПУ";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(DoxFill_OPY, connection);
                            cmd.Parameters.AddWithValue("@ID", j);

                            SqlDataReader dr = cmd.ExecuteReader();

                            using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                            {
                                if (helper.Open(filePath: newPath))
                                {
                                    while (dr.Read())
                                    {
                                        int i = 2;

                                        while (helper.Get(sheetName_py, 2, i) != null)
                                        {
                                            i++;
                                        }
                                        helper.Set(sheetName_py, 2, i, dr.GetValue(1).ToString());//номер
                                        helper.Set(sheetName_py, 3, i, dr.GetValue(2).ToString());//вид C
                                        helper.Set(sheetName_py, 4, i, dr.GetValue(3).ToString());//марка
                                        helper.Set(sheetName_py, 5, i, dr.GetValue(4).ToString());//модель
                                        helper.Set(sheetName_py, 6, i, dr.GetValue(0).ToString());//адрес
                                        helper.Set(sheetName_py, 7, i, (dr.GetValue(2).ToString() == "0" || dr.GetValue(2).ToString() == "1") ? dr.GetValue(26).ToString() : ""); //ФИАС
                                        helper.Set(sheetName_py, 11, i, dr.GetValue(5).ToString() == "False" ? "Да" : "Нет");//Дистанциаонные показания C
                                        helper.Set(sheetName_py, 12, i, dr.GetValue(6).ToString());//информацио о дист. показаниях
                                        helper.Set(sheetName_py, 13, i, dr.GetValue(7).ToString() == "False" ? "Да" : "Нет");//несколько ПУ? C
                                        helper.Set(sheetName_py, 14, i, dr.GetValue(7).ToString() == "False" ? dr.GetValue(8).ToString() : "");//Место установки ПУ C
                                        helper.Set(sheetName_py, 15, i, dr.GetValue(9).ToString());//Номер ПУ в ГИС ЖКХ, с которым требуется установить связь текущего ПУ
                                        helper.Set(sheetName_py, 16, i, dr.GetValue(10).ToString());//Вид коммунального ресурса C
                                        helper.Set(sheetName_py, 17, i, dr.GetValue(11).ToString());//Единица измерения. Обязательно, если расход коммунального ресурса может измеряться в разных единицах измерения
                                        helper.Set(sheetName_py, 18, i, dr.GetValue(12).ToString());//Вид ПУ по количеству тарифов C
                                        helper.Set(sheetName_py, 19, i, dr.GetValue(13).ToString());//T1
                                        helper.Set(sheetName_py, 20, i, dr.GetValue(14).ToString());//T2
                                        helper.Set(sheetName_py, 21, i, dr.GetValue(15).ToString());//T3
                                        helper.Set(sheetName_py, 22, i, dr.GetValue(16).ToString());//Коэффициент трансформации
                                        helper.Set(sheetName_py, 23, i, dr.GetValue(17).ToString() == "" ? "" : dr.GetValue(17).ToString().Replace(" 0:00:00", ""));//Дата установки 06.07.2024 0:00:00
                                        helper.Set(sheetName_py, 24, i, dr.GetValue(18).ToString() == "" ? "" : dr.GetValue(18).ToString().Replace(" 0:00:00", ""));//Дата ввода в эксплуатацию
                                        helper.Set(sheetName_py, 25, i, dr.GetValue(19).ToString() == "" ? "" : dr.GetValue(19).ToString().Replace(" 0:00:00", ""));//Дата последней поверки
                                        helper.Set(sheetName_py, 26, i, dr.GetValue(20).ToString() == "" ? "" : dr.GetValue(20).ToString().Replace(" 0:00:00", ""));//Дата опломбирования ПУ заводом-изготовителем
                                        helper.Set(sheetName_py, 28, i, dr.GetValue(21).ToString() == "False" ? "Да" : "Нет");
                                        helper.Set(sheetName_py, 29, i, dr.GetValue(22).ToString());
                                        helper.Set(sheetName_py, 30, i, dr.GetValue(23).ToString() == "False" ? "Да" : "Нет");
                                        helper.Set(sheetName_py, 31, i, dr.GetValue(24).ToString() == "False" ? "Да" : "Нет");
                                        helper.Set(sheetName_py, 32, i, dr.GetValue(25).ToString());
                                    }

                                    connection.Close();

                                    helper.Save();

                                    helper.Dispose();
                                }
                            }
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }

                }
            }
            else MessageBox.Show("Выбран не верный файл! \nВыберите файл: Шаблон импорта сведений о ПУ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static string Date()
        {
            string date = DateTime.Now.ToShortDateString().Replace(".", "");
            return date.Substring(4) + date.Substring(2, 2);
        }

        //Метод заполнения шаблона ИПУ
        public static void IPY_Dox_Fill()
        {
            string sFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Шаблон импорта сведений о ПУ-11.13.0.10.xlsx");

            string newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Шаблон импорта сведений о ИПУ.xlsx");

            File.Copy(sFileName, newPath);

            if (sFileName.Contains("Шаблон импорта сведений о ПУ") == true)
            {
                try
                {
                    string sheetName_py = "Сведения о ПУ";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(DoxFill_IPY, connection);
                        cmd.Parameters.AddWithValue("@ID", ID);

                        SqlDataReader dr = cmd.ExecuteReader();

                        using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                        {
                            if (helper.Open(filePath: newPath))
                            {
                                while (dr.Read())
                                {
                                    int i = 2;

                                    while (helper.Get(sheetName_py, 2, i) != null)
                                    {
                                        i++;
                                    }
                                    helper.Set(sheetName_py, 2, i, dr.GetValue(1).ToString());//номер
                                    helper.Set(sheetName_py, 3, i, dr.GetValue(2).ToString());//вид C
                                    helper.Set(sheetName_py, 4, i, dr.GetValue(3).ToString());//марка
                                    helper.Set(sheetName_py, 5, i, dr.GetValue(4).ToString());//модель
                                    helper.Set(sheetName_py, 6, i, dr.GetValue(0).ToString());//адрес
                                    helper.Set(sheetName_py, 8, i, (dr.GetValue(2).ToString() == "0" || dr.GetValue(2).ToString() == "2") ? dr.GetValue(27).ToString() : ""); //ID помещения
                                    helper.Set(sheetName_py, 10, i, dr.GetValue(26).ToString());//Информация ЛС
                                    helper.Set(sheetName_py, 11, i, dr.GetValue(5).ToString() == "False" ? "Да" : "Нет");//Дистанциаонные показания C
                                    helper.Set(sheetName_py, 12, i, dr.GetValue(6).ToString());//информацио о дист. показаниях
                                    helper.Set(sheetName_py, 13, i, dr.GetValue(7).ToString() == "False" ? "Да" : "Нет");//несколько ПУ? C
                                    helper.Set(sheetName_py, 14, i, dr.GetValue(7).ToString() == "False" ? dr.GetValue(8).ToString() : "");//Место установки ПУ C
                                    helper.Set(sheetName_py, 15, i, dr.GetValue(9).ToString());//Номер ПУ в ГИС ЖКХ, с которым требуется установить связь текущего ПУ
                                    helper.Set(sheetName_py, 16, i, dr.GetValue(10).ToString());//Вид коммунального ресурса C
                                    helper.Set(sheetName_py, 17, i, dr.GetValue(11).ToString());//Единица измерения. Обязательно, если расход коммунального ресурса может измеряться в разных единицах измерения
                                    helper.Set(sheetName_py, 18, i, dr.GetValue(12).ToString());//Вид ПУ по количеству тарифов C
                                    helper.Set(sheetName_py, 19, i, dr.GetValue(13).ToString());//T1
                                    helper.Set(sheetName_py, 20, i, dr.GetValue(14).ToString());//T2
                                    helper.Set(sheetName_py, 21, i, dr.GetValue(15).ToString());//T3
                                    helper.Set(sheetName_py, 22, i, dr.GetValue(16).ToString());//Коэффициент трансформации
                                    helper.Set(sheetName_py, 23, i, dr.GetValue(17).ToString() == "" ? "" : dr.GetValue(17).ToString().Replace(" 0:00:00", ""));//Дата установки 06.07.2024 0:00:00
                                    helper.Set(sheetName_py, 24, i, dr.GetValue(18).ToString() == "" ? "" : dr.GetValue(18).ToString().Replace(" 0:00:00", ""));//Дата ввода в эксплуатацию
                                    helper.Set(sheetName_py, 25, i, dr.GetValue(19).ToString() == "" ? "" : dr.GetValue(19).ToString().Replace(" 0:00:00", ""));//Дата последней поверки
                                    helper.Set(sheetName_py, 26, i, dr.GetValue(20).ToString() == "" ? "" : dr.GetValue(20).ToString().Replace(" 0:00:00", ""));//Дата опломбирования ПУ заводом-изготовителем
                                    helper.Set(sheetName_py, 28, i, dr.GetValue(21).ToString() == "False" ? "Да" : "Нет");
                                    helper.Set(sheetName_py, 29, i, dr.GetValue(22).ToString());
                                    helper.Set(sheetName_py, 30, i, dr.GetValue(23).ToString() == "False" ? "Да" : "Нет");
                                    helper.Set(sheetName_py, 31, i, dr.GetValue(24).ToString());
                                    helper.Set(sheetName_py, 32, i, dr.GetValue(25).ToString() == "False" ? "Да" : "Нет");
                                }

                                connection.Close();

                                helper.Save();

                                helper.Dispose();
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            else MessageBox.Show("Выбран не верный файл! \nВыберите файл: Шаблон импорта сведений о ПУ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Метод заполнения шаблона ПД
        public static void PD_Dox_Fill(List<int> id)
        {
            string sFileName = "";

            if (true)
            {
                sFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Шаблон ПД.xlsx");

                string newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Шаблон ПД.xlsx");

                File.Copy(sFileName, newPath);
                foreach (var j in id)
                {
                    try
                    {
                        string sheetName_pd = "Раздел 1";
                        string sheetName_services = "Разделы 3-6";
                        string sheetName_penalties = "Неустойки и судебные расходы";
                        string sheetName_rec = "Платежные реквизиты";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(GIS_Data.DoxFill_PD_info, connection);
                            List<SqlParameter> prm = new List<SqlParameter>()
                                    {
                                    new SqlParameter("@ID", SqlDbType.Int) {Value = j},
                                    new SqlParameter("@SD", SqlDbType.VarChar) {Value = Start_Date},
                                    new SqlParameter("@ED", SqlDbType.VarChar) {Value = End_Date}
                                    };
                            cmd.Parameters.AddRange(prm.ToArray());

                            using (Classes.Excel_Dox helper = new Classes.Excel_Dox())
                            {
                                if (helper.Open(filePath: newPath))
                                {
                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        while (dr.Read())
                                        {
                                            int i = 4;

                                            while (helper.Get(sheetName_pd, 3, i) != null)
                                            {
                                                i++;
                                            }
                                            helper.Set(sheetName_pd, 1, i, dr.GetValue(0).ToString());
                                            helper.Set(sheetName_pd, 2, i, dr.GetValue(1).ToString());
                                            helper.Set(sheetName_pd, 3, i, Date() + dr.GetValue(2).ToString());
                                            helper.Set(sheetName_pd, 4, i, dr.GetValue(3).ToString().Substring(3, 7));
                                            helper.Set(sheetName_pd, 5, i, dr.GetValue(4).ToString());
                                            helper.Set(sheetName_pd, 6, i, dr.GetValue(5).ToString() == "" ? "0" : dr.GetValue(5).ToString());
                                            helper.Set(sheetName_pd, 9, i, dr.GetValue(6).ToString());
                                            helper.Set(sheetName_pd, 10, i, dr.GetValue(7).ToString());
                                            helper.Set(sheetName_pd, 12, i, dr.GetValue(8).ToString().Replace(" 0:00:00", ""));
                                            helper.Set(sheetName_pd, 13, i, dr.GetValue(9).ToString());
                                            helper.Set(sheetName_pd, 14, i, dr.GetValue(10).ToString());
                                            helper.Set(sheetName_pd, 15, i, Date() + dr.GetValue(2).ToString() + "-1");
                                            helper.Set(sheetName_pd, 16, i, dr.GetValue(11).ToString());
                                            helper.Set(sheetName_pd, 17, i, dr.GetValue(12).ToString());
                                            helper.Set(sheetName_pd, 19, i, dr.GetValue(13).ToString());
                                        }
                                    }

                                    cmd.CommandText = GIS_Data.DoxFill_PD_Acc;

                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        while (dr.Read())
                                        {
                                            int i = 2;

                                            while (helper.Get(sheetName_rec, 1, i) != null)
                                            {
                                                i++;
                                            }
                                            helper.Set(sheetName_rec, 1, i, Date() + dr.GetValue(0).ToString());
                                            helper.Set(sheetName_rec, 2, i, Date() + dr.GetValue(0).ToString() + "-1");
                                            helper.Set(sheetName_rec, 3, i, dr.GetValue(1).ToString());
                                            helper.Set(sheetName_rec, 4, i, dr.GetValue(2).ToString());
                                        }
                                    }

                                    cmd.CommandText = GIS_Data.DoxFill_PD_penalties;

                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        while (dr.Read())
                                        {
                                            int i = 3;

                                            while (helper.Get(sheetName_penalties, 1, i) != null)
                                            {
                                                i++;
                                            }
                                            helper.Set(sheetName_penalties, 1, i, Date() + dr.GetValue(0).ToString());
                                            helper.Set(sheetName_penalties, 2, i, dr.GetValue(1).ToString());
                                            helper.Set(sheetName_penalties, 3, i, dr.GetValue(2).ToString());
                                            helper.Set(sheetName_penalties, 4, i, dr.GetValue(3).ToString());
                                        }
                                    }

                                    cmd.CommandText = GIS_Data.DoxFill_PD_services;

                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        while (dr.Read())
                                        {
                                            int i = 4;

                                            while (helper.Get(sheetName_services, 1, i) != null)
                                            {
                                                i++;
                                            }
                                            helper.Set(sheetName_services, 1, i, Date() + dr.GetValue(0).ToString());
                                            helper.Set(sheetName_services, 2, i, dr.GetValue(1).ToString());
                                            helper.Set(sheetName_services, 4, i, dr.GetValue(2).ToString());
                                            helper.Set(sheetName_services, 5, i, dr.GetValue(3).ToString());
                                            helper.Set(sheetName_services, 6, i, dr.GetValue(4).ToString());
                                            helper.Set(sheetName_services, 7, i, dr.GetValue(5).ToString());
                                            helper.Set(sheetName_services, 8, i, dr.GetValue(6).ToString());
                                            helper.Set(sheetName_services, 9, i, dr.GetValue(7).ToString());
                                            helper.Set(sheetName_services, 10, i, dr.GetValue(8).ToString());
                                            helper.Set(sheetName_services, 11, i, dr.GetValue(9).ToString());
                                            helper.Set(sheetName_services, 13, i, dr.GetValue(10).ToString());
                                            helper.Set(sheetName_services, 14, i, dr.GetValue(11).ToString());
                                            helper.Set(sheetName_services, 15, i, dr.GetValue(12).ToString());
                                            helper.Set(sheetName_services, 16, i, dr.GetValue(13).ToString());
                                            helper.Set(sheetName_services, 17, i, dr.GetValue(14).ToString());
                                            helper.Set(sheetName_services, 18, i, dr.GetValue(15).ToString());
                                            helper.Set(sheetName_services, 19, i, dr.GetValue(16).ToString());
                                            helper.Set(sheetName_services, 20, i, dr.GetValue(17).ToString());
                                            helper.Set(sheetName_services, 21, i, dr.GetValue(18).ToString());
                                            helper.Set(sheetName_services, 28, i, dr.GetValue(19).ToString());
                                            helper.Set(sheetName_services, 29, i, dr.GetValue(20).ToString());
                                        }
                                    }
                                }

                                connection.Close();

                                helper.Save();

                                helper.Dispose();
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }



        //Строка подключения
        public static string connectionString = /*@"Data Source=DESKTOP-P4VMBDQ;Initial Catalog=GIS;User Id=DESKTOP-P4VMBDQ\-egor;Password=your_sql_password";*/@"Data Source=(local);Initial Catalog=GIS;Integrated Security=True";
        //Запрос для заполнения шаблона о МКД
        public static string DoxFill_MKD_mkd = "Select a.Type_Street + ' ' + a.Street + ' ' + House_Number AS 'Street'" +
                              ",ID_FIAS" +
                              ",OKTMO" +
                              ",Statys" +
                              ",Life_Cycle_Stage" +
                              ",Total_Building_Area" +
                              ",Year_Of_Commissioning" +
                              ",Count_floors" +
                              ",Count_Underfloors" +
                              ",Olson" +
                              ",Is_Cultural_Legacy" +
                              ",Cadastral_Number " +
                            "From Characteristic_MKD m " +
                            "Join Address_Book a ON a.ID = m.ID_Address " +
                            "WHERE m.ID = @ID";

        public static string DoxFill_MKD_entrance = "Select a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address_E'" +
                                  ",Entrance_Number" +
                                  ",Number_Of_Floors" +
                                  ",Year_Of_Construction" +
                                  ",Is_Confirmed_Supplier " +
                            "From Entrance e " +
                            "Join Characteristic_MKD m ON m.ID = e.ID_MKD_Address " +
                            "Join Address_Book a ON a.ID = m.ID_Address " +
                            "WHERE e.ID_MKD_Address = @ID";

        public static string DoxFill_MKD_premises = "Select Is_Living,a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address_P'" +
                                ",p.ID" +
                                ",Premises_Description" +
                                ",Total_Area" +
                                ",Living_Total_Area" +
                                ",Is_Common" +
                                ",p.Cadastral_Number" +
                                ",Is_Confirmed_Supplier " +
                              "From MKD_Premises p " +
                              "Join Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                              "Join Address_Book a ON a.ID = m.ID_Address " +
                              $"WHERE p.ID_MKD_Address = @ID";
        //27
        public static string DoxFill_OPY = "SELECT a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address'" +
                                  ",Serial_Number" +
                                  ",Type_PY" +
                                  ",Mark_PY" +
                                  ",Model_PY" +
                                  ",Is_Distance_Check" +
                                  ",Name_DIstance_PY" +
                                  ",Is_Many_PY_Used" +
                                  ",Place_Location_PY" +
                                  ",GIS_Number_PY_To_Connect" +
                                  ",Type_Kommunal_Res" +
                                  ",Unit_Measurement_PY" +
                                  ",Type_PU_Number_Tariffs" +
                                  ",T1" +
                                  ",T2" +
                                  ",T3" +
                                  ",Trans_Coef" +
                                  ",Installation_Date" +
                                  ",Operation_Date" +
                                  ",Last_Check_Date" +
                                  ",Plomb_PU_Date" +
                                  ",Is_Temperature_Sensors" +
                                  ",Temperature_Sensors_Info" +
                                  ",Is_Pressure_Sensors" +
                                  ",Pressure_Sensors_Info" +
                                  ",Is_AutomaticCalculation" +
                                  ",m.ID_FIAS " +
                              "FROM General_Metering_Device g " +
                              "JOIN Characteristic_MKD m ON m.ID = g.ID_MKD_Address " +
                              "JOIN Address_Book a ON a.ID = m.ID_Address " +
                              "WHERE g.ID = @ID";

        //27
        public static string DoxFill_IPY = "SELECT a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Address'" +
                                  ",Serial_Number" +
                                  ",Type_PY" +
                                  ",Mark_PY" +
                                  ",Model_PY" +
                                  ",Is_Distance_Check" +
                                  ",Distance_Check_Info" +
                                  ",Is_Many_PY_Used" +
                                  ",Place_Location_PY" +
                                  ",GIS_Number_PY_To_Connect" +
                                  ",Type_Kommunal_Res" +
                                  ",Unit_Measurement_PY" +
                                  ",Type_PU_Number_Tariffs" +
                                  ",T1" +
                                  ",T2" +
                                  ",T3" +
                                  ",Trans_Coef" +
                                  ",Installation_Date" +
                                  ",Operation_Date" +
                                  ",Last_Check_Date" +
                                  ",Plomb_PU_Date" +
                                  ",Is_Temperature_Sensors" +
                                  ",Temperature_Sensors_Info" +
                                  ",Is_Pressure_Sensors" +
                                  ",Pressure_Sensors_Info" +
                                  ",Is_AutomaticCalculation" +
                                  ",l.Number_JKY" +
                                  ",p.ID " +
                              "FROM Metering_Devices po " +
                              "JOIN MKD_Premises p ON p.ID = po.ID_MKD_Premises " +
                              "JOIN LS l ON l.ID = po.ID_LS " +
                              "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                              "JOIN Address_Book a ON a.ID = m.ID_Address " +
                              "WHERE po.ID = @ID";
        //18
        public static string DoxFill_LS_info = "SELECT pl.ID_LS," +
                                    "Number_JKY," +
                                    "Type_LS," +
                                    "Is_Employer," +
                                    "Is_Splited," +
                                    "o.SecondName," +
                                    "o.FirstName," +
                                    "o.LastName," +
                                    "o.SNILS," +
                                    "o.Passport_Type," +
                                    "o.Passport_Number," +
                                    "o.Passport_Series," +
                                    "o.Passport_Date," +
                                    "OGRN," +
                                    "NZA," +
                                    "KPP," +
                                    "a.Type_Street + ' ' + a.Street + ' ' + m.House_Number AS 'Адрес помещения'," +
                                    "m.ID_FIAS," +
                                    "p.Premises_Description " +
                                "FROM Premises_LS_Relations pl " +
                                "JOIN LS l ON l.ID = pl.ID_LS " +
                                "JOIN MKD_Premises p ON p.ID = pl.ID_Premises " +
                                "JOIN Owner_LS o ON o.ID = l.ID_Owner " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "JOIN Address_Book a ON a.ID = m.ID_Address " +
                                "WHERE pl.ID_LS = @ID AND pl.ID_Premises = @secID";

        public static string DoxFill_PD_info = "SELECT l.Number_JKY," +
                                "pd.Type_PD, " +
                                "pd.ID, " +
                                "pd.Calculation_Period, " +
                                "p.Total_Area, " +
                                "p.Living_Total_Area," +
                                "pd.Period_Sum, " +
                                "pd.Cash_Paid, " +
                                "pd.Last_Payment_Date, " +
                                "pd.Social_Support, " +
                                "pd.Total_Period_Debt," +
                                "pd.Total_Period, " +
                                "pd.Total, " +
                                "pd.Total_Legal_Expenses " +
                                "FROM Payment_Document pd " +
                                "JOIN LS l ON l.ID = pd.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises p ON p.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "WHERE m.ID = @ID AND pd.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_penalties = "SELECT pd.ID, p.Type_Accrual, p.Reason_Accrual, p.Sum " +
                                "FROM Penalties_And_Court_Costs p " +
                                "JOIN Payment_Document pd ON pd.ID = p.ID_PD_Number " +
                                "JOIN LS l ON l.ID = pd.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises prem ON prem.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = prem.ID_MKD_Address " +
                                "WHERE m.ID = @ID AND pd.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_Acc = "SELECT " +
                                "pd.ID," +
                                "m.BIK_S," +
                                "m.Payment_Account_S " +
                                "FROM Payment_Document pd " +
                                "JOIN LS l ON l.ID = pd.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises p ON p.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "WHERE m.ID = @ID AND pd.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_services = "SELECT " +
                                "pd.ID," +
                                "s.Services," +
                                "s.Metod_Det_V_Servise," +
                                "s.V_S_Count_Servise," +
                                "s.Metod_Det_V_Resourses," +
                                "s.V_S_Count_Resourses," +
                                "s.Tarif," +
                                "s.Accrued_Pilling_Period," +
                                "s.Increase_Coef," +
                                "s.Value_Increase_Payment," +
                                "s.Benefits," +
                                "s.Order_Payment," +
                                "s.Total_Period," +
                                "s.Debt_Avans," +
                                "s.Penalty," +
                                "s.Penalty_Provider," +
                                "s.State_Duties," +
                                "s.Jud_Cost," +
                                "s.Total," +
                                "s.Recalculations," +
                                "s.Sum_Recalculations " +
                                "FROM Services_For_The_Payment_Period s " +
                                "JOIN Payment_Document pd ON pd.ID = s.ID_PD_Number " +
                                "JOIN LS l ON l.ID = pd.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises p ON p.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "WHERE m.ID = @ID AND pd.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_info_Full = "SELECT l.Number_JKY," +
                        "pd.Type_PD, " +
                        "pd.ID, " +
                        "pd.Calculation_Period, " +
                        "p.Total_Area, " +
                        "p.Living_Total_Area," +
                        "pd.Period_Sum, " +
                        "pd.Cash_Paid, " +
                        "pd.Last_Payment_Date, " +
                        "pd.Social_Support, " +
                        "pd.Total_Period_Debt," +
                        "pd.Total_Period, " +
                        "pd.Total, " +
                        "pd.Total_Legal_Expenses " +
                        "FROM Payment_Document pd " +
                        "JOIN LS l ON l.ID = pd.ID_LS " +
                        "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                        "JOIN MKD_Premises p ON p.ID = plr.ID_Premises " +
                        "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                        "WHERE pd.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_penalties_Full = "SELECT pd.ID, p.Type_Accrual, p.Reason_Accrual, p.Sum " +
                                "FROM Penalties_And_Court_Costs p " +
                                "JOIN Payment_Document pd ON pd.ID = p.ID_PD_Number " +
                                "JOIN LS l ON l.ID = pd.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises prem ON prem.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = prem.ID_MKD_Address " +
                                "WHERE pd.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_Acc_Full = "SELECT " +
                                "pay.ID," +
                                "m.BIK_S," +
                                "m.Payment_Account_S " +
                                "FROM Payment_Document pay " +
                                "JOIN LS l ON l.ID = pay.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises p ON p.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "WHERE pay.Calculation_Period BETWEEN @SD AND @ED";

        public static string DoxFill_PD_services_Full = "SELECT " +
                                "pd.ID," +
                                "s.Services," +
                                "s.Metod_Det_V_Servise," +
                                "s.V_S_Count_Servise," +
                                "s.Metod_Det_V_Resourses," +
                                "s.V_S_Count_Resourses," +
                                "s.Tarif," +
                                "s.Accrued_Pilling_Period," +
                                "s.Increase_Coef," +
                                "s.Value_Increase_Payment," +
                                "s.Benefits," +
                                "s.Order_Payment," +
                                "s.Total_Period," +
                                "s.Debt_Avans," +
                                "s.Penalty," +
                                "s.Penalty_Provider," +
                                "s.State_Duties," +
                                "s.Jud_Cost," +
                                "s.Total," +
                                "s.Recalculations," +
                                "s.Sum_Recalculations " +
                                "FROM Services_For_The_Payment_Period s " +
                                "JOIN Payment_Document pd ON pd.ID = s.ID_PD_Number " +
                                "JOIN LS l ON l.ID = pd.ID_LS " +
                                "JOIN Premises_LS_Relations plr ON plr.ID_LS = l.ID " +
                                "JOIN MKD_Premises p ON p.ID = plr.ID_Premises " +
                                "JOIN Characteristic_MKD m ON m.ID = p.ID_MKD_Address " +
                                "WHERE pd.Calculation_Period BETWEEN @SD AND @ED";
    }
}
