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
        private void EnterInSystemClick(object sender, EventArgs e)
        {
            try
            {
                if (ViewAuth.CanAuth(texBoxLogin.Text, textBoxPassword.Text))
                    this.Close();
                else
                    MessageBox.Show("Невозможно авторизоваться");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
