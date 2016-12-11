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
    /// Интерфейс для взаимодейтсвия с формой авторизации
    /// </summary>
    public interface IViewAuth
    {
        /// <summary>
        /// Проверка возможности авторизации
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CanAuth(String login, String password);
    }
    
    /// <summary>    
    /// Класс авторизации
    /// </summary>
    public partial class FormAuthorization : Form
    {
        IViewAuth ViewAuth;
        /// <summary>
        /// Конструктор, который инициализирует форму
        /// </summary>
        public FormAuthorization(IViewAuth viewAuth)
        {
            this.ViewAuth = viewAuth;
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик входа в систему по клику 
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void EnterInSystemClick(object sender, EventArgs e)
        {
            try
            {
                if (ViewAuth.CanAuth(texBoxLogin.Text, textBoxPassword.Text))
                {
                    this.Hide();
                }
                else
                    MessageBox.Show("Невозможно авторизоваться");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
