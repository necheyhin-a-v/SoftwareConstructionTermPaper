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
        /// <summary>
        /// Событие, которое происходит при нажатии на кнопку выбрать специальности
        /// </summary>
        public event EventHandler ButtonSelectSpecialtiesClicked;

        private String DataBeforeEditing;
        private ContextMenuStrip contextMenuInfoEmploee;
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
            //Скрытие первого столбца
            this.dataGridInfo.RowHeadersVisible = false;
            //Подключить обработчик при нажатии на кнопку добавления специальностей
            this.buttonSelectSpecialties.Click += ButtonSelectSpecialtiesClicked;


            //Создание объектов контекстного меню  информации о работниках
            contextMenuInfoEmploee = new ContextMenuStrip();
            // Создание пунктов меню
            ToolStripMenuItem editMenuInfoItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem changeSelectedSpecialtiesMenuItem = new ToolStripMenuItem("Сменить предпочитаемые специальности");
            ToolStripMenuItem changeSelectedEmploymenTypesMenuItem = new ToolStripMenuItem("Сменить предпочитаемые типы занятости");
            ToolStripMenuItem suggestVacancyMenuItem = new ToolStripMenuItem("Подобрать вакансию");
            // Установка обработчиков событий для пунктов меню
            editMenuInfoItem.Click += EditMenuInfoItemClick;
            changeSelectedSpecialtiesMenuItem.Click += ChangeSelectedSpecialtiesMenuItemClick;
            changeSelectedEmploymenTypesMenuItem.Click += ChangeSelectedEmploymenTypesMenuItemClick;
            suggestVacancyMenuItem.Click += SuggestVacancyMenuItemClick;
            //Добавление пунктов меню в контекстное меню
            contextMenuInfoEmploee.Items.Add(editMenuInfoItem);
            contextMenuInfoEmploee.Items.Add(changeSelectedSpecialtiesMenuItem);
            contextMenuInfoEmploee.Items.Add(changeSelectedEmploymenTypesMenuItem);
            contextMenuInfoEmploee.Items.Add(suggestVacancyMenuItem);

        }
        /// <summary>
        /// Добавление контекстного меню для каждой строки таблицы
        /// "сведения о работнике"
        /// </summary>
        private void dataGridInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Перебрать все строки и установить для каждой контекстное меню
            for (int i = 0; i < dataGridInfo.RowCount; i++)
            {
                dataGridInfo.Rows[i].ContextMenuStrip = contextMenuInfoEmploee;
            }
        }
        /// <summary>
        /// Обработчик события пункта меню редактировать информацию о работнике
        /// </summary>
        private void EditMenuInfoItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование информации о работнике");
        }
        /// <summary>
        /// Обработчик события пункта меню сменить предпочитаемые специальности для текущего работника
        /// </summary>
        private void ChangeSelectedSpecialtiesMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Изменение предпочитаемых специальностей");
        }
        private void ChangeSelectedEmploymenTypesMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Изменение предпочитаемых типов занятости");
        }
        private void SuggestVacancyMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Подобрать вакансию");
        }
        /// <summary>
        /// Выполнить регистрацию работника
        /// </summary>
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
                this.textBoxEmployerExperience.Text);
                MessageBox.Show("Работник зарегистрирован");
                //Нажать на кнопку очищения формы
                buttonClear.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// Очистить форму регистрации работника
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxPassport.Text = "";
            this.textBoxEmployerFirstName.Text = "";
            this.textBoxEmployerLastName.Text = "";
            this.textBoxEmployerSecondName.Text = "";
            this.textBoxEmployerAddress.Text = "";
            this.textBoxEmployerPhoneNumber.Text = "";
            this.textBoxEmployerExperience.Text = "";
        }
        /// <summary>
        /// Подстроить размеры формы под внутренний контент
        /// Запуск подгрузки данных при переходе на другую вкладку
        /// </summary>
        private void tcEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcEmployees.SelectedIndex)
            {
                case 0: //Вкладка Регистрация
                    this.Size = new Size(400, 330);
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
            try
            {
                this.dataGridInfo.SelectAll();
                this.dataGridInfo.ClearSelection();
                List<string[]> employees = ViewEmployee.GetEmployees(filter);
                if (employees.Count == 0)
                    throw new Exception("Нет результатов поиска");
                this.dataGridInfo.RowCount = employees.Count;
                int currentRow = 0;
                foreach (string[] currentEmployee in employees)
                {
                    for (int i = 0; i < currentEmployee.Count(); i++)
                        this.dataGridInfo.Rows[currentRow].Cells[i].Value = currentEmployee.ElementAt(i);
                    currentRow++;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Невозможно получить данные о работниках.\nПри выполнении поиска проверьте результаты");
            }
        }
        /// <summary>
        /// Очистить поиск информации о работниках
        /// </summary>
        private void buttonSearchInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo(this.textBoxSearchInfo.Text);
        }
        /// <summary>
        /// Найти информацию о работниках
        /// </summary>
        private void buttonClearSearchInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo(this.textBoxSearchInfo.Text = "");
        }
        /// <summary>
        /// Перенаправление сигнала о нажатии кнопки во внешнюю среду
        /// </summary>
        private void buttonSelectSpecialties_Click(object sender, EventArgs e)
        {
            ButtonSelectSpecialtiesClicked(sender, e);
        }
        /// <summary>
        /// Выделение ячейки при нажатии на контекстное меню
        /// </summary>
        private void dataGridInfo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                dataGridInfo.CurrentCell = dataGridInfo[e.ColumnIndex, e.RowIndex];
            }
        }
        /// <summary>
        /// Использование быстрых клавиш для поиска и отмены поиска
        /// </summary>
        private void tcEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (tcEmployees.SelectedIndex)
                {
                    case 0: //Вкладка Регистрация
                        this.buttonCreate.PerformClick();
                        break;
                    case 1: //Вкладка сведения
                        this.buttonSearchInfo.PerformClick();
                        break;
                    case 2: //Вкладка подбор вакансии
                        break;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                switch (tcEmployees.SelectedIndex)
                {
                    case 0: //Вкладка Регистрация
                        this.buttonClear.PerformClick();
                        break;
                    case 1: //Вкладка сведения
                        this.buttonClearSearchInfo.PerformClick();
                        break;
                    case 2: //Вкладка подбор вакансии
                        break;
                }
            }
        }
    }
}
