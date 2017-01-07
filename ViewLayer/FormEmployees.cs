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
    /// <summary>
    /// Класс формы работников
    /// </summary>
    public partial class FormEmployees : Form
    {
        private IViewEmployee ViewEmployee;
        private IViewVacancy ViewVacancy;
        /// <summary>
        /// Конструктор формы работников
        /// </summary>
        public FormEmployees(IViewEmployee viewEmployee, IViewVacancy viewVacancy)
        {
            this.ViewEmployee = viewEmployee;
            this.ViewVacancy = viewVacancy;
            InitializeComponent();
            //Установить размер формы начальный
            this.Size = new Size(400, 330);
            this.comboBoxSpecialty.Items.Clear();
            this.comboBoxSpecialty.Items.AddRange(ViewVacancy.GetSpecialties().ToArray());
            //Скрытие первого столбца
            this.dataGridInfo.RowHeadersVisible = false;
        }

        private void СChoiceRegEmp_Click(object sender, EventArgs e)
        {
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.ViewEmployee.RegisterEmployee(
                this.textBoxPassport.Text,
                this.textBoxEmployerFirstName.Text,
                this.textBoxEmployerLastName.Text,
                this.textBoxEmployerSecondName.Text,
                this.textBoxEmployerAddress.Text,
                this.textBoxEmployerPhoneNumber.Text,
                this.textBoxEmployerExperience.Text,
                this.comboBoxSpecialty.SelectedItem.ToString());
                MessageBox.Show("Работник зарегистрирован");
                //Нажать на кнопку очищения формы
                buttonClear.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxPassport.Text = "";
            this.textBoxEmployerFirstName.Text = "";
            this.textBoxEmployerLastName.Text = "";
            this.textBoxEmployerSecondName.Text = "";
            this.textBoxEmployerAddress.Text = "";
            this.textBoxEmployerPhoneNumber.Text = "";
            this.textBoxEmployerExperience.Text = "";
            this.comboBoxSpecialty.SelectedIndex = -1;
        }
        /// <summary>
        /// Подстроить размеры формы под внутренний контент
        /// Запуск подгрузки данных при переходе на другую вкладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcEmployees.SelectedIndex)
            {
                case 0: //Вкладка Регистрация
                    this.Size = new Size(400, 330);
                    this.comboBoxSpecialty.Items.Clear();
                    this.comboBoxSpecialty.Items.AddRange(ViewVacancy.GetSpecialties().ToArray());
                    break;
                case 1: //Вкладка сведения
                    this.Size = new Size(885, 580);
                    UpdateInfo(this.textBoxSearchInfo.Text);
                    break;
            }
        }

        /// <summary>
        /// Обновить таблицу с информацией о работниках
        /// Пытается применить фильтр для показа
        /// </summary>
        public void UpdateInfo(string filter = "")
        {
            this.dataGridInfo.SelectAll();
            this.dataGridInfo.ClearSelection();
            this.dataGridInfo.RowCount = 1;
            try
            {
                List<string[]> employees = ViewEmployee.GetEmployees(filter);
                if (employees.Count == 0)
                    return;
                this.dataGridInfo.RowCount = employees.Count;
                int currentRow = 0;
                foreach (string[] currentEmployee in employees)
                {
                    for (int i = 0; i < currentEmployee.Count(); i++)
                        this.dataGridInfo.Rows[currentRow].Cells[i].Value = currentEmployee.ElementAt(i);
                    currentRow++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в получении данных о работниках");
            }
        }

        private void buttonSearchInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo(this.textBoxSearchInfo.Text);
        }

        private void buttonClearSearchInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo(this.textBoxSearchInfo.Text = "");
        }
    }
}
