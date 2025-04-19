using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace GIS.Classes
{
    class Excel_Dox : IDisposable
    {
        private Excel.Application _excel;
        private Excel.Workbook _workbook;
        private string _filePath;

        public Excel_Dox()
        {
            _excel = new Excel.Application();
        }

        internal bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add();
                    _filePath = filePath;
                }

                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
            {
                _workbook.Save();
            }
        }

        internal object Row_Index()
        {            
            try
            {
                Excel.Range range = (Excel.Range)_excel.ActiveCell;
                return range.Row;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        internal bool Set(string listName, int column, int row, string data)
        {
            try
            {
                // var val = ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Value2;

                ((Excel.Worksheet)_excel.Worksheets[listName]).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal bool Set(string listName, string column, int row, string data)
        {
            try
            {
                // var val = ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Value2;

                ((Excel.Worksheet)_excel.Worksheets[listName]).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal object Get(string listName, int column, int row)
        {
            try
            {
                return ((Excel.Worksheet)_excel.Worksheets[listName]).Cells[row, column].Value2;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
                _excel.Quit();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
