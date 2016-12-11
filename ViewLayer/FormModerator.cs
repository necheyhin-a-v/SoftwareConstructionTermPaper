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
        ContextMenuStrip contextMenuInfoEmployer;
        /// <summary>
        /// Конструктор формы.
        /// Инициализирует все графические объекты формы
        /// </summary>
        public FormEmployers()
        {
            InitializeComponent();
            //Установить размер формы начальный
            this.Size = new Size(377, 225);
            dataGridInfo.RowCount = 5;
            //Создание объекта контекстного меню
            contextMenuInfoEmployer = new ContextMenuStrip();
            // Создание пунктов меню
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem watchVacancyMenuItem = new ToolStripMenuItem("Просмотр вакансии");
            //Добавление пунктов меню в контекстное меню
            contextMenuInfoEmployer.Items.Add(editMenuItem);
            contextMenuInfoEmployer.Items.Add(watchVacancyMenuItem);
            //Задать для каждой новой строки контекстное меню
            foreach (DataGridViewRow row in dataGridInfo.Rows)
                row.ContextMenuStrip = contextMenuInfoEmployer;
            // Установка обработчиков событий для пунктов меню
            editMenuItem.Click += EditMenuItemClick;
            watchVacancyMenuItem.Click += WatchVacancyMenuItemClick;
        }
        /// <summary>
        /// Обработчик событий для контекстного меню "Просмотр вакансий"
        /// </summary>
        void WatchVacancyMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Просмотр вакансий");
            dataGridInfo.RowCount += 1;
        }
        /// <summary>
        /// Обработчик событий для контекстного меню "Редактирование"
        /// включает изменение текущей ячейки
        /// </summary>
        void EditMenuItemClick(object sender, EventArgs e)
        {
            dataGridInfo.ReadOnly = false;  //Открытие режима редактирования
            dataGridInfo.BeginEdit(false);  //Не выбирать все ячейки для редактирования
        }
        /// <summary>
        /// Подстроить размеры формы под внутренний контент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlEmployersSelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControlEmployers.SelectedIndex)
            {
                case 0: //Вкладка Регистрация
                    this.Size = new Size(377, 225);
                    break;
                case 1: //Вкладка сведения
                    this.Size = new Size(477, 400);
                    break;
                case 2: //Вкладка вакансии
                    this.Size = new Size(777, 400);
                    break;
            }
        }
        /// <summary>
        /// Блокировка ячейки в таблице "сведения о работодателе"
        /// при завершении редактирования ячейки
        /// </summary>
        private void dataGridInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridInfo.ReadOnly = true;
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
            if (e.Button == MouseButtons.Right && e.ColumnIndex >= 0 && e.RowIndex >=0 )
            {
                dataGridInfo.CurrentCell = dataGridInfo[e.ColumnIndex, e.RowIndex];
            }
        }
        /// <summary>
        /// Запуск добавления новой вакансии
        /// </summary>
        private void buttonAddVacancy_Click(object sender, EventArgs e)
        {

            FormAddVacancy form = new FormAddVacancy();
            form.FormClosed += new FormClosedEventHandler(enableFormModerator);
            form.Show();
            this.Enabled = false;
        }
        /// <summary>
        /// Включение формы при закрытии формы "добавить вакансию"
        /// </summary>
        private void enableFormModerator(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
