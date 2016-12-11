namespace ViewLayer
{
    partial class FormEmployers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlEmployers = new System.Windows.Forms.TabControl();
            this.tabRegEmployers = new System.Windows.Forms.TabPage();
            this.buttonClearRegistration = new System.Windows.Forms.Button();
            this.buttonAcceptRegistration = new System.Windows.Forms.Button();
            this.textBoxEmployerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmployerAddress = new System.Windows.Forms.TextBox();
            this.textBoxITN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployerName = new System.Windows.Forms.TextBox();
            this.tabInfoEmployers = new System.Windows.Forms.TabPage();
            this.splitContainerInfo = new System.Windows.Forms.SplitContainer();
            this.buttonSearchInfo = new System.Windows.Forms.Button();
            this.textBoxSearchInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnITN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVacancies = new System.Windows.Forms.TabPage();
            this.splitContainerVacancies = new System.Windows.Forms.SplitContainer();
            this.buttonAddVacancy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearchVacancy = new System.Windows.Forms.Button();
            this.textBoxSearchVacancy = new System.Windows.Forms.TextBox();
            this.dataGridVacancies = new System.Windows.Forms.DataGridView();
            this.ColumnVacancyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmploymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlEmployers.SuspendLayout();
            this.tabRegEmployers.SuspendLayout();
            this.tabInfoEmployers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).BeginInit();
            this.splitContainerInfo.Panel1.SuspendLayout();
            this.splitContainerInfo.Panel2.SuspendLayout();
            this.splitContainerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.tabVacancies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVacancies)).BeginInit();
            this.splitContainerVacancies.Panel1.SuspendLayout();
            this.splitContainerVacancies.Panel2.SuspendLayout();
            this.splitContainerVacancies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEmployers
            // 
            this.tabControlEmployers.Controls.Add(this.tabRegEmployers);
            this.tabControlEmployers.Controls.Add(this.tabInfoEmployers);
            this.tabControlEmployers.Controls.Add(this.tabVacancies);
            this.tabControlEmployers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmployers.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmployers.Name = "tabControlEmployers";
            this.tabControlEmployers.SelectedIndex = 0;
            this.tabControlEmployers.Size = new System.Drawing.Size(758, 498);
            this.tabControlEmployers.TabIndex = 4;
            this.tabControlEmployers.SelectedIndexChanged += new System.EventHandler(this.TabControlEmployersSelectedIndexChanged);
            // 
            // tabRegEmployers
            // 
            this.tabRegEmployers.Controls.Add(this.buttonClearRegistration);
            this.tabRegEmployers.Controls.Add(this.buttonAcceptRegistration);
            this.tabRegEmployers.Controls.Add(this.textBoxEmployerPhoneNumber);
            this.tabRegEmployers.Controls.Add(this.textBoxEmployerAddress);
            this.tabRegEmployers.Controls.Add(this.textBoxITN);
            this.tabRegEmployers.Controls.Add(this.label4);
            this.tabRegEmployers.Controls.Add(this.label3);
            this.tabRegEmployers.Controls.Add(this.label2);
            this.tabRegEmployers.Controls.Add(this.label1);
            this.tabRegEmployers.Controls.Add(this.textBoxEmployerName);
            this.tabRegEmployers.Location = new System.Drawing.Point(4, 22);
            this.tabRegEmployers.Name = "tabRegEmployers";
            this.tabRegEmployers.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegEmployers.Size = new System.Drawing.Size(750, 472);
            this.tabRegEmployers.TabIndex = 0;
            this.tabRegEmployers.Text = "Регистрация";
            this.tabRegEmployers.UseVisualStyleBackColor = true;
            // 
            // buttonClearRegistration
            // 
            this.buttonClearRegistration.Location = new System.Drawing.Point(238, 116);
            this.buttonClearRegistration.Name = "buttonClearRegistration";
            this.buttonClearRegistration.Size = new System.Drawing.Size(95, 23);
            this.buttonClearRegistration.TabIndex = 9;
            this.buttonClearRegistration.Text = "Очистить";
            this.buttonClearRegistration.UseVisualStyleBackColor = true;
            this.buttonClearRegistration.Click += new System.EventHandler(this.buttonClearRegistration_Click);
            // 
            // buttonAcceptRegistration
            // 
            this.buttonAcceptRegistration.Location = new System.Drawing.Point(137, 116);
            this.buttonAcceptRegistration.Name = "buttonAcceptRegistration";
            this.buttonAcceptRegistration.Size = new System.Drawing.Size(95, 23);
            this.buttonAcceptRegistration.TabIndex = 8;
            this.buttonAcceptRegistration.Text = "Принять";
            this.buttonAcceptRegistration.UseVisualStyleBackColor = true;
            this.buttonAcceptRegistration.Click += new System.EventHandler(this.buttonAcceptRegistration_Click);
            // 
            // textBoxEmployerPhoneNumber
            // 
            this.textBoxEmployerPhoneNumber.Location = new System.Drawing.Point(137, 90);
            this.textBoxEmployerPhoneNumber.Name = "textBoxEmployerPhoneNumber";
            this.textBoxEmployerPhoneNumber.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerPhoneNumber.TabIndex = 7;
            // 
            // textBoxEmployerAddress
            // 
            this.textBoxEmployerAddress.Location = new System.Drawing.Point(137, 64);
            this.textBoxEmployerAddress.Name = "textBoxEmployerAddress";
            this.textBoxEmployerAddress.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerAddress.TabIndex = 6;
            // 
            // textBoxITN
            // 
            this.textBoxITN.Location = new System.Drawing.Point(137, 38);
            this.textBoxITN.Name = "textBoxITN";
            this.textBoxITN.Size = new System.Drawing.Size(196, 20);
            this.textBoxITN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИНН предприятия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название предприятия";
            // 
            // textBoxEmployerName
            // 
            this.textBoxEmployerName.Location = new System.Drawing.Point(137, 12);
            this.textBoxEmployerName.Name = "textBoxEmployerName";
            this.textBoxEmployerName.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerName.TabIndex = 0;
            // 
            // tabInfoEmployers
            // 
            this.tabInfoEmployers.Controls.Add(this.splitContainerInfo);
            this.tabInfoEmployers.Location = new System.Drawing.Point(4, 22);
            this.tabInfoEmployers.Name = "tabInfoEmployers";
            this.tabInfoEmployers.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoEmployers.Size = new System.Drawing.Size(750, 472);
            this.tabInfoEmployers.TabIndex = 1;
            this.tabInfoEmployers.Text = "Сведения";
            this.tabInfoEmployers.UseVisualStyleBackColor = true;
            // 
            // splitContainerInfo
            // 
            this.splitContainerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerInfo.Location = new System.Drawing.Point(3, 3);
            this.splitContainerInfo.Name = "splitContainerInfo";
            this.splitContainerInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInfo.Panel1
            // 
            this.splitContainerInfo.Panel1.Controls.Add(this.buttonSearchInfo);
            this.splitContainerInfo.Panel1.Controls.Add(this.textBoxSearchInfo);
            this.splitContainerInfo.Panel1.Controls.Add(this.label5);
            // 
            // splitContainerInfo.Panel2
            // 
            this.splitContainerInfo.Panel2.Controls.Add(this.dataGridInfo);
            this.splitContainerInfo.Size = new System.Drawing.Size(744, 466);
            this.splitContainerInfo.SplitterDistance = 26;
            this.splitContainerInfo.TabIndex = 6;
            // 
            // buttonSearchInfo
            // 
            this.buttonSearchInfo.Location = new System.Drawing.Point(186, 0);
            this.buttonSearchInfo.Name = "buttonSearchInfo";
            this.buttonSearchInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchInfo.TabIndex = 3;
            this.buttonSearchInfo.Text = "Найти";
            this.buttonSearchInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchInfo
            // 
            this.textBoxSearchInfo.Location = new System.Drawing.Point(50, 2);
            this.textBoxSearchInfo.Name = "textBoxSearchInfo";
            this.textBoxSearchInfo.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearchInfo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Поиск";
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnITN,
            this.ColumnAddress,
            this.ColumnPhoneNumber});
            this.dataGridInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.ReadOnly = true;
            this.dataGridInfo.Size = new System.Drawing.Size(744, 436);
            this.dataGridInfo.TabIndex = 1;
            this.dataGridInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInfo_CellEndEdit);
            this.dataGridInfo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridInfo_CellMouseUp);
            this.dataGridInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridInfo_RowsAdded);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя предприятия";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnITN
            // 
            this.ColumnITN.HeaderText = "ИНН";
            this.ColumnITN.Name = "ColumnITN";
            this.ColumnITN.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.HeaderText = "Номер телефона";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            // 
            // tabVacancies
            // 
            this.tabVacancies.Controls.Add(this.splitContainerVacancies);
            this.tabVacancies.Location = new System.Drawing.Point(4, 22);
            this.tabVacancies.Name = "tabVacancies";
            this.tabVacancies.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacancies.Size = new System.Drawing.Size(750, 472);
            this.tabVacancies.TabIndex = 2;
            this.tabVacancies.Text = "Вакансии";
            this.tabVacancies.UseVisualStyleBackColor = true;
            // 
            // splitContainerVacancies
            // 
            this.splitContainerVacancies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVacancies.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerVacancies.Location = new System.Drawing.Point(3, 3);
            this.splitContainerVacancies.Name = "splitContainerVacancies";
            this.splitContainerVacancies.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerVacancies.Panel1
            // 
            this.splitContainerVacancies.Panel1.Controls.Add(this.buttonAddVacancy);
            this.splitContainerVacancies.Panel1.Controls.Add(this.label6);
            this.splitContainerVacancies.Panel1.Controls.Add(this.buttonSearchVacancy);
            this.splitContainerVacancies.Panel1.Controls.Add(this.textBoxSearchVacancy);
            // 
            // splitContainerVacancies.Panel2
            // 
            this.splitContainerVacancies.Panel2.Controls.Add(this.dataGridVacancies);
            this.splitContainerVacancies.Size = new System.Drawing.Size(744, 466);
            this.splitContainerVacancies.SplitterDistance = 25;
            this.splitContainerVacancies.TabIndex = 8;
            // 
            // buttonAddVacancy
            // 
            this.buttonAddVacancy.Location = new System.Drawing.Point(267, 0);
            this.buttonAddVacancy.Name = "buttonAddVacancy";
            this.buttonAddVacancy.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVacancy.TabIndex = 8;
            this.buttonAddVacancy.Text = "Добавить";
            this.buttonAddVacancy.UseVisualStyleBackColor = true;
            this.buttonAddVacancy.Click += new System.EventHandler(this.buttonAddVacancy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Поиск";
            // 
            // buttonSearchVacancy
            // 
            this.buttonSearchVacancy.Location = new System.Drawing.Point(186, 0);
            this.buttonSearchVacancy.Name = "buttonSearchVacancy";
            this.buttonSearchVacancy.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchVacancy.TabIndex = 7;
            this.buttonSearchVacancy.Text = "Найти";
            this.buttonSearchVacancy.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchVacancy
            // 
            this.textBoxSearchVacancy.Location = new System.Drawing.Point(50, 2);
            this.textBoxSearchVacancy.Name = "textBoxSearchVacancy";
            this.textBoxSearchVacancy.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearchVacancy.TabIndex = 4;
            // 
            // dataGridVacancies
            // 
            this.dataGridVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVacancies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVacancyName,
            this.ColumnSpecialty,
            this.ColumnEmployer,
            this.ColumnEmperience,
            this.ColumnEmploymentType,
            this.ColumnSalary,
            this.ColumnDescription});
            this.dataGridVacancies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVacancies.Location = new System.Drawing.Point(0, 0);
            this.dataGridVacancies.Name = "dataGridVacancies";
            this.dataGridVacancies.ReadOnly = true;
            this.dataGridVacancies.Size = new System.Drawing.Size(744, 437);
            this.dataGridVacancies.TabIndex = 5;
            // 
            // ColumnVacancyName
            // 
            this.ColumnVacancyName.HeaderText = "Требуется";
            this.ColumnVacancyName.Name = "ColumnVacancyName";
            this.ColumnVacancyName.ReadOnly = true;
            // 
            // ColumnSpecialty
            // 
            this.ColumnSpecialty.HeaderText = "Направление деятельности";
            this.ColumnSpecialty.Name = "ColumnSpecialty";
            this.ColumnSpecialty.ReadOnly = true;
            // 
            // ColumnEmployer
            // 
            this.ColumnEmployer.HeaderText = "Предприятие";
            this.ColumnEmployer.Name = "ColumnEmployer";
            this.ColumnEmployer.ReadOnly = true;
            // 
            // ColumnEmperience
            // 
            this.ColumnEmperience.HeaderText = "Требуемый опыт";
            this.ColumnEmperience.Name = "ColumnEmperience";
            this.ColumnEmperience.ReadOnly = true;
            // 
            // ColumnEmploymentType
            // 
            this.ColumnEmploymentType.HeaderText = "Тип занятости";
            this.ColumnEmploymentType.Name = "ColumnEmploymentType";
            this.ColumnEmploymentType.ReadOnly = true;
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "Оплата";
            this.ColumnSalary.Name = "ColumnSalary";
            this.ColumnSalary.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Описание";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // FormEmployers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 498);
            this.Controls.Add(this.tabControlEmployers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormEmployers";
            this.Text = "Работа с предприятиями";
            this.tabControlEmployers.ResumeLayout(false);
            this.tabRegEmployers.ResumeLayout(false);
            this.tabRegEmployers.PerformLayout();
            this.tabInfoEmployers.ResumeLayout(false);
            this.splitContainerInfo.Panel1.ResumeLayout(false);
            this.splitContainerInfo.Panel1.PerformLayout();
            this.splitContainerInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).EndInit();
            this.splitContainerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.tabVacancies.ResumeLayout(false);
            this.splitContainerVacancies.Panel1.ResumeLayout(false);
            this.splitContainerVacancies.Panel1.PerformLayout();
            this.splitContainerVacancies.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVacancies)).EndInit();
            this.splitContainerVacancies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacancies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployers;
        private System.Windows.Forms.TabPage tabRegEmployers;
        private System.Windows.Forms.TabPage tabInfoEmployers;
        private System.Windows.Forms.TabPage tabVacancies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmployerPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmployerAddress;
        private System.Windows.Forms.TextBox textBoxITN;
        private System.Windows.Forms.Button buttonAcceptRegistration;
        private System.Windows.Forms.Button buttonClearRegistration;
        private System.Windows.Forms.Button buttonSearchInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.TextBox textBoxSearchInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnITN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.Button buttonSearchVacancy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridVacancies;
        private System.Windows.Forms.TextBox textBoxSearchVacancy;
        private System.Windows.Forms.SplitContainer splitContainerInfo;
        private System.Windows.Forms.SplitContainer splitContainerVacancies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVacancyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmploymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.Button buttonAddVacancy;
    }
}