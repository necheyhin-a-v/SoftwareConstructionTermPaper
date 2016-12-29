using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using ModelLayerMSSQL;
using System.Windows.Forms;

namespace BusinessLayer
{
    class Employers : IViewEmployer
    {
        /// <summary>
        /// Метод определяет получение списка работодателей для формы
        /// </summary>
        public List<string[]> GetEmployers(string filter)
        {
            List<Employer> employers = Employer.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (filter.Equals(""))
            {
                foreach (Employer current in employers)
                {
                    string[] tmp = new string[4];
                    tmp.SetValue(current.GetName(), 0);
                    tmp.SetValue(current.GetItn(), 1);
                    tmp.SetValue(current.GetAddress(), 2);
                    tmp.SetValue(current.GetPhone(), 3);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (Employer current in employers)
                {
                    string[] tmp = new string[4];

                    tmp.SetValue(current.GetName(), 0);
                    tmp.SetValue(current.GetItn(), 1);
                    tmp.SetValue(current.GetAddress(), 2);
                    tmp.SetValue(current.GetPhone(), 3);
                    //Проверка каждого поля на соответствие фильтру
                    for (int i = 0; i < tmp.Count(); i++)
                    {
                        if (tmp.ElementAt(i).IndexOf(filter, StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            list.Add(tmp);
                            break;
                        }
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Метод определяет получение списка вакансий для формы
        /// </summary>
        public List<string[]> GetVacancies(string filter)
        {
            List<Vacancy> vacancies = Vacancy.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (filter.Equals(""))
            {
                foreach (Vacancy current in vacancies)
                {
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetName(), 0);
                    tmp.SetValue(current.GetSpecialtyName(), 1);
                    tmp.SetValue(Employer.GetByItn(current.GetEmployerItn()).GetName(), 2);
                    //Перевод требуемого стажа в года
                    tmp.SetValue((current.GetRequiredExperience() / 12).ToString(), 3);
                    tmp.SetValue(current.GetEmploymentType().ToString(), 4);
                    tmp.SetValue(current.GetSalary().ToString(), 5);
                    tmp.SetValue(current.GetDescription(), 6);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (Vacancy current in vacancies)
                {
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetName(), 0);
                    tmp.SetValue(current.GetSpecialtyName(), 1);
                    tmp.SetValue(Employer.GetByItn(current.GetEmployerItn()).GetName(), 2);
                    //Перевод требуемого стажа в года
                    tmp.SetValue((current.GetRequiredExperience() / 12).ToString(), 3);
                    tmp.SetValue(current.GetEmploymentType().ToString(), 4);
                    tmp.SetValue(current.GetSalary().ToString(), 5);
                    tmp.SetValue(current.GetDescription(), 6);
                    //Проверка каждого поля на соответствие фильтру
                    for (int i = 0; i < tmp.Count(); i++)
                    {
                        if (tmp.ElementAt(i).IndexOf(filter, StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            list.Add(tmp);
                            break;
                        }
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Метод определяет получение списка специальностей для формы
        /// </summary>
        public List<string> GetSpecialties()
        {
            List<Specialty> specialties = Specialty.GetAll();
            List<string> list = new List<string>();
            foreach (Specialty specialty in specialties)
            {
                list.Add(specialty.GetName());
            }
            return list;
        }
        /// <summary>
        /// Метод перебирает все возможные варианты типа занятости и формирует список
        /// </summary>
        /// <returns></returns>
        public List<string> GetEmploymentTypes()        {
            List<string> result = new List<string>();
            foreach (var value in Enum.GetValues(typeof(EmploymentType)))
            {
                result.Add(value.ToString());
            }
            return result;
        }

        /// <summary>
        /// Метод определяет добавление специальностей
        /// </summary>
        public void AddSpecialty(string name)
        {
            Specialty specialties = new Specialty(name);
        }
        /// <summary>
        /// Метод определяет регистрацию работодателя для формы
        /// </summary>
        public void RegisterEmployer(string name, string itn, string address, string phone)
        {
            if (name.Equals(""))
                throw new Exception("Нименование организации не может быть пустым");
            else if (itn.Equals(""))
                throw new Exception("ИНН не может быть пустым");
            else if (address.Equals(""))
                throw new Exception("Адрес не может быть пустым");
            try
            {
                Employer newEmpoyer = new Employer(itn, name, address, phone);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка базы данных при попытке добавить работодателя");
            }

        }

        /// <summary>
        /// Создать вакансию предпринимателя
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="employerItn">ИНН работодателя, для которого создается вакансия.
        /// ИНН должен существовать в базе данных</param>
        /// <param name="specialty">Специальность для вакансии</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public void CreateVacancy(String name, String employerItn, String specialty, int type,
            String description, uint salary, uint requiredExperience)
        {
            if (name.Equals(""))
                throw new Exception("Нименование вакансии не может быть пустым");
            else if (employerItn.Equals(""))
                throw new Exception("ИНН не может быть пустым");
            else if (specialty.Equals(""))
                throw new Exception("Поле специальность не может быть пустым");
            try
            {
                Specialty _specialty = new Specialty(specialty);
                Vacancy newVacancy = new Vacancy(name, employerItn, _specialty, (EmploymentType)type,
            description, salary, requiredExperience);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка базы данных при попытке добавить вакансию");
            }
        }
    }
}
