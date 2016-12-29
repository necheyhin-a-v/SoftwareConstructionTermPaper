namespace ViewLayer
{
    partial class FormAddSpecialty
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
            this.buttonDeclineSpecialty = new System.Windows.Forms.Button();
            this.buttonAcceptSpecialty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDeclineSpecialty
            // 
            this.buttonDeclineSpecialty.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDeclineSpecialty.Location = new System.Drawing.Point(113, 32);
            this.buttonDeclineSpecialty.Name = "buttonDeclineSpecialty";
            this.buttonDeclineSpecialty.Size = new System.Drawing.Size(95, 23);
            this.buttonDeclineSpecialty.TabIndex = 23;
            this.buttonDeclineSpecialty.Text = "Отменить";
            this.buttonDeclineSpecialty.UseVisualStyleBackColor = true;
            this.buttonDeclineSpecialty.Click += new System.EventHandler(this.buttonDeclineSpecialty_Click);
            // 
            // buttonAcceptSpecialty
            // 
            this.buttonAcceptSpecialty.Location = new System.Drawing.Point(12, 32);
            this.buttonAcceptSpecialty.Name = "buttonAcceptSpecialty";
            this.buttonAcceptSpecialty.Size = new System.Drawing.Size(95, 23);
            this.buttonAcceptSpecialty.TabIndex = 22;
            this.buttonAcceptSpecialty.Text = "Принять";
            this.buttonAcceptSpecialty.UseVisualStyleBackColor = true;
            this.buttonAcceptSpecialty.Click += new System.EventHandler(this.buttonAcceptSpecialty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // FormAddSpecialty
            // 
            this.AcceptButton = this.buttonAcceptSpecialty;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonDeclineSpecialty;
            this.ClientSize = new System.Drawing.Size(221, 64);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDeclineSpecialty);
            this.Controls.Add(this.buttonAcceptSpecialty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAddSpecialty";
            this.Text = "Добавление специальности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeclineSpecialty;
        private System.Windows.Forms.Button buttonAcceptSpecialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
    }
}