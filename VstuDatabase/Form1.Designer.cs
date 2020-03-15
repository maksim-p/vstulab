namespace VstuDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wordExportButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.yearField = new System.Windows.Forms.TextBox();
            this.defaultReportButton = new System.Windows.Forms.Button();
            this.bestClientReportButton = new System.Windows.Forms.Button();
            this.excelExportButton = new System.Windows.Forms.Button();
            this.reportDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientIdLable = new System.Windows.Forms.Label();
            this.deleteButtonClick = new System.Windows.Forms.Button();
            this.changeButtonClick = new System.Windows.Forms.Button();
            this.dateOfBirthField = new System.Windows.Forms.TextBox();
            this.clientData = new System.Windows.Forms.DataGridView();
            this.sexField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.tabPage1);
            this.controlPanel.Controls.Add(this.tabPage2);
            this.controlPanel.Location = new System.Drawing.Point(5, 4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.SelectedIndex = 0;
            this.controlPanel.Size = new System.Drawing.Size(1066, 446);
            this.controlPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wordExportButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.yearField);
            this.tabPage1.Controls.Add(this.defaultReportButton);
            this.tabPage1.Controls.Add(this.bestClientReportButton);
            this.tabPage1.Controls.Add(this.excelExportButton);
            this.tabPage1.Controls.Add(this.reportDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wordExportButton
            // 
            this.wordExportButton.Location = new System.Drawing.Point(9, 48);
            this.wordExportButton.Name = "wordExportButton";
            this.wordExportButton.Size = new System.Drawing.Size(244, 36);
            this.wordExportButton.TabIndex = 6;
            this.wordExportButton.Text = "экспорт в Word";
            this.wordExportButton.UseVisualStyleBackColor = true;
            this.wordExportButton.Click += new System.EventHandler(this.WordExportButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Год:";
            // 
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(6, 293);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(244, 22);
            this.yearField.TabIndex = 4;
            // 
            // defaultReportButton
            // 
            this.defaultReportButton.Location = new System.Drawing.Point(6, 321);
            this.defaultReportButton.Name = "defaultReportButton";
            this.defaultReportButton.Size = new System.Drawing.Size(244, 41);
            this.defaultReportButton.TabIndex = 3;
            this.defaultReportButton.Text = "Стандартный отчет";
            this.defaultReportButton.UseVisualStyleBackColor = true;
            this.defaultReportButton.Click += new System.EventHandler(this.DefaultReportButton_Click);
            // 
            // bestClientReportButton
            // 
            this.bestClientReportButton.Location = new System.Drawing.Point(6, 368);
            this.bestClientReportButton.Name = "bestClientReportButton";
            this.bestClientReportButton.Size = new System.Drawing.Size(244, 41);
            this.bestClientReportButton.TabIndex = 2;
            this.bestClientReportButton.Text = "Лучшие покупатели за год";
            this.bestClientReportButton.UseVisualStyleBackColor = true;
            this.bestClientReportButton.Click += new System.EventHandler(this.BestClientReportButton_Click);
            // 
            // excelExportButton
            // 
            this.excelExportButton.Location = new System.Drawing.Point(6, 6);
            this.excelExportButton.Name = "excelExportButton";
            this.excelExportButton.Size = new System.Drawing.Size(244, 36);
            this.excelExportButton.TabIndex = 1;
            this.excelExportButton.Text = "экспорт в Excel";
            this.excelExportButton.UseVisualStyleBackColor = true;
            this.excelExportButton.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // reportDataGrid
            // 
            this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGrid.Location = new System.Drawing.Point(256, 6);
            this.reportDataGrid.Name = "reportDataGrid";
            this.reportDataGrid.RowHeadersWidth = 51;
            this.reportDataGrid.RowTemplate.Height = 24;
            this.reportDataGrid.Size = new System.Drawing.Size(796, 403);
            this.reportDataGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clientIdLable);
            this.tabPage2.Controls.Add(this.deleteButtonClick);
            this.tabPage2.Controls.Add(this.changeButtonClick);
            this.tabPage2.Controls.Add(this.dateOfBirthField);
            this.tabPage2.Controls.Add(this.clientData);
            this.tabPage2.Controls.Add(this.sexField);
            this.tabPage2.Controls.Add(this.phoneField);
            this.tabPage2.Controls.Add(this.lastNameField);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nameField);
            this.tabPage2.Controls.Add(this.addUserButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientIdLable
            // 
            this.clientIdLable.AutoSize = true;
            this.clientIdLable.Location = new System.Drawing.Point(6, 3);
            this.clientIdLable.Name = "clientIdLable";
            this.clientIdLable.Size = new System.Drawing.Size(0, 17);
            this.clientIdLable.TabIndex = 15;
            // 
            // deleteButtonClick
            // 
            this.deleteButtonClick.Location = new System.Drawing.Point(201, 252);
            this.deleteButtonClick.Name = "deleteButtonClick";
            this.deleteButtonClick.Size = new System.Drawing.Size(85, 42);
            this.deleteButtonClick.TabIndex = 14;
            this.deleteButtonClick.Text = "Удалить";
            this.deleteButtonClick.UseVisualStyleBackColor = true;
            this.deleteButtonClick.Click += new System.EventHandler(this.DeleteButtonClick_Click);
            // 
            // changeButtonClick
            // 
            this.changeButtonClick.Location = new System.Drawing.Point(99, 252);
            this.changeButtonClick.Name = "changeButtonClick";
            this.changeButtonClick.Size = new System.Drawing.Size(96, 42);
            this.changeButtonClick.TabIndex = 13;
            this.changeButtonClick.Text = "Изменить";
            this.changeButtonClick.UseVisualStyleBackColor = true;
            this.changeButtonClick.Click += new System.EventHandler(this.ChangeButtonClick_Click);
            // 
            // dateOfBirthField
            // 
            this.dateOfBirthField.Location = new System.Drawing.Point(123, 114);
            this.dateOfBirthField.Name = "dateOfBirthField";
            this.dateOfBirthField.Size = new System.Drawing.Size(148, 22);
            this.dateOfBirthField.TabIndex = 12;
            // 
            // clientData
            // 
            this.clientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientData.Location = new System.Drawing.Point(292, 28);
            this.clientData.Name = "clientData";
            this.clientData.RowHeadersWidth = 51;
            this.clientData.RowTemplate.Height = 24;
            this.clientData.Size = new System.Drawing.Size(760, 381);
            this.clientData.TabIndex = 11;
            this.clientData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientData_RowHeaderMouseClick_1);
            // 
            // sexField
            // 
            this.sexField.Location = new System.Drawing.Point(123, 211);
            this.sexField.Name = "sexField";
            this.sexField.Size = new System.Drawing.Size(148, 22);
            this.sexField.TabIndex = 10;
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(123, 162);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(148, 22);
            this.phoneField.TabIndex = 9;
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(123, 69);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(148, 22);
            this.lastNameField.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(123, 28);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(148, 22);
            this.nameField.TabIndex = 1;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(3, 252);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(90, 42);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl controlPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox sexField;
        private System.Windows.Forms.Button deleteButtonClick;
        private System.Windows.Forms.Button changeButtonClick;
        private System.Windows.Forms.TextBox dateOfBirthField;
        private System.Windows.Forms.DataGridView clientData;
        private System.Windows.Forms.Label clientIdLable;
        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.Button excelExportButton;
        private System.Windows.Forms.Button bestClientReportButton;
        private System.Windows.Forms.Button defaultReportButton;
        private System.Windows.Forms.Button wordExportButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yearField;
    }
}

