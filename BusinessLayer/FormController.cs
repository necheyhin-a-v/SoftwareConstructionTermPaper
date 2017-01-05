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
        private BusinessLayer.Vacancies Vacancies;
        private BusinessLayer.Specialties Specialties;
        private ViewLayer.FormAddVacancy VacancyForm;
        private ViewLayer.FormAddSpecialty SpecialtyForm;
        private ViewLayer.FormEmployers EmployerForm;
        private ViewLayer.FormEmployees EmployeesForm;

        public FormController()
        {
            Specialties = new Specialties();
            Vacancies = new Vacancies();
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
            EmployerForm = new ViewLayer.FormEmployers(Employers, Vacancies);
            EmployerForm.FormClosed += UnAuthorize;
            EmployerForm.ButtonAddVacancyClicked += AddVacancy;
            EmployerForm.Show();
        }
        /// <summary>
        /// Запуск формы работы с населением (работодателями)
        /// </summary>
        public void RunFormEmployees()
        {
            EmployeesForm = new ViewLayer.FormEmployees();
            EmployeesForm.FormClosed += UnAuthorize;
            EmployeesForm.Show();
        }
        private void AddVacancy (object sender, EventArgs e)
        {
            VacancyForm = new ViewLayer.FormAddVacancy(this.Vacancies);
            EmployerForm.Hide();
            VacancyForm.Show();
            VacancyForm.FormClosed += FinishAuthorization;
            VacancyForm.ButtonAddSpecialtyClicked += AddSpecialty;
        }

        private void AddSpecialty(object sender, EventArgs e)
        {
            SpecialtyForm = new ViewLayer.FormAddSpecialty(this.Specialties);
            VacancyForm.Hide();
            SpecialtyForm.Show();
            SpecialtyForm.FormClosed += AddVacancy;
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
