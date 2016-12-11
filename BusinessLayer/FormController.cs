using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    class FormController
    {
        private BusinessLayer.Users Users;
        private BusinessLayer.Employers Employers;

        public FormController()
        {
            Users = new Users();
            Employers = new Employers();
        }
        /// <summary>
        /// Процесс авторизации
        /// </summary>
        public void Authorization()
        {
            ViewLayer.FormAuthorization form = new ViewLayer.FormAuthorization(Users);
            //Подключиться к форме и отлавливать ее закрытие для того, чтобы запустить другие формы
            form.FormClosed += FinishAuthorization;
            form.Show();
        }
        public void RunFormEmployers()
        {
            ViewLayer.FormEmployers form = new ViewLayer.FormEmployers(Employers);
            form.Show();
        }
        public void RunFormEmployees()
        {
            ViewLayer.FormEmployees form = new ViewLayer.FormEmployees();
            form.Show();
        }

        /// <summary>
        /// Производится либо запуск других форм, либо завершение приложения
        /// </summary>
        private void FinishAuthorization(object sender, FormClosedEventArgs e)
        {
            if (this.Users.GetAuthorizedUser() != null)
            {
                if (Users.GetRole() == ModelLayer.UserRoles.Consultant)
                    RunFormEmployees();
                else
                    RunFormEmployers();
            }
            else
                Application.Exit();
        }
    }
}
