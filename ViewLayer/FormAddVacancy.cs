using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer
{
    public partial class FormAddVacancy : Form
    {
        private IViewEmployer View;
        /// <summary>
        /// Конструктор формы.
        /// Инициализирует все графические объекты формы
        /// </summary>
        public FormAddVacancy(IViewEmployer view)
        {
            this.View = view;
            InitializeComponent();
        }
        
        private void buttonAcceptVacancy_Click(object sender, EventArgs e)
        {
            try
            {
                this.View.CreateVacancy(
                this.textBoxRequire.Text,
                this.textBoxFirmINN.Text,
                this.comboBoxSpecialty.SelectedItem.ToString(),
                this.comboBoxEmploymentType.SelectedIndex + 1,
                this.textBoxDescription.Text,
                Convert.ToUInt32(this.textBoxSalary.Text),
                Convert.ToUInt32(this.textBoxExperience.Text));
                MessageBox.Show("Вакансия зарегистрирована");
                //Нажать на кнопку закрытия формы
                buttonDeclineVacancy.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show("Невозможно добавить вакансию");
                //MessageBox.Show(err.Message);
            }
        }

        private void buttonDeclineVacancy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddVacancy_Load(object sender, EventArgs e)
        {
            foreach(string specialty in View.GetSpecialties())
            {
                this.comboBoxSpecialty.Items.Add(specialty);
            }
            foreach (string employmentTypes in View.GetEmploymentTypes())
            {
                this.comboBoxEmploymentType.Items.Add(employmentTypes);
            }


            this.Enabled = true;
        }
        /// <summary>
        /// Запуск добавления новой специальности
        /// </summary>
        private void specialtyAddButton_Click(object sender, EventArgs e)
        {
            //TODO: FormAddVacancy.specialtyAddButton_Click() вынести в класс formController
            FormAddSpecialty form = new FormAddSpecialty(this.View);
            form.FormClosed += new FormClosedEventHandler(FormAddVacancy_Load);
            form.Show();
            this.Enabled = false;
        }
    }
}
