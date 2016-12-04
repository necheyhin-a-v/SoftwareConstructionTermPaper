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
        DataGridViewCell currentCell;
        /// <summary>
        /// Конструктор формы.
        /// Инициализирует все графические объекты формы
        /// </summary>
        public FormEmployers()
        {
            InitializeComponent();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WatchVacancyMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Просмотр вакансий");
        }
        /// <summary>
        /// Обработчик событий для контекстного меню "Редактирование"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    this.tabControlEmployers.Size = new Size(360, 180);
                    this.Size = new Size(400, 245);
                    break;
                case 1: //Вкладка сведения
                    this.tabControlEmployers.Size = new Size(470, 230);
                    this.Size = new Size(510, 300);
                    break;
                case 2: //Вкладка вакансии
                    MessageBox.Show("Выбран индекс 2");
                    break;
                case 3: //Вкладка статистика
                    MessageBox.Show("Выбран индекс 3");
                    break;
                default:
                    MessageBox.Show("Нет обработчика для этой вкладки");
                    break;
            }
        }




        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {            
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                dataGridInfo.Rows[i].ContextMenuStrip = contextMenuInfoEmployer;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridInfo.ReadOnly = true;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentCell = dataGridInfo[e.ColumnIndex, e.RowIndex];
            }
            catch
            {

            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridInfo.CurrentCell = currentCell;
            }
        }


    }
}
