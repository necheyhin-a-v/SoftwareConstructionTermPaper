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
        private BusinessLayer.Employees Employees;
        private BusinessLayer.Vacancies Vacancies;
        private BusinessLayer.Specialties Specialties;
        private ViewLayer.FormAddVacancy VacancyForm;
        private ViewLayer.FormAddSpecialty SpecialtyForm;
        private ViewLayer.FormEmployers EmployerForm;
        private ViewLayer.FormEmployees EmployeesForm;
        private ViewLayer.FormAuthorization AuthorizationForm;
        private ViewLayer.FormSelectSpecialties SelectSpecialtiesForm;
        private ViewLayer.FormSelectEmploymentTypes SelectEmploymentTypesForm;
        public FormController()
        {
            Specialties = new Specialties();
            Vacancies = new Vacancies();
            Users = new Users();
            Employers = new Employers();
            Employees = new Employees();
            EmployeesForm = new ViewLayer.FormEmployees(Employees, Vacancies);
            EmployerForm = new ViewLayer.FormEmployers(Employers, Vacancies);
            VacancyForm = new ViewLayer.FormAddVacancy(this.Vacancies);
            SpecialtyForm = new ViewLayer.FormAddSpecialty(this.Specialties);
            AuthorizationForm = new ViewLayer.FormAuthorization(this.Users);
            SelectSpecialtiesForm = new ViewLayer.FormSelectSpecialties(this.Specialties, this.Employees);
            SelectEmploymentTypesForm = new ViewLayer.FormSelectEmploymentTypes(this.Employees, this.Specialties);
        }
        /// <summary>
        /// Процесс авторизации
        /// </summary>
        public void Authorization()
        {
            if (AuthorizationForm.IsDisposed) AuthorizationForm = new ViewLayer.FormAuthorization(this.Users);
            //Подключиться к форме и отлавливать ее закрытие для того, чтобы запустить другие формы
            AuthorizationForm.FormClosed += FinishAuthorization;
            AuthorizationForm.Show();
        }
        /// <summary>
        /// Запуск формы работы с предприятиями
        /// </summary>
        public void RunFormEmployers()
        {
            if (EmployerForm.IsDisposed) EmployerForm = new ViewLayer.FormEmployers(this.Employers, this.Vacancies);
            EmployerForm.FormClosed += UnAuthorize;
            EmployerForm.ButtonAddVacancyClicked += AddVacancy;
            EmployerForm.Show();
        }
        /// <summary>
        /// Запуск формы работы с населением (работодателями)
        /// </summary>
        public void RunFormEmployees()
        {
            if (EmployeesForm.IsDisposed) EmployeesForm = new ViewLayer.FormEmployees(this.Employees, this.Vacancies);
            EmployeesForm.FormClosed += UnAuthorize;
            EmployeesForm.ButtonSelectSpecialtiesClicked += SelectSpecialties;
            EmployeesForm.ButtonSelectEmploymentTypesClicked += SelectEmploymentTypes;
            EmployeesForm.Show();
        }
        private void AddVacancy (object sender, EventArgs e)
        {
            if(VacancyForm.IsDisposed) VacancyForm = new ViewLayer.FormAddVacancy(this.Vacancies);
            EmployerForm.Hide();
            VacancyForm.Show();
            VacancyForm.FormClosed += FinishAuthorization;
            VacancyForm.ButtonAddSpecialtyClicked += AddSpecialty;
        }

        private void AddSpecialty(object sender, EventArgs e)
        {
            if (SpecialtyForm.IsDisposed) SpecialtyForm = new ViewLayer.FormAddSpecialty(this.Specialties);
            VacancyForm.Hide();
            SpecialtyForm.Show();
            SpecialtyForm.FormClosed += AddVacancy;
        }

        private void SelectSpecialties(object sender, EventArgs e)
        {
            if (SelectSpecialtiesForm.IsDisposed) SelectSpecialtiesForm = new ViewLayer.FormSelectSpecialties(this.Specialties, this.Employees);
            EmployeesForm.Hide();
            SelectSpecialtiesForm.Show();
            SelectSpecialtiesForm.FormClosed += FinishAuthorization;
        }
        private void SelectEmploymentTypes(object sender, EventArgs e)
        {
            if (SelectEmploymentTypesForm.IsDisposed) SelectEmploymentTypesForm = new ViewLayer.FormSelectEmploymentTypes(this.Employees, this.Specialties);
            EmployeesForm.Hide();
            SelectEmploymentTypesForm.Show();
            SelectEmploymentTypesForm.FormClosed += FinishAuthorization;
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
