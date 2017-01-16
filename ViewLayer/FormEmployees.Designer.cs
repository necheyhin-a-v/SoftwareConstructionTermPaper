namespace ViewLayer
{
    partial class FormEmployees
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
            this.tcEmployees = new System.Windows.Forms.TabControl();
            this.tabRegEmployees = new System.Windows.Forms.TabPage();
            this.buttonSelectEmploymentTypes = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSelectSpecialties = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmployerSecondName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmployerLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmployerExperience = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxEmployerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmployerAddress = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployerFirstName = new System.Windows.Forms.TextBox();
            this.tabInfoEmployees = new System.Windows.Forms.TabPage();
            this.splitContainerInfo = new System.Windows.Forms.SplitContainer();
            this.buttonClearSearchInfo = new System.Windows.Forms.Button();
            this.buttonSearchInfo = new System.Windows.Forms.Button();
            this.textBoxSearchInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHasFoundJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabWorkSearch = new System.Windows.Forms.TabPage();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.splitContainerStatictics = new System.Windows.Forms.SplitContainer();
            this.dataGridStatistics = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerStartStatictics = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndStatistics = new System.Windows.Forms.DateTimePicker();
            this.radioButtonShowAll = new System.Windows.Forms.RadioButton();
            this.radioButtonFoundJob = new System.Windows.Forms.RadioButton();
            this.radioButtonNotFoudJob = new System.Windows.Forms.RadioButton();
            this.splitContainerVacancies = new System.Windows.Forms.SplitContainer();
            this.dataGridVacancies = new System.Windows.Forms.DataGridView();
            this.ColumnVacancyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmploymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonRecommendedVacancies = new System.Windows.Forms.RadioButton();
            this.radioButtonAllVacancies = new System.Windows.Forms.RadioButton();
            this.StatisticsColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsColumnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsColumnPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsColumnExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcEmployees.SuspendLayout();
            this.tabRegEmployees.SuspendLayout();
            this.tabInfoEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).BeginInit();
            this.splitContainerInfo.Panel1.SuspendLayout();
            this.splitContainerInfo.Panel2.SuspendLayout();
            this.splitContainerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.tabWorkSearch.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerStatictics)).BeginInit();
            this.splitContainerStatictics.Panel1.SuspendLayout();
            this.splitContainerStatictics.Panel2.SuspendLayout();
            this.splitContainerStatictics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVacancies)).BeginInit();
            this.splitContainerVacancies.Panel1.SuspendLayout();
            this.splitContainerVacancies.Panel2.SuspendLayout();
            this.splitContainerVacancies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEmployees
            // 
            this.tcEmployees.Controls.Add(this.tabRegEmployees);
            this.tcEmployees.Controls.Add(this.tabInfoEmployees);
            this.tcEmployees.Controls.Add(this.tabWorkSearch);
            this.tcEmployees.Controls.Add(this.tabStatistic);
            this.tcEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEmployees.Location = new System.Drawing.Point(0, 0);
            this.tcEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcEmployees.Name = "tcEmployees";
            this.tcEmployees.SelectedIndex = 0;
            this.tcEmployees.Size = new System.Drawing.Size(886, 508);
            this.tcEmployees.TabIndex = 4;
            this.tcEmployees.SelectedIndexChanged += new System.EventHandler(this.tcEmployees_SelectedIndexChanged);
            this.tcEmployees.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcEmployees_Selecting);
            this.tcEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcEmployees_KeyDown);
            // 
            // tabRegEmployees
            // 
            this.tabRegEmployees.Controls.Add(this.buttonSelectEmploymentTypes);
            this.tabRegEmployees.Controls.Add(this.label12);
            this.tabRegEmployees.Controls.Add(this.buttonSelectSpecialties);
            this.tabRegEmployees.Controls.Add(this.label10);
            this.tabRegEmployees.Controls.Add(this.textBoxEmployerSecondName);
            this.tabRegEmployees.Controls.Add(this.label9);
            this.tabRegEmployees.Controls.Add(this.textBoxEmployerLastName);
            this.tabRegEmployees.Controls.Add(this.textBoxEmployerExperience);
            this.tabRegEmployees.Controls.Add(this.label6);
            this.tabRegEmployees.Controls.Add(this.label5);
            this.tabRegEmployees.Controls.Add(this.buttonClear);
            this.tabRegEmployees.Controls.Add(this.buttonCreate);
            this.tabRegEmployees.Controls.Add(this.textBoxEmployerPhoneNumber);
            this.tabRegEmployees.Controls.Add(this.textBoxEmployerAddress);
            this.tabRegEmployees.Controls.Add(this.textBoxPassport);
            this.tabRegEmployees.Controls.Add(this.label4);
            this.tabRegEmployees.Controls.Add(this.label3);
            this.tabRegEmployees.Controls.Add(this.label2);
            this.tabRegEmployees.Controls.Add(this.label1);
            this.tabRegEmployees.Controls.Add(this.textBoxEmployerFirstName);
            this.tabRegEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabRegEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRegEmployees.Name = "tabRegEmployees";
            this.tabRegEmployees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRegEmployees.Size = new System.Drawing.Size(1149, 554);
            this.tabRegEmployees.TabIndex = 0;
            this.tabRegEmployees.Text = "Регистрация";
            this.tabRegEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonSelectEmploymentTypes
            // 
            this.buttonSelectEmploymentTypes.Location = new System.Drawing.Point(192, 287);
            this.buttonSelectEmploymentTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectEmploymentTypes.Name = "buttonSelectEmploymentTypes";
            this.buttonSelectEmploymentTypes.Size = new System.Drawing.Size(127, 28);
            this.buttonSelectEmploymentTypes.TabIndex = 30;
            this.buttonSelectEmploymentTypes.Text = "Выбрать";
            this.buttonSelectEmploymentTypes.UseVisualStyleBackColor = true;
            this.buttonSelectEmploymentTypes.Click += new System.EventHandler(this.buttonSelectEmploymentTypes_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 283);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 34);
            this.label12.TabIndex = 29;
            this.label12.Text = "Препочитаемые \r\nтипы занятости";
            // 
            // buttonSelectSpecialties
            // 
            this.buttonSelectSpecialties.Location = new System.Drawing.Point(192, 244);
            this.buttonSelectSpecialties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectSpecialties.Name = "buttonSelectSpecialties";
            this.buttonSelectSpecialties.Size = new System.Drawing.Size(127, 28);
            this.buttonSelectSpecialties.TabIndex = 28;
            this.buttonSelectSpecialties.Text = "Выбрать";
            this.buttonSelectSpecialties.UseVisualStyleBackColor = true;
            this.buttonSelectSpecialties.Click += new System.EventHandler(this.buttonSelectSpecialties_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Отчество работника";
            // 
            // textBoxEmployerSecondName
            // 
            this.textBoxEmployerSecondName.Location = new System.Drawing.Point(192, 76);
            this.textBoxEmployerSecondName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployerSecondName.Name = "textBoxEmployerSecondName";
            this.textBoxEmployerSecondName.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmployerSecondName.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Фамилия работника";
            // 
            // textBoxEmployerLastName
            // 
            this.textBoxEmployerLastName.Location = new System.Drawing.Point(192, 44);
            this.textBoxEmployerLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployerLastName.Name = "textBoxEmployerLastName";
            this.textBoxEmployerLastName.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmployerLastName.TabIndex = 24;
            // 
            // textBoxEmployerExperience
            // 
            this.textBoxEmployerExperience.Location = new System.Drawing.Point(192, 204);
            this.textBoxEmployerExperience.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployerExperience.Name = "textBoxEmployerExperience";
            this.textBoxEmployerExperience.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmployerExperience.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "Препочитаемые \r\nспециальности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Стаж работы (месяцы)";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(327, 340);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 28);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(192, 340);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(127, 28);
            this.buttonCreate.TabIndex = 18;
            this.buttonCreate.Text = "Принять";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxEmployerPhoneNumber
            // 
            this.textBoxEmployerPhoneNumber.Location = new System.Drawing.Point(192, 172);
            this.textBoxEmployerPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployerPhoneNumber.Name = "textBoxEmployerPhoneNumber";
            this.textBoxEmployerPhoneNumber.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmployerPhoneNumber.TabIndex = 17;
            // 
            // textBoxEmployerAddress
            // 
            this.textBoxEmployerAddress.Location = new System.Drawing.Point(192, 140);
            this.textBoxEmployerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployerAddress.Name = "textBoxEmployerAddress";
            this.textBoxEmployerAddress.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmployerAddress.TabIndex = 16;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(192, 108);
            this.textBoxPassport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(260, 22);
            this.textBoxPassport.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Адрес проживания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Серия и номер паспорта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя работника";
            // 
            // textBoxEmployerFirstName
            // 
            this.textBoxEmployerFirstName.Location = new System.Drawing.Point(192, 12);
            this.textBoxEmployerFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployerFirstName.Name = "textBoxEmployerFirstName";
            this.textBoxEmployerFirstName.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmployerFirstName.TabIndex = 10;
            // 
            // tabInfoEmployees
            // 
            this.tabInfoEmployees.Controls.Add(this.splitContainerInfo);
            this.tabInfoEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabInfoEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInfoEmployees.Name = "tabInfoEmployees";
            this.tabInfoEmployees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInfoEmployees.Size = new System.Drawing.Size(878, 479);
            this.tabInfoEmployees.TabIndex = 1;
            this.tabInfoEmployees.Text = "Сведения";
            this.tabInfoEmployees.UseVisualStyleBackColor = true;
            // 
            // splitContainerInfo
            // 
            this.splitContainerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerInfo.IsSplitterFixed = true;
            this.splitContainerInfo.Location = new System.Drawing.Point(4, 4);
            this.splitContainerInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerInfo.Name = "splitContainerInfo";
            this.splitContainerInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInfo.Panel1
            // 
            this.splitContainerInfo.Panel1.Controls.Add(this.buttonClearSearchInfo);
            this.splitContainerInfo.Panel1.Controls.Add(this.buttonSearchInfo);
            this.splitContainerInfo.Panel1.Controls.Add(this.textBoxSearchInfo);
            this.splitContainerInfo.Panel1.Controls.Add(this.label11);
            // 
            // splitContainerInfo.Panel2
            // 
            this.splitContainerInfo.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainerInfo.Panel2.Controls.Add(this.dataGridInfo);
            this.splitContainerInfo.Size = new System.Drawing.Size(870, 471);
            this.splitContainerInfo.SplitterDistance = 26;
            this.splitContainerInfo.SplitterWidth = 5;
            this.splitContainerInfo.TabIndex = 0;
            // 
            // buttonClearSearchInfo
            // 
            this.buttonClearSearchInfo.Location = new System.Drawing.Point(359, 1);
            this.buttonClearSearchInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearSearchInfo.Name = "buttonClearSearchInfo";
            this.buttonClearSearchInfo.Size = new System.Drawing.Size(100, 28);
            this.buttonClearSearchInfo.TabIndex = 8;
            this.buttonClearSearchInfo.Text = "Сбросить";
            this.buttonClearSearchInfo.UseVisualStyleBackColor = true;
            this.buttonClearSearchInfo.Click += new System.EventHandler(this.buttonClearSearchInfo_Click);
            // 
            // buttonSearchInfo
            // 
            this.buttonSearchInfo.Location = new System.Drawing.Point(251, 1);
            this.buttonSearchInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchInfo.Name = "buttonSearchInfo";
            this.buttonSearchInfo.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchInfo.TabIndex = 7;
            this.buttonSearchInfo.Text = "Найти";
            this.buttonSearchInfo.UseVisualStyleBackColor = true;
            this.buttonSearchInfo.Click += new System.EventHandler(this.buttonSearchInfo_Click);
            // 
            // textBoxSearchInfo
            // 
            this.textBoxSearchInfo.Location = new System.Drawing.Point(69, 4);
            this.textBoxSearchInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchInfo.Name = "textBoxSearchInfo";
            this.textBoxSearchInfo.Size = new System.Drawing.Size(172, 22);
            this.textBoxSearchInfo.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Поиск";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(4, 4);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(129, 22);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.AllowUserToAddRows = false;
            this.dataGridInfo.AllowUserToResizeRows = false;
            this.dataGridInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirstName,
            this.ColumnMiddleName,
            this.ColumnSecondName,
            this.ColumnPassport,
            this.ColumnAddress,
            this.ColumnPhoneNumber,
            this.ColumnExperience,
            this.ColumnHasFoundJob});
            this.dataGridInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridInfo.MultiSelect = false;
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.ReadOnly = true;
            this.dataGridInfo.RowTemplate.Height = 20;
            this.dataGridInfo.Size = new System.Drawing.Size(870, 440);
            this.dataGridInfo.TabIndex = 2;
            this.dataGridInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInfo_CellEndEdit);
            this.dataGridInfo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridInfo_CellMouseUp);
            this.dataGridInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridInfo_RowsAdded);
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.HeaderText = "Имя";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // ColumnMiddleName
            // 
            this.ColumnMiddleName.HeaderText = "Отчество";
            this.ColumnMiddleName.Name = "ColumnMiddleName";
            this.ColumnMiddleName.ReadOnly = true;
            // 
            // ColumnSecondName
            // 
            this.ColumnSecondName.HeaderText = "Фамилия";
            this.ColumnSecondName.Name = "ColumnSecondName";
            this.ColumnSecondName.ReadOnly = true;
            // 
            // ColumnPassport
            // 
            this.ColumnPassport.HeaderText = "Паспорт";
            this.ColumnPassport.Name = "ColumnPassport";
            this.ColumnPassport.ReadOnly = true;
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
            // ColumnExperience
            // 
            this.ColumnExperience.HeaderText = "Опыт работы";
            this.ColumnExperience.Name = "ColumnExperience";
            this.ColumnExperience.ReadOnly = true;
            // 
            // ColumnHasFoundJob
            // 
            this.ColumnHasFoundJob.HeaderText = "Трудоустроен с помощью службы";
            this.ColumnHasFoundJob.Name = "ColumnHasFoundJob";
            this.ColumnHasFoundJob.ReadOnly = true;
            // 
            // tabWorkSearch
            // 
            this.tabWorkSearch.Controls.Add(this.splitContainerVacancies);
            this.tabWorkSearch.Location = new System.Drawing.Point(4, 25);
            this.tabWorkSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabWorkSearch.Name = "tabWorkSearch";
            this.tabWorkSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabWorkSearch.Size = new System.Drawing.Size(878, 479);
            this.tabWorkSearch.TabIndex = 2;
            this.tabWorkSearch.Text = "Поиск работы";
            this.tabWorkSearch.UseVisualStyleBackColor = true;
            // 
            // tabStatistic
            // 
            this.tabStatistic.Controls.Add(this.splitContainerStatictics);
            this.tabStatistic.Location = new System.Drawing.Point(4, 25);
            this.tabStatistic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStatistic.Size = new System.Drawing.Size(880, 539);
            this.tabStatistic.TabIndex = 3;
            this.tabStatistic.Text = "Статистика";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // splitContainerStatictics
            // 
            this.splitContainerStatictics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerStatictics.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerStatictics.Location = new System.Drawing.Point(4, 4);
            this.splitContainerStatictics.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerStatictics.Name = "splitContainerStatictics";
            this.splitContainerStatictics.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerStatictics.Panel1
            // 
            this.splitContainerStatictics.Panel1.Controls.Add(this.radioButtonNotFoudJob);
            this.splitContainerStatictics.Panel1.Controls.Add(this.radioButtonFoundJob);
            this.splitContainerStatictics.Panel1.Controls.Add(this.radioButtonShowAll);
            this.splitContainerStatictics.Panel1.Controls.Add(this.dateTimePickerEndStatistics);
            this.splitContainerStatictics.Panel1.Controls.Add(this.dateTimePickerStartStatictics);
            this.splitContainerStatictics.Panel1.Controls.Add(this.label8);
            this.splitContainerStatictics.Panel1.Controls.Add(this.label7);
            // 
            // splitContainerStatictics.Panel2
            // 
            this.splitContainerStatictics.Panel2.Controls.Add(this.dataGridStatistics);
            this.splitContainerStatictics.Size = new System.Drawing.Size(872, 531);
            this.splitContainerStatictics.SplitterDistance = 76;
            this.splitContainerStatictics.SplitterWidth = 5;
            this.splitContainerStatictics.TabIndex = 1;
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.AllowUserToAddRows = false;
            this.dataGridStatistics.AllowUserToResizeRows = false;
            this.dataGridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatisticsColumnFirstName,
            this.StatisticsColumnMiddleName,
            this.StatisticsColumnSecondName,
            this.StatisticsColumnPassport,
            this.StatisticsColumnAddress,
            this.StatisticsColumnPhone,
            this.StatisticsColumnExperience});
            this.dataGridStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridStatistics.MultiSelect = false;
            this.dataGridStatistics.Name = "dataGridStatistics";
            this.dataGridStatistics.ReadOnly = true;
            this.dataGridStatistics.RowTemplate.Height = 20;
            this.dataGridStatistics.Size = new System.Drawing.Size(872, 450);
            this.dataGridStatistics.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата начала периода\r\nстатистики";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "Дата окончания периода\r\nстатистики";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerStartStatictics
            // 
            this.dateTimePickerStartStatictics.Enabled = false;
            this.dateTimePickerStartStatictics.Location = new System.Drawing.Point(22, 44);
            this.dateTimePickerStartStatictics.Name = "dateTimePickerStartStatictics";
            this.dateTimePickerStartStatictics.Size = new System.Drawing.Size(174, 22);
            this.dateTimePickerStartStatictics.TabIndex = 7;
            this.dateTimePickerStartStatictics.ValueChanged += new System.EventHandler(this.dateRangeValueChanged);
            // 
            // dateTimePickerEndStatistics
            // 
            this.dateTimePickerEndStatistics.Enabled = false;
            this.dateTimePickerEndStatistics.Location = new System.Drawing.Point(202, 44);
            this.dateTimePickerEndStatistics.Name = "dateTimePickerEndStatistics";
            this.dateTimePickerEndStatistics.Size = new System.Drawing.Size(174, 22);
            this.dateTimePickerEndStatistics.TabIndex = 8;
            // 
            // radioButtonShowAll
            // 
            this.radioButtonShowAll.AutoSize = true;
            this.radioButtonShowAll.Checked = true;
            this.radioButtonShowAll.Location = new System.Drawing.Point(403, 4);
            this.radioButtonShowAll.Name = "radioButtonShowAll";
            this.radioButtonShowAll.Size = new System.Drawing.Size(123, 21);
            this.radioButtonShowAll.TabIndex = 9;
            this.radioButtonShowAll.TabStop = true;
            this.radioButtonShowAll.Text = "Показать всех";
            this.radioButtonShowAll.UseVisualStyleBackColor = true;
            this.radioButtonShowAll.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // radioButtonFoundJob
            // 
            this.radioButtonFoundJob.AutoSize = true;
            this.radioButtonFoundJob.Location = new System.Drawing.Point(403, 25);
            this.radioButtonFoundJob.Name = "radioButtonFoundJob";
            this.radioButtonFoundJob.Size = new System.Drawing.Size(148, 21);
            this.radioButtonFoundJob.TabIndex = 10;
            this.radioButtonFoundJob.Text = "Трудоустроенные";
            this.radioButtonFoundJob.UseVisualStyleBackColor = true;
            this.radioButtonFoundJob.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // radioButtonNotFoudJob
            // 
            this.radioButtonNotFoudJob.AutoSize = true;
            this.radioButtonNotFoudJob.Location = new System.Drawing.Point(403, 47);
            this.radioButtonNotFoudJob.Name = "radioButtonNotFoudJob";
            this.radioButtonNotFoudJob.Size = new System.Drawing.Size(168, 21);
            this.radioButtonNotFoudJob.TabIndex = 11;
            this.radioButtonNotFoudJob.Text = "Не трудоустроенные";
            this.radioButtonNotFoudJob.UseVisualStyleBackColor = true;
            this.radioButtonNotFoudJob.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // splitContainerVacancies
            // 
            this.splitContainerVacancies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVacancies.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerVacancies.Location = new System.Drawing.Point(4, 4);
            this.splitContainerVacancies.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerVacancies.Name = "splitContainerVacancies";
            this.splitContainerVacancies.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerVacancies.Panel1
            // 
            this.splitContainerVacancies.Panel1.Controls.Add(this.radioButtonAllVacancies);
            this.splitContainerVacancies.Panel1.Controls.Add(this.radioButtonRecommendedVacancies);
            // 
            // splitContainerVacancies.Panel2
            // 
            this.splitContainerVacancies.Panel2.Controls.Add(this.dataGridVacancies);
            this.splitContainerVacancies.Size = new System.Drawing.Size(870, 471);
            this.splitContainerVacancies.SplitterDistance = 25;
            this.splitContainerVacancies.SplitterWidth = 5;
            this.splitContainerVacancies.TabIndex = 9;
            // 
            // dataGridVacancies
            // 
            this.dataGridVacancies.AllowUserToAddRows = false;
            this.dataGridVacancies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridVacancies.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVacancies.MultiSelect = false;
            this.dataGridVacancies.Name = "dataGridVacancies";
            this.dataGridVacancies.ReadOnly = true;
            this.dataGridVacancies.Size = new System.Drawing.Size(870, 441);
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
            // radioButtonRecommendedVacancies
            // 
            this.radioButtonRecommendedVacancies.AutoSize = true;
            this.radioButtonRecommendedVacancies.Checked = true;
            this.radioButtonRecommendedVacancies.Location = new System.Drawing.Point(4, 3);
            this.radioButtonRecommendedVacancies.Name = "radioButtonRecommendedVacancies";
            this.radioButtonRecommendedVacancies.Size = new System.Drawing.Size(201, 21);
            this.radioButtonRecommendedVacancies.TabIndex = 0;
            this.radioButtonRecommendedVacancies.TabStop = true;
            this.radioButtonRecommendedVacancies.Text = "Рекомендуемые вакансии";
            this.radioButtonRecommendedVacancies.UseVisualStyleBackColor = true;
            this.radioButtonRecommendedVacancies.CheckedChanged += new System.EventHandler(this.radioButtonSuggestVacancyChanged);
            // 
            // radioButtonAllVacancies
            // 
            this.radioButtonAllVacancies.AutoSize = true;
            this.radioButtonAllVacancies.Location = new System.Drawing.Point(211, 3);
            this.radioButtonAllVacancies.Name = "radioButtonAllVacancies";
            this.radioButtonAllVacancies.Size = new System.Drawing.Size(118, 21);
            this.radioButtonAllVacancies.TabIndex = 1;
            this.radioButtonAllVacancies.Text = "Все вакансии";
            this.radioButtonAllVacancies.UseVisualStyleBackColor = true;
            // 
            // StatisticsColumnFirstName
            // 
            this.StatisticsColumnFirstName.HeaderText = "Имя";
            this.StatisticsColumnFirstName.Name = "StatisticsColumnFirstName";
            this.StatisticsColumnFirstName.ReadOnly = true;
            // 
            // StatisticsColumnMiddleName
            // 
            this.StatisticsColumnMiddleName.HeaderText = "Отчество";
            this.StatisticsColumnMiddleName.Name = "StatisticsColumnMiddleName";
            this.StatisticsColumnMiddleName.ReadOnly = true;
            // 
            // StatisticsColumnSecondName
            // 
            this.StatisticsColumnSecondName.HeaderText = "Фамилия";
            this.StatisticsColumnSecondName.Name = "StatisticsColumnSecondName";
            this.StatisticsColumnSecondName.ReadOnly = true;
            // 
            // StatisticsColumnPassport
            // 
            this.StatisticsColumnPassport.HeaderText = "Паспорт";
            this.StatisticsColumnPassport.Name = "StatisticsColumnPassport";
            this.StatisticsColumnPassport.ReadOnly = true;
            // 
            // StatisticsColumnAddress
            // 
            this.StatisticsColumnAddress.HeaderText = "Адрес";
            this.StatisticsColumnAddress.Name = "StatisticsColumnAddress";
            this.StatisticsColumnAddress.ReadOnly = true;
            // 
            // StatisticsColumnPhone
            // 
            this.StatisticsColumnPhone.HeaderText = "Номер телефона";
            this.StatisticsColumnPhone.Name = "StatisticsColumnPhone";
            this.StatisticsColumnPhone.ReadOnly = true;
            // 
            // StatisticsColumnExperience
            // 
            this.StatisticsColumnExperience.HeaderText = "Опыт работы";
            this.StatisticsColumnExperience.Name = "StatisticsColumnExperience";
            this.StatisticsColumnExperience.ReadOnly = true;
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 508);
            this.Controls.Add(this.tcEmployees);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEmployees";
            this.Text = "Работа с работниками";
            this.tcEmployees.ResumeLayout(false);
            this.tabRegEmployees.ResumeLayout(false);
            this.tabRegEmployees.PerformLayout();
            this.tabInfoEmployees.ResumeLayout(false);
            this.splitContainerInfo.Panel1.ResumeLayout(false);
            this.splitContainerInfo.Panel1.PerformLayout();
            this.splitContainerInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).EndInit();
            this.splitContainerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.tabWorkSearch.ResumeLayout(false);
            this.tabStatistic.ResumeLayout(false);
            this.splitContainerStatictics.Panel1.ResumeLayout(false);
            this.splitContainerStatictics.Panel1.PerformLayout();
            this.splitContainerStatictics.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerStatictics)).EndInit();
            this.splitContainerStatictics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.splitContainerVacancies.Panel1.ResumeLayout(false);
            this.splitContainerVacancies.Panel1.PerformLayout();
            this.splitContainerVacancies.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVacancies)).EndInit();
            this.splitContainerVacancies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacancies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcEmployees;
        private System.Windows.Forms.TabPage tabRegEmployees;
        private System.Windows.Forms.TabPage tabInfoEmployees;
        private System.Windows.Forms.TabPage tabWorkSearch;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxEmployerPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmployerAddress;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployerFirstName;
        private System.Windows.Forms.TextBox textBoxEmployerExperience;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainerInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEmployerSecondName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmployerLastName;
        private System.Windows.Forms.Button buttonClearSearchInfo;
        private System.Windows.Forms.Button buttonSearchInfo;
        private System.Windows.Forms.TextBox textBoxSearchInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.Button buttonSelectSpecialties;
        private System.Windows.Forms.Button buttonSelectEmploymentTypes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHasFoundJob;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.SplitContainer splitContainerStatictics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridStatistics;
        private System.Windows.Forms.RadioButton radioButtonNotFoudJob;
        private System.Windows.Forms.RadioButton radioButtonFoundJob;
        private System.Windows.Forms.RadioButton radioButtonShowAll;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndStatistics;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartStatictics;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainerVacancies;
        private System.Windows.Forms.RadioButton radioButtonAllVacancies;
        private System.Windows.Forms.RadioButton radioButtonRecommendedVacancies;
        private System.Windows.Forms.DataGridView dataGridVacancies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVacancyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmploymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatisticsColumnExperience;
    }
}