using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using ModelLayerMSSQL;

namespace BusinessLayer
{
    class Employees : IViewEmployee
    {
        private List<string> SelectedSpecialties;
        public Employees()
        {
            SelectedSpecialties = new List<string>();
        }
        public List<string[]> GetEmployees(string filter)
        {
            List<Employee> employees = Employee.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (filter.Equals(""))
            {
                foreach (Employee current in employees)
                {
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetFirstName(), 0);
                    tmp.SetValue(current.GetMiddleName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetPassport(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (Employee current in employees)
                {
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetFirstName(), 0);
                    tmp.SetValue(current.GetMiddleName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetPassport(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
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
        public void RegisterEmployee(string passport, string firstName, string secondName, string middleName,
            string address, string phone, string experience)
        {
            if (passport.Equals(""))
                throw new Exception("Данные о паспорте не могут быть пустыми");
            else if (firstName.Equals(""))
                throw new Exception("Имя не может быть пустым");
            else if (secondName.Equals(""))
                throw new Exception("Фамилия не может быть пустым");
            else if (middleName.Equals(""))
                throw new Exception("Отчество не может быть пустым");
            else if (address.Equals(""))
                throw new Exception("Адрес не может быть пустым");
            try
            {
                Employee newEmpoyee = new Employee(passport, firstName, secondName, middleName, address, phone, Convert.ToUInt32(experience));
                //Если ни одна специальность не выбрана - выбрать все
                if (SelectedSpecialties.Count == 0)
                {
                    List<ModelLayerMSSQL.Specialty> specialties = ModelLayerMSSQL.Specialty.GetAll();
                    foreach (var item in specialties)
                        SelectedSpecialties.Add(item.GetName());
                }
                foreach (string item in SelectedSpecialties)
                    newEmpoyee.AddPriorSpecialty(item);

            }
            catch (Exception)
            {
                throw new Exception("Ошибка базы данных при попытке добавить работника");
            }
        }
        public List<string> GetSelectedSpecialties()
        {
            return SelectedSpecialties;
        }
        public void SetSelectedSpecialties(List<string> specialties)
        {
            SelectedSpecialties = specialties;
        }

        public void SetSelectedSpecialties(string passportData, List<string> specialties)
        {
            throw new NotImplementedException();
        }
        public List<string> GetSelectedSpecialties(string passportData)
        {
            throw new NotImplementedException();
        }
    }
}
