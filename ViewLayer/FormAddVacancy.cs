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
        /// <summary>
        /// Событие широковещательное переопределяющее действие нажатия на кнопку добавления специальности
        /// </summary>
        public event EventHandler ButtonAddSpecialtyClicked;
        private IViewVacancy ViewVacancy;
        /// <summary>
        /// Конструктор формы.
        /// Инициализирует все графические объекты формы
        /// </summary>
        public FormAddVacancy(IViewVacancy viewVacancy)
        {
            this.ViewVacancy = viewVacancy;
            InitializeComponent();
        }
        
        private void buttonAcceptVacancy_Click(object sender, EventArgs e)
        {
            try
            {
                this.ViewVacancy.CreateVacancy(
                this.textBoxRequire.Text,
                this.textBoxFirmINN.Text,
                this.comboBoxSpecialty.SelectedItem.ToString(),
                this.comboBoxEmploymentType.SelectedValue.ToString(),
                this.textBoxDescription.Text,
                Convert.ToUInt32(this.textBoxSalary.Text),
                Convert.ToUInt32(this.textBoxExperience.Text));
                MessageBox.Show("Вакансия зарегистрирована");
                //Нажать на кнопку закрытия формы
                buttonDeclineVacancy.PerformClick();
            }
            catch (Exception err)
            {
                //MessageBox.Show("Невозможно добавить вакансию");
                MessageBox.Show(err.Message);
            }
        }

        private void buttonDeclineVacancy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Загрузка данных в комбобоксы перед показом формы
        /// </summary>
        private void FormAddVacancy_Load(object sender, EventArgs e)
        {
            this.comboBoxEmploymentType.Items.Clear();
            this.comboBoxEmploymentType.Items.AddRange(ViewVacancy.GetEmploymentTypes().ToArray());
            this.comboBoxSpecialty.Items.Clear();
            this.comboBoxSpecialty.Items.AddRange(ViewVacancy.GetSpecialties().ToArray());
            this.Enabled = true;
        }
        /// <summary>
        /// Широкое вещание нажатия по кнопке
        /// </summary>
        private void specialtyAddButton_Click(object sender, EventArgs e)
        {
            ButtonAddSpecialtyClicked(sender, e);
        }
    }
}
