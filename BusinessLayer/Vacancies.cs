﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;

namespace BusinessLayer
{
    class Vacancies : IViewVacancy
    {
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
                    //Перевод требуемого стажа в года
                    tmp.SetValue((current.GetRequiredExperience() / 12d).ToString(), 3);
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
                    //Перевод требуемого стажа в года
                    tmp.SetValue((current.GetRequiredExperience() / 12d).ToString(), 3);
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
