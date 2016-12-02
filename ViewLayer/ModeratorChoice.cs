using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consruction
{
    public partial class formEmployers : Form
    {
        ContextMenuStrip contextMenuInfoEmployer;
        DataGridViewCell currentCell;

        public formEmployers()
        {
            InitializeComponent();
            dataGridView1.RowCount = 5;
            contextMenuInfoEmployer = new ContextMenuStrip();
            // создаем элементы меню
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem watchVacancyMenuItem = new ToolStripMenuItem("Просмотр вакансии");
            //добавляем элементы в меню
            contextMenuInfoEmployer.Items.AddRange(new[] { editMenuItem, watchVacancyMenuItem });
            // ассоциируем контекстное меню с таблицей
            contextMenuInfoEmployer.ItemClicked += ContextMenuInfoEmployer_ItemClicked;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.ContextMenuStrip = contextMenuInfoEmployer;
            }
            // устанавливаем обработчики событий для меню
            editMenuItem.Click += editMenuItem_Click;
            watchVacancyMenuItem.Click += watchVacancyMenuItem_Click;
        }

        private void ContextMenuInfoEmployer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Редактировать":
                    try
                    {
                        dataGridView1.ReadOnly = false;
                        dataGridView1.BeginEdit(false);
                    }
                    catch
                    {

                    }
                    break;
                case "Просмотр вакансии":

                    break;
            }
        }

        void editMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        void watchVacancyMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    

        private void tabRegEmployers_Click(object sender, EventArgs e)
        {
            this.tcEmployers.Size = new Size(360, 180);
            this.Size = new Size(400, 245);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {            
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                dataGridView1.Rows[i].ContextMenuStrip = contextMenuInfoEmployer;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            }
            catch
            {

            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.CurrentCell = currentCell;
            }
        }
    }
}
