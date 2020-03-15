using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VstuDatabase.service
{
    class ReportService
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;

        public ReportService()
        {
        }

        public void DisplayDefaultReport(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("select cl.client_id as id, cl.first_name as Имя, cl.last_name as Фамилия, cl.phone as Телефон, COUNT(ord.order_id) as Количество_товаров, SUM(prod.price) as Всего_потрачено" + 
                " from client cl" + 
                " join orders ord ON ord.client_id = cl.client_id" + 
                " join product prod ON prod.product_id = ord.product_id" + 
                " group by cl.client_id, cl.first_name, cl.last_name, cl.phone",
                connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        public void DisplayBestClientReport(DataGridView dataGrid, string year)
        {
            if (!(year == "" || year is null))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                adapter = new SqlDataAdapter(
                    "select cl.client_id as id, cl.first_name as Имя, cl.last_name as Фамилия, cl.phone as Телефон, COUNT(ord.order_id) as Количество_товаров, SUM(prod.price) as Всего_потрачено" + 
                    " from client cl" + 
                    " join orders ord ON ord.client_id = cl.client_id" + 
                    " join product prod ON prod.product_id = ord.product_id" + 
                    " where YEAR(ord.order_date) IN (@reportYear)" + 
                    " group by cl.client_id, cl.first_name, cl.last_name, cl.phone" + 
                    " having SUM(prod.price) > 10000",
                    connection);
                adapter.SelectCommand.Parameters.AddWithValue("@reportYear", int.Parse(year));
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
            else
            {
                MessageBox.Show("Выберите год");
            }
        }

        public void ExportExcel(DataGridView dataGrid)
        {
            
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // создаем новый WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // новый Excelsheet в workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // задаем имя для worksheet
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }
            // закрываем подключение к excel 
            app.Quit();
        }

        public void ExportWord(DataGridView DGV)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //добавим поля и колонки
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                //страницы
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //формат таблиц
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //Стили заголовков
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;


                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                

                //Текст заголовка
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Отчет";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                // oDoc.SaveAs2(filename);
            }
            }

    }
}
