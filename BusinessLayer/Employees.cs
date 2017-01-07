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
        public List<string[]> GetEmployees(string filter)
        {
            List<Employee> employees = Employee.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (filter.Equals(""))
            {
                foreach (Employee current in employees)
                {
                    string[] tmp = new string[5];
                    tmp.SetValue(current.ToString(), 0);
                    tmp.SetValue(current.GetPassport(), 1);
                    tmp.SetValue(current.GetAddress(), 2);
                    tmp.SetValue(current.GetPhone(), 3);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 4);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (Employee current in employees)
                {
                    string[] tmp = new string[5];
                    tmp.SetValue(current.ToString(), 0);
                    tmp.SetValue(current.GetPassport(), 1);
                    tmp.SetValue(current.GetAddress(), 2);
                    tmp.SetValue(current.GetPhone(), 3);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 4);
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
 
        public void RegisterEmployee(string passport, string firstName, string secondName, string middleName, string address,
                                        string phone, string experience, string specialty)
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
            else if (address.Equals(""))
                throw new Exception("Телефон не может быть пустым");
            try
            {
                Employee newEmpoyee = new Employee(passport, firstName, secondName, middleName, address, phone, Convert.ToUInt32(experience));
                newEmpoyee.AddPriorSpecialty(specialty);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка базы данных при попытке добавить работника");
            }
        }
    }
}
