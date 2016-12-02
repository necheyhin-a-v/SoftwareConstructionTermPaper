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
    /// Класс авторизации
    /// </summary>

    public partial class Authorization : Form
    {
        /// <summary>
        /// Конструктор, который инициализирует форму
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик входа в систему по клику 
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void EnterInSystemClick(object sender, EventArgs e)
        {
            //TODO: Autorization.EnterInSystemClick() Изменить заглушку от авторизации
            if (texBoxLogin.Text == "moderator")
            {
                this.Hide();
                Form form = new FormEmployers();
                //Создание нового обработчика события "Закрытие формы"
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedClick);
                form.Show();
            }

            if (texBoxLogin.Text == "consultant")
            {
                this.Hide();
                Form form = new FormEmployees();
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedClick);
                form.Show();
            }
        }
        /// <summary>
        /// Удаление формы авторизации при закрытии дочерних форм
        /// </summary>
        /// <param name="sender">Объект вызвавший событие</param>
        /// <param name="events"></param>
        private void FormClosedClick(Object sender, EventArgs events)
        {
            this.Close();
        }
    }
}
