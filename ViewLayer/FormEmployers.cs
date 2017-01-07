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
    /// Класс формы работы с работодателями
    /// </summary>
    public partial class FormEmployers : Form
    {
        /// <summary>
        /// Событие, которое происходит при нажатии на кнопку Добавить вакансию
        /// </summary>
        public event EventHandler ButtonAddVacancyClicked;
        //Закрытые поля
        private DataGridViewRow RowBeforeEditing;
        private ContextMenuStrip contextMenuInfoEmployer;
        private IViewEmployer ViewEmployer;
        private IViewVacancy ViewVacancy;
        /// <summary>
        /// Конструктор формы.
        /// Инициализирует все графические объекты формы
        /// </summary>
        public FormEmployers(IViewEmployer viewEmployer, IViewVacancy viewVacancy)
        {
            this.ViewEmployer = viewEmployer;
            this.ViewVacancy = viewVacancy;
            InitializeComponent();
            //Установить размер формы начальный
            this.Size = new Size(377, 225);
            //Создание объекта контекстного меню
            contextMenuInfoEmployer = new ContextMenuStrip();
            // Создание пунктов меню
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem watchVacancyMenuItem = new ToolStripMenuItem("Просмотр вакансий");
            // Установка обработчиков событий для пунктов меню
            editMenuItem.Click += EditMenuItemClick;
            watchVacancyMenuItem.Click += WatchVacancyMenuItemClick;
            //Подключить обработчик при нажатии на кнопку добавления вакансии
            this.buttonAddVacancy.Click += ButtonAddVacancyClick;

            //Добавление пунктов меню в контекстное меню
            contextMenuInfoEmployer.Items.Add(editMenuItem);
            contextMenuInfoEmployer.Items.Add(watchVacancyMenuItem);

            //Скрытие первого столбца
            this.dataGridInfo.RowHeadersVisible = false;
            this.dataGridVacancies.RowHeadersVisible = false;
        }
        /// <summary>
        /// Вещание собственного события нажания кнопки, которое является публичным
        /// </summary>
        private void ButtonAddVacancyClick(object sender, EventArgs e)
        {
            ButtonAddVacancyClicked(sender, e);
        }
        /// <summary>
        /// Обработчик событий для контекстного меню "Просмотр вакансий"
        /// </summary>
        private void WatchVacancyMenuItemClick(object sender, EventArgs e)
        {
            this.textBoxSearchVacancy.Text = this.dataGridInfo.CurrentRow.Cells[0].Value.ToString();
            //Показать вкладку вакансий
            this.tabControlEmployers.SelectedIndex = 2;
        }
        /// <summary>
        /// Обработчик событий для контекстного меню "Редактирование"
        /// включает изменение текущей ячейки
        /// </summary>
        private void EditMenuItemClick(object sender, EventArgs e)
        {
            dataGridInfo.ReadOnly = false;  //Открытие режима редактирования
            dataGridInfo.BeginEdit(false);  //Не выбирать все ячейки для редактирования
            RowBeforeEditing = dataGridInfo.CurrentRow;
        }
        /// <summary>
        /// Подстроить размеры формы под внутренний контент
        /// Запуск подгрузки данных при переходе на другую вкладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlEmployersSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlEmployers.SelectedIndex)
            {
                case 0: //Вкладка Регистрация
                    this.Size = new Size(377, 225);
                    break;
                case 1: //Вкладка сведения
                    this.Size = new Size(600, 400);
                    UpdateInfo(this.textBoxSearchInfo.Text);
                    break;
                case 2: //Вкладка вакансии
                    this.Size = new Size(777, 400);
                    UpdateVacancies(this.textBoxSearchVacancy.Text);
                    break;
            }
        }
        /// <summary>
        /// Обновить таблицу с информацией о работодателях
        /// Пытается применить фильтр для показа
        /// </summary>
        public void UpdateInfo(string filter = "")
        {
            this.dataGridInfo.SelectAll();
            this.dataGridInfo.ClearSelection();
            this.dataGridInfo.RowCount = 1;
            try
            {
                List<string[]> employers = ViewEmployer.GetEmployers(filter);
                if (employers.Count == 0)
                    return;
                this.dataGridInfo.RowCount = employers.Count;
                int currentRow = 0;
                foreach (string[] currentEmployer in employers)
                {
                    for (int i = 0; i < currentEmployer.Count(); i++)
                        this.dataGridInfo.Rows[currentRow].Cells[i].Value = currentEmployer.ElementAt(i);
                    currentRow++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в получении данных о работодателях");
            }
        }
        /// <summary>
        /// Обновление таблицы с информацией о вакансиях
        /// </summary>
        public void UpdateVacancies(string filter = "")
        {
            this.dataGridVacancies.SelectAll();
            this.dataGridVacancies.ClearSelection();
            try
            {
                List<string[]> vacancies = ViewVacancy.GetVacancies(filter);
                this.dataGridVacancies.RowCount = vacancies.Count;
                int currentRow = 0;
                foreach (string[] currentVacancy in vacancies)
                {
                    for (int i = 0; i < currentVacancy.Count(); i++)
                        this.dataGridVacancies.Rows[currentRow].Cells[i].Value = currentVacancy.ElementAt(i);
                    currentRow++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно получить данные о вакансиях.\nПри выполнении поиска проверьте результаты");
            }
        }
        /// <summary>
        /// Блокировка ячейки в таблице "сведения о работодателе"
        /// при завершении редактирования ячейки
        /// Обновление данных после изменения
        /// </summary>
        private void dataGridInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridInfo.ReadOnly = true;
            try
            {

                if (RowBeforeEditing.Cells[0].Value.ToString().CompareTo(
                    dataGridInfo.Rows[e.RowIndex].Cells[0].Value.ToString()) != 0)
                    throw new Exception("Невозможно изменить ИНН");
                ViewEmployer.ChangeEmployerInfo(
                    RowBeforeEditing.Cells[1].Value.ToString(),                 //Инн                    
                    dataGridInfo.Rows[e.RowIndex].Cells[0].Value.ToString(),    //Новое имя
                    dataGridInfo.Rows[e.RowIndex].Cells[2].Value.ToString(),    //Новый адрес
                    dataGridInfo.Rows[e.RowIndex].Cells[3].Value.ToString());   //Новый телефон
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при изменении данных");
            }
            //Обновить информацию после изменения
            UpdateInfo(this.textBoxSearchInfo.Text);
        }
        /// <summary>
        /// Обработчик события на добавление новой строки в таблицу
        /// "сведения о работодателе"
        /// </summary>
        private void dataGridInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Перебрать все строки и установить для каждой контекстное меню
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                dataGridInfo.Rows[i].ContextMenuStrip = contextMenuInfoEmployer;
            }
        }
        /// <summary>
        /// Выделение ячейки в таблице "сведения о работодателе
        /// при нажании правой кнопки мыши
        /// </summary>
        private void dataGridInfo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                dataGridInfo.CurrentCell = dataGridInfo[e.ColumnIndex, e.RowIndex];
            }
        }
        /// <summary>
        /// Регистрация предприятия
        /// </summary>
        private void buttonAcceptRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                this.ViewEmployer.RegisterEmployer(
                this.textBoxEmployerName.Text,
                this.textBoxITN.Text,
                this.textBoxEmployerAddress.Text,
                this.textBoxEmployerPhoneNumber.Text);
                MessageBox.Show("Предприятие зарегистрировано");
                //Нажать на кнопку очищения формы
                buttonClearRegistration.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// Очистить поля формы регистрация
        /// </summary>
        private void buttonClearRegistration_Click(object sender, EventArgs e)
        {
            this.textBoxEmployerName.Text = "";
            this.textBoxITN.Text = "";
            this.textBoxEmployerAddress.Text = "";
            this.textBoxEmployerPhoneNumber.Text = "";
        }
        /// <summary>
        /// Поиск вакансии
        /// </summary>
        private void buttonSearchVacancy_Click(object sender, EventArgs e)
        {
            UpdateVacancies(this.textBoxSearchVacancy.Text);
        }
        /// <summary>
        /// Применение фильтра к информации о работодателях
        /// </summary>
        private void buttonSearchInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo(this.textBoxSearchInfo.Text);
        }
        /// <summary>
        /// Сбросить результаты поиска информации о работодателях
        /// </summary>
        private void buttonClearSearchInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo(this.textBoxSearchInfo.Text = "");
        }
        /// <summary>
        /// Сброс параметров поиска вакансий
        /// </summary>
        private void buttonClearSearchVacancy_Click(object sender, EventArgs e)
        {
            UpdateVacancies(this.textBoxSearchVacancy.Text = "");
        }
        /// <summary>
        /// Использование быстрых клавиш Enter и Escape
        /// </summary>
        private void tabControlEmployers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (tabControlEmployers.SelectedIndex)
                {
                    case 0: //Вкладка Регистрация
                        this.buttonAcceptRegistration.PerformClick();
                        break;
                    case 1: //Вкладка сведения
                        this.buttonSearchInfo.PerformClick();
                        break;
                    case 2: //Вкладка вакансии
                        this.buttonSearchVacancy.PerformClick();
                        break;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                switch (tabControlEmployers.SelectedIndex)
                {
                    case 0: //Вкладка Регистрация
                        this.buttonClearRegistration.PerformClick();
                        break;
                    case 1: //Вкладка сведения
                        this.buttonClearSearchInfo.PerformClick();
                        break;
                    case 2: //Вкладка вакансии
                        this.buttonClearSearchVacancy.PerformClick();
                        break;
                }
            }
        }
    }
}
