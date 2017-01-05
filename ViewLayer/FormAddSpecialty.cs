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
    /// Форма добавления новой специальности в базу данных
    /// </summary>
    public partial class FormAddSpecialty : Form
    {
        private IViewSpecialty View;
        /// <summary>
        /// Конструктор формы.
        /// Инициализирует все графические объекты формы
        /// </summary>
        public FormAddSpecialty(IViewSpecialty view)
        {
            this.View = view;
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик нажатия на кнопку добавить специальность
        /// </summary>
        private void buttonAcceptSpecialty_Click(object sender, EventArgs e)
        {
            try
            {
                this.View.AddSpecialty(this.textBoxName.Text);
                MessageBox.Show("Специальность зарегистрирована");
                //Нажать на кнопку закрытия формы*/
                buttonDeclineSpecialty.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// Обработчик отмены добавления специальности
        /// </summary>
        private void buttonDeclineSpecialty_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
