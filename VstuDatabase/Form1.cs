using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VstuDatabase.service;

namespace VstuDatabase
{
    public partial class Form1 : Form
    {
        private ClientService clientService = new ClientService();
        private ReportService reportService = new ReportService();

        public Form1()
        {
            InitializeComponent();
            clientService.DisplayClientData(clientData);
            reportService.DisplayDefaultReport(reportDataGrid);

        }

        public void CleanData()
        {
            nameField.Text = "";
            lastNameField.Text = "";
            dateOfBirthField.Text = "";
            phoneField.Text = "";
            sexField.Text = "";
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            clientService.AddClient(nameField.Text, lastNameField.Text, dateOfBirthField.Text, phoneField.Text, sexField.Text, clientData);
            CleanData();
        }


        private void ClientData_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            clientIdLable.Text = clientData.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameField.Text = clientData.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastNameField.Text = clientData.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateOfBirthField.Text = clientData.Rows[e.RowIndex].Cells[3].Value.ToString();
            phoneField.Text = clientData.Rows[e.RowIndex].Cells[4].Value.ToString();
            sexField.Text = clientData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void ChangeButtonClick_Click(object sender, EventArgs e)
        {
            clientService.ChangeClient(nameField.Text, lastNameField.Text, dateOfBirthField.Text, phoneField.Text, sexField.Text, clientIdLable.Text, clientData);
            CleanData();
        }
        private void DeleteButtonClick_Click(object sender, EventArgs e)
        {
            clientService.DeleteClient(clientIdLable.Text, clientData);
            CleanData();
        }

        private void ExcelExportButton_Click(object sender, EventArgs e) => reportService.ExportExcel(reportDataGrid);

        private void DefaultReportButton_Click(object sender, EventArgs e) => reportService.DisplayDefaultReport(reportDataGrid);

        private void BestClientReportButton_Click(object sender, EventArgs e) => reportService.DisplayBestClientReport(reportDataGrid, yearField.Text);

        private void WordExportButton_Click(object sender, EventArgs e)
        {
            reportService.ExportWord(reportDataGrid);
        }
    }
}
