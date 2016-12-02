namespace Consruction
{
    partial class formEmployers
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
            this.tcEmployers = new System.Windows.Forms.TabControl();
            this.tabRegEmployers = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEmployerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmployerAddress = new System.Windows.Forms.TextBox();
            this.textBoxITN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployerName = new System.Windows.Forms.TextBox();
            this.tabInfoEmployers = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnITN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabVacancies = new System.Windows.Forms.TabPage();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tcEmployers.SuspendLayout();
            this.tabRegEmployers.SuspendLayout();
            this.tabInfoEmployers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEmployers
            // 
            this.tcEmployers.Controls.Add(this.tabRegEmployers);
            this.tcEmployers.Controls.Add(this.tabInfoEmployers);
            this.tcEmployers.Controls.Add(this.tabVacancies);
            this.tcEmployers.Controls.Add(this.tabStatistics);
            this.tcEmployers.Location = new System.Drawing.Point(12, 12);
            this.tcEmployers.Name = "tcEmployers";
            this.tcEmployers.SelectedIndex = 0;
            this.tcEmployers.Size = new System.Drawing.Size(1117, 555);
            this.tcEmployers.TabIndex = 4;
            // 
            // tabRegEmployers
            // 
            this.tabRegEmployers.Controls.Add(this.button2);
            this.tabRegEmployers.Controls.Add(this.button1);
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
            this.tabRegEmployers.Size = new System.Drawing.Size(1109, 529);
            this.tabRegEmployers.TabIndex = 0;
            this.tabRegEmployers.Text = "Регистрация";
            this.tabRegEmployers.UseVisualStyleBackColor = true;
            this.tabRegEmployers.Click += new System.EventHandler(this.tabRegEmployers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabInfoEmployers.Controls.Add(this.button4);
            this.tabInfoEmployers.Controls.Add(this.button3);
            this.tabInfoEmployers.Controls.Add(this.label5);
            this.tabInfoEmployers.Controls.Add(this.dataGridView1);
            this.tabInfoEmployers.Controls.Add(this.textBox1);
            this.tabInfoEmployers.Location = new System.Drawing.Point(4, 22);
            this.tabInfoEmployers.Name = "tabInfoEmployers";
            this.tabInfoEmployers.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoEmployers.Size = new System.Drawing.Size(1109, 529);
            this.tabInfoEmployers.TabIndex = 1;
            this.tabInfoEmployers.Text = "Сведения";
            this.tabInfoEmployers.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Поиск";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnITN,
            this.ColumnAddress,
            this.ColumnPhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(9, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 151);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabVacancies
            // 
            this.tabVacancies.Location = new System.Drawing.Point(4, 22);
            this.tabVacancies.Name = "tabVacancies";
            this.tabVacancies.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacancies.Size = new System.Drawing.Size(1109, 529);
            this.tabVacancies.TabIndex = 2;
            this.tabVacancies.Text = "Вакансии";
            this.tabVacancies.UseVisualStyleBackColor = true;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(1109, 529);
            this.tabStatistics.TabIndex = 3;
            this.tabStatistics.Text = "Статистика";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // formEmployers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 618);
            this.Controls.Add(this.tcEmployers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formEmployers";
            this.Text = "Работа с предприятиями";
            this.tcEmployers.ResumeLayout(false);
            this.tabRegEmployers.ResumeLayout(false);
            this.tabRegEmployers.PerformLayout();
            this.tabInfoEmployers.ResumeLayout(false);
            this.tabInfoEmployers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEmployers;
        private System.Windows.Forms.TabPage tabRegEmployers;
        private System.Windows.Forms.TabPage tabInfoEmployers;
        private System.Windows.Forms.TabPage tabVacancies;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmployerPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmployerAddress;
        private System.Windows.Forms.TextBox textBoxITN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnITN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
    }
}