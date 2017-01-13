using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    class Vacancies : IViewVacancy
    {
        public void ChangeVacancy(string oldEmployerName, string oldName, string newSpecialty, string newName, uint newExperience,
            string newEmploymentType, uint newSalary, string newDescription)
        {
            //TODO: рассмотреть вариант использования hash-таблиц вместо множества параметров
            List<ModelLayerMSSQL.Vacancy> vacancies = ModelLayerMSSQL.Vacancy.GetAll();
            //Найти вакансии которые удовлетворяют условиям изменения и заменить
            //старые поля на новые
            foreach (ModelLayerMSSQL.Vacancy vacancy in vacancies)
            {
                if(ModelLayerMSSQL.Employer.GetByItn(vacancy.GetEmployerItn()).GetName().Equals(oldEmployerName) &&
                    vacancy.GetName().Equals(oldName))
                {
                    string employerItn = vacancy.GetEmployerItn();
                    //удаление и создание новой вакансии
                    vacancy.Delete();
                    ModelLayerMSSQL.Vacancy newVacancy = new ModelLayerMSSQL.Vacancy(newName, employerItn, newSpecialty,
                        (ModelLayerMSSQL.EmploymentType)Enum.Parse(typeof(ModelLayerMSSQL.EmploymentType), newEmploymentType),
                        newDescription, newSalary, newExperience);
                }
            }
        }
        public void CreateVacancy(string name, string employerItn, string specialty, String type, string description, uint salary, uint requiredExperience)
        {
            if (name.Equals(""))
                throw new Exception("Нименование вакансии не может быть пустым");
            else if (employerItn.Equals(""))
                throw new Exception("ИНН не может быть пустым");
            else if (specialty.Equals(""))
                throw new Exception("Поле специальность не может быть пустым");
            try
            {
                ModelLayerMSSQL.Vacancy newVacancy = new ModelLayerMSSQL.Vacancy(name, employerItn, 
                    ModelLayerMSSQL.Specialty.GetByName(specialty),
                    (ModelLayerMSSQL.EmploymentType)Enum.Parse(typeof(ModelLayerMSSQL.EmploymentType), type),
                    description, salary, requiredExperience);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка базы данных при попытке добавить вакансию");
            }
        }
        public List<string> GetEmploymentTypes()
        {
            List<string> result = new List<string>();
            foreach (var value in Enum.GetValues(typeof(ModelLayerMSSQL.EmploymentType)))
                result.Add(value.ToString());
            return result;
        }
        public List<string[]> GetVacancies(string filter)
        {
            List<ModelLayerMSSQL.Vacancy> vacancies = ModelLayerMSSQL.Vacancy.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (filter.Equals(""))
            {
                foreach (ModelLayerMSSQL.Vacancy current in vacancies)
                {
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetName(), 0);
                    tmp.SetValue(current.GetSpecialtyName(), 1);
                    tmp.SetValue(ModelLayerMSSQL.Employer.GetByItn(current.GetEmployerItn()).GetName(), 2);
                    tmp.SetValue((current.GetRequiredExperience()).ToString(), 3);
                    tmp.SetValue(current.GetEmploymentType().ToString(), 4);
                    tmp.SetValue(current.GetSalary().ToString(), 5);
                    tmp.SetValue(current.GetDescription(), 6);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (ModelLayerMSSQL.Vacancy current in vacancies)
                {
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetName(), 0);
                    tmp.SetValue(current.GetSpecialtyName(), 1);
                    tmp.SetValue(ModelLayerMSSQL.Employer.GetByItn(current.GetEmployerItn()).GetName(), 2);
                    tmp.SetValue((current.GetRequiredExperience()).ToString(), 3);
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
        public List<string> GetSpecialties()
        {
            List<ModelLayerMSSQL.Specialty> specialties = ModelLayerMSSQL.Specialty.GetAll();
            List<string> list = new List<string>();
            foreach (ModelLayerMSSQL.Specialty specialty in specialties)
                list.Add(specialty.GetName());
            return list;
        }
    }
}
