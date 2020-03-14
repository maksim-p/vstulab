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
        public SqlCommand cmd;

        public ReportService()
        {
        }

        public void DisplayDefaultReport(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("select cl.client_id as id, cl.first_name as Имя, cl.last_name as Фамилия, cl.phone as Телефон, COUNT(ord.order_id) as Количество_товаров, SUM(prod.price) as Всего_потрачено from client cl join orders ord ON ord.client_id = cl.client_id join product prod ON prod.product_id = ord.product_id group by cl.client_id, cl.first_name, cl.last_name, cl.phone", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
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
            // сохраняем
            // закрываем подключение к excel 
            app.Quit();
        }
    }
}
