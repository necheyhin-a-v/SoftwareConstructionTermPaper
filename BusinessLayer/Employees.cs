using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using ModelLayerMSSQL;

namespace BusinessLayer
{
    class Employees
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
                    string[] tmp = new string[7];
                    tmp.SetValue(current.GetPassport(), 0);
                    tmp.SetValue(current.GetFirstName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetMiddleName(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(current.GetExperience(), 6);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (Employee current in employees)
                {
                    string[] tmp = new string[7];

                    tmp.SetValue(current.GetPassport(), 0);
                    tmp.SetValue(current.GetFirstName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetMiddleName(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(current.GetExperience(), 6);
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
                                        string phone, string experience)
        {
            if (passport.Equals(""))
                throw new Exception("Данные о паспорте не могут быть пустыми");
            else if (firstName.Equals(""))
                throw new Exception("");
            else if (address.Equals(""))
                throw new Exception("Адрес не может быть пустым");
            try
            {
                
            }
            catch (Exception)
            {
               
            }

        }
    }
}
