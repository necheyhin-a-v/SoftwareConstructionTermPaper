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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tcEmployees.Name = "tcEmployees";
            this.tcEmployees.SelectedIndex = 0;
            this.tcEmployees.Size = new System.Drawing.Size(868, 541);
            this.tcEmployees.TabIndex = 4;
            this.tcEmployees.SelectedIndexChanged += new System.EventHandler(this.tcEmployees_SelectedIndexChanged);
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
            this.tabRegEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabRegEmployees.Name = "tabRegEmployees";
            this.tabRegEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegEmployees.Size = new System.Drawing.Size(860, 515);
            this.tabRegEmployees.TabIndex = 0;
            this.tabRegEmployees.Text = "Регистрация";
            this.tabRegEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonSelectEmploymentTypes
            // 
            this.buttonSelectEmploymentTypes.Location = new System.Drawing.Point(144, 233);
            this.buttonSelectEmploymentTypes.Name = "buttonSelectEmploymentTypes";
            this.buttonSelectEmploymentTypes.Size = new System.Drawing.Size(95, 23);
            this.buttonSelectEmploymentTypes.TabIndex = 30;
            this.buttonSelectEmploymentTypes.Text = "Выбрать";
            this.buttonSelectEmploymentTypes.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 26);
            this.label12.TabIndex = 29;
            this.label12.Text = "Препочитаемые \r\nтипы занятости";
            // 
            // buttonSelectSpecialties
            // 
            this.buttonSelectSpecialties.Location = new System.Drawing.Point(144, 198);
            this.buttonSelectSpecialties.Name = "buttonSelectSpecialties";
            this.buttonSelectSpecialties.Size = new System.Drawing.Size(95, 23);
            this.buttonSelectSpecialties.TabIndex = 28;
            this.buttonSelectSpecialties.Text = "Выбрать";
            this.buttonSelectSpecialties.UseVisualStyleBackColor = true;
            this.buttonSelectSpecialties.Click += new System.EventHandler(this.buttonSelectSpecialties_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Отчество работника";
            // 
            // textBoxEmployerSecondName
            // 
            this.textBoxEmployerSecondName.Location = new System.Drawing.Point(144, 62);
            this.textBoxEmployerSecondName.Name = "textBoxEmployerSecondName";
            this.textBoxEmployerSecondName.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerSecondName.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Фамилия работника";
            // 
            // textBoxEmployerLastName
            // 
            this.textBoxEmployerLastName.Location = new System.Drawing.Point(144, 36);
            this.textBoxEmployerLastName.Name = "textBoxEmployerLastName";
            this.textBoxEmployerLastName.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerLastName.TabIndex = 24;
            // 
            // textBoxEmployerExperience
            // 
            this.textBoxEmployerExperience.Location = new System.Drawing.Point(144, 166);
            this.textBoxEmployerExperience.Name = "textBoxEmployerExperience";
            this.textBoxEmployerExperience.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerExperience.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Препочитаемые \r\nспециальности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Стаж работы (месяцы)";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(245, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 23);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(144, 276);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(95, 23);
            this.buttonCreate.TabIndex = 18;
            this.buttonCreate.Text = "Принять";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxEmployerPhoneNumber
            // 
            this.textBoxEmployerPhoneNumber.Location = new System.Drawing.Point(144, 140);
            this.textBoxEmployerPhoneNumber.Name = "textBoxEmployerPhoneNumber";
            this.textBoxEmployerPhoneNumber.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerPhoneNumber.TabIndex = 17;
            // 
            // textBoxEmployerAddress
            // 
            this.textBoxEmployerAddress.Location = new System.Drawing.Point(144, 114);
            this.textBoxEmployerAddress.Name = "textBoxEmployerAddress";
            this.textBoxEmployerAddress.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerAddress.TabIndex = 16;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(144, 88);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(196, 20);
            this.textBoxPassport.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Адрес проживания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Серия и номер паспорта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя работника";
            // 
            // textBoxEmployerFirstName
            // 
            this.textBoxEmployerFirstName.Location = new System.Drawing.Point(144, 10);
            this.textBoxEmployerFirstName.Name = "textBoxEmployerFirstName";
            this.textBoxEmployerFirstName.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmployerFirstName.TabIndex = 10;
            // 
            // tabInfoEmployees
            // 
            this.tabInfoEmployees.Controls.Add(this.splitContainerInfo);
            this.tabInfoEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabInfoEmployees.Name = "tabInfoEmployees";
            this.tabInfoEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoEmployees.Size = new System.Drawing.Size(860, 515);
            this.tabInfoEmployees.TabIndex = 1;
            this.tabInfoEmployees.Text = "Сведения";
            this.tabInfoEmployees.UseVisualStyleBackColor = true;
            // 
            // splitContainerInfo
            // 
            this.splitContainerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerInfo.IsSplitterFixed = true;
            this.splitContainerInfo.Location = new System.Drawing.Point(3, 3);
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
            this.splitContainerInfo.Size = new System.Drawing.Size(854, 509);
            this.splitContainerInfo.SplitterDistance = 26;
            this.splitContainerInfo.TabIndex = 0;
            // 
            // buttonClearSearchInfo
            // 
            this.buttonClearSearchInfo.Location = new System.Drawing.Point(269, 1);
            this.buttonClearSearchInfo.Name = "buttonClearSearchInfo";
            this.buttonClearSearchInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSearchInfo.TabIndex = 8;
            this.buttonClearSearchInfo.Text = "Сбросить";
            this.buttonClearSearchInfo.UseVisualStyleBackColor = true;
            this.buttonClearSearchInfo.Click += new System.EventHandler(this.buttonClearSearchInfo_Click);
            // 
            // buttonSearchInfo
            // 
            this.buttonSearchInfo.Location = new System.Drawing.Point(188, 1);
            this.buttonSearchInfo.Name = "buttonSearchInfo";
            this.buttonSearchInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchInfo.TabIndex = 7;
            this.buttonSearchInfo.Text = "Найти";
            this.buttonSearchInfo.UseVisualStyleBackColor = true;
            this.buttonSearchInfo.Click += new System.EventHandler(this.buttonSearchInfo_Click);
            // 
            // textBoxSearchInfo
            // 
            this.textBoxSearchInfo.Location = new System.Drawing.Point(52, 3);
            this.textBoxSearchInfo.Name = "textBoxSearchInfo";
            this.textBoxSearchInfo.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearchInfo.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Поиск";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(751, 49);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // dataGridInfo
            // 
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
            this.dataGridInfo.MultiSelect = false;
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.ReadOnly = true;
            this.dataGridInfo.RowTemplate.Height = 20;
            this.dataGridInfo.Size = new System.Drawing.Size(854, 479);
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
            this.tabWorkSearch.Controls.Add(this.dateTimePicker1);
            this.tabWorkSearch.Location = new System.Drawing.Point(4, 22);
            this.tabWorkSearch.Name = "tabWorkSearch";
            this.tabWorkSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkSearch.Size = new System.Drawing.Size(860, 515);
            this.tabWorkSearch.TabIndex = 2;
            this.tabWorkSearch.Text = "Поиск работы";
            this.tabWorkSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabStatistic
            // 
            this.tabStatistic.Controls.Add(this.radioButton2);
            this.tabStatistic.Controls.Add(this.radioButton1);
            this.tabStatistic.Controls.Add(this.dataGridView1);
            this.tabStatistic.Controls.Add(this.label8);
            this.tabStatistic.Controls.Add(this.label7);
            this.tabStatistic.Controls.Add(this.monthCalendar2);
            this.tabStatistic.Controls.Add(this.monthCalendar1);
            this.tabStatistic.Location = new System.Drawing.Point(4, 22);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistic.Size = new System.Drawing.Size(860, 515);
            this.tabStatistic.TabIndex = 3;
            this.tabStatistic.Text = "Статистика";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(388, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(388, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 217);
            this.dataGridView1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(185, 37);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 541);
            this.Controls.Add(this.tcEmployees);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
            this.tabStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}