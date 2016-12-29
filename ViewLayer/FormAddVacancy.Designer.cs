namespace ViewLayer
{
    partial class FormAddVacancy
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
            this.buttonDeclineVacancy = new System.Windows.Forms.Button();
            this.buttonAcceptVacancy = new System.Windows.Forms.Button();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.textBoxFirmINN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRequire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.comboBoxEmploymentType = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.specialtyAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeclineVacancy
            // 
            this.buttonDeclineVacancy.Location = new System.Drawing.Point(261, 196);
            this.buttonDeclineVacancy.Name = "buttonDeclineVacancy";
            this.buttonDeclineVacancy.Size = new System.Drawing.Size(95, 23);
            this.buttonDeclineVacancy.TabIndex = 19;
            this.buttonDeclineVacancy.Text = "Отменить";
            this.buttonDeclineVacancy.UseVisualStyleBackColor = true;
            this.buttonDeclineVacancy.Click += new System.EventHandler(this.buttonDeclineVacancy_Click);
            // 
            // buttonAcceptVacancy
            // 
            this.buttonAcceptVacancy.Location = new System.Drawing.Point(160, 196);
            this.buttonAcceptVacancy.Name = "buttonAcceptVacancy";
            this.buttonAcceptVacancy.Size = new System.Drawing.Size(95, 23);
            this.buttonAcceptVacancy.TabIndex = 18;
            this.buttonAcceptVacancy.Text = "Принять";
            this.buttonAcceptVacancy.UseVisualStyleBackColor = true;
            this.buttonAcceptVacancy.Click += new System.EventHandler(this.buttonAcceptVacancy_Click);
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(160, 90);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(196, 20);
            this.textBoxExperience.TabIndex = 17;
            // 
            // textBoxFirmINN
            // 
            this.textBoxFirmINN.Location = new System.Drawing.Point(160, 64);
            this.textBoxFirmINN.Name = "textBoxFirmINN";
            this.textBoxFirmINN.Size = new System.Drawing.Size(196, 20);
            this.textBoxFirmINN.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Требуемый опыт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ИНН предприятие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Направление деятельности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Требуется";
            // 
            // textBoxRequire
            // 
            this.textBoxRequire.Location = new System.Drawing.Point(160, 12);
            this.textBoxRequire.Name = "textBoxRequire";
            this.textBoxRequire.Size = new System.Drawing.Size(196, 20);
            this.textBoxRequire.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Оплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Тип занятости";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(160, 170);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(196, 20);
            this.textBoxDescription.TabIndex = 25;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(160, 144);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(196, 20);
            this.textBoxSalary.TabIndex = 24;
            // 
            // comboBoxEmploymentType
            // 
            this.comboBoxEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmploymentType.FormattingEnabled = true;
            this.comboBoxEmploymentType.Location = new System.Drawing.Point(160, 118);
            this.comboBoxEmploymentType.Name = "comboBoxEmploymentType";
            this.comboBoxEmploymentType.Size = new System.Drawing.Size(194, 21);
            this.comboBoxEmploymentType.TabIndex = 26;
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Location = new System.Drawing.Point(160, 37);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.Size = new System.Drawing.Size(194, 21);
            this.comboBoxSpecialty.TabIndex = 27;
            // 
            // specialtyAddButton
            // 
            this.specialtyAddButton.Location = new System.Drawing.Point(360, 35);
            this.specialtyAddButton.Name = "specialtyAddButton";
            this.specialtyAddButton.Size = new System.Drawing.Size(66, 23);
            this.specialtyAddButton.TabIndex = 28;
            this.specialtyAddButton.Text = "Добавить";
            this.specialtyAddButton.UseVisualStyleBackColor = true;
            this.specialtyAddButton.Click += new System.EventHandler(this.specialtyAddButton_Click);
            // 
            // FormAddVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 223);
            this.Controls.Add(this.specialtyAddButton);
            this.Controls.Add(this.comboBoxSpecialty);
            this.Controls.Add(this.comboBoxEmploymentType);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDeclineVacancy);
            this.Controls.Add(this.buttonAcceptVacancy);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.textBoxFirmINN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRequire);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddVacancy";
            this.Text = "Добавление вакансии";
            this.Load += new System.EventHandler(this.FormAddVacancy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeclineVacancy;
        private System.Windows.Forms.Button buttonAcceptVacancy;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.TextBox textBoxFirmINN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRequire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ComboBox comboBoxEmploymentType;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private System.Windows.Forms.Button specialtyAddButton;
    }
}