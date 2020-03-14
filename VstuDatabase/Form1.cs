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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            clientService.AddClient(nameField.Text, lastNameField.Text, dateOfBirthField.Text, phoneField.Text, sexField.Text, clientData);
            CleanData();
        }


        private void clientData_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            clientIdLable.Text = clientData.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameField.Text = clientData.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastNameField.Text = clientData.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateOfBirthField.Text = clientData.Rows[e.RowIndex].Cells[3].Value.ToString();
            phoneField.Text = clientData.Rows[e.RowIndex].Cells[4].Value.ToString();
            sexField.Text = clientData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void changeButtonClick_Click(object sender, EventArgs e)
        {
            clientService.ChangeClient(nameField.Text, lastNameField.Text, dateOfBirthField.Text, phoneField.Text, sexField.Text, clientIdLable.Text, clientData);
            CleanData();
        }
        private void deleteButtonClick_Click(object sender, EventArgs e)
        {
            clientService.DeleteClient(clientIdLable.Text, clientData);
            CleanData();
        }

        private void excelExportButton_Click(object sender, EventArgs e) => reportService.ExportExcel(reportDataGrid);
    }
}
