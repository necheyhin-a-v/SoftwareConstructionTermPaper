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
        /// <summary>
        /// Запуск формы работы с предприятиями
        /// </summary>
        public void RunFormEmployers()
        {
            ViewLayer.FormEmployers form = new ViewLayer.FormEmployers(Employers);
            form.FormClosed += UnAuthorize;
            form.Show();
        }
        /// <summary>
        /// Запуск формы работы с населением (работодателями)
        /// </summary>
        public void RunFormEmployees()
        {
            ViewLayer.FormEmployees form = new ViewLayer.FormEmployees();
            form.FormClosed += UnAuthorize;
            form.Show();
        }
        /// <summary>
        /// Производится либо запуск других форм, либо завершение приложения
        /// </summary>
        private void FinishAuthorization(object sender, FormClosedEventArgs e)
        {
            if (this.Users.GetAuthorizedUser() != null)
            {
                if (Users.GetRole() == ModelLayerMSSQL.UserRoles.Consultant)
                    RunFormEmployees();
                else
                    RunFormEmployers();
            }
            else
                Application.Exit();
        }
        /// <summary>
        /// При закрытии окон показывать окно авторизации
        /// </summary>
        private void UnAuthorize(object sender, FormClosedEventArgs e)
        {
            Users.Unauthorize();
            //Снова показать окно авторизации
            Authorization();
        }
    }
}
