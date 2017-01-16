using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using System.Globalization;

namespace BusinessLayer
{
    class Employees : IViewEmployee
    {
        private List<string> SelectedSpecialties;
        private List<string> SelectedEmploymentTypes;

        public Employees()
        {
            SelectedSpecialties = new List<string>();
        }

        public List<string[]> GetEmployees(string filter)
        {
            List<ModelLayerMSSQL.Employee> employees = ModelLayerMSSQL.Employee.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (filter.Equals(""))
            {
                foreach (ModelLayerMSSQL.Employee current in employees)
                {
                    string[] tmp = new string[8];
                    tmp.SetValue(current.GetFirstName(), 0);
                    tmp.SetValue(current.GetMiddleName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetPassport(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
                    tmp.SetValue(current.GetStatus().ToString(), 7);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                foreach (ModelLayerMSSQL.Employee current in employees)
                {
                    string[] tmp = new string[8];
                    tmp.SetValue(current.GetFirstName(), 0);
                    tmp.SetValue(current.GetMiddleName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetPassport(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
                    tmp.SetValue(current.GetStatus().ToString(), 7);
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


        public List<string[]> GetEmployeeAsStatistics(string dateStart = "", string dateEnd = "", string status = "")
        {
            List<ModelLayerMSSQL.Employee> employees = ModelLayerMSSQL.Employee.GetAll();
            List<string[]> list = new List<string[]>();
            //Не используется фильтр
            if (status.Equals(""))
            {
                foreach (ModelLayerMSSQL.Employee current in employees)
                {
                    string[] tmp = new string[8];
                    tmp.SetValue(current.GetFirstName(), 0);
                    tmp.SetValue(current.GetMiddleName(), 1);
                    tmp.SetValue(current.GetSecondName(), 2);
                    tmp.SetValue(current.GetPassport(), 3);
                    tmp.SetValue(current.GetAddress(), 4);
                    tmp.SetValue(current.GetPhone(), 5);
                    tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
                    tmp.SetValue(current.GetStatus().ToString(), 7);
                    list.Add(tmp);
                }
            }
            //Используется фильтр
            else
            {
                //Если работники трудоустроены
                if(Boolean.Parse(status))
                {
                    foreach (ModelLayerMSSQL.Employee current in employees)
                    {
                        string[] tmp = new string[8];
                        tmp.SetValue(current.GetFirstName(), 0);
                        tmp.SetValue(current.GetMiddleName(), 1);
                        tmp.SetValue(current.GetSecondName(), 2);
                        tmp.SetValue(current.GetPassport(), 3);
                        tmp.SetValue(current.GetAddress(), 4);
                        tmp.SetValue(current.GetPhone(), 5);
                        tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
                        tmp.SetValue(current.GetStatus().ToString(), 7);
                        //Проверка диапазона дат
                        if(current.GetStatus() && DateIsBetween(current.GetDateWhenJobFounded(), DateTime.Parse(dateStart), DateTime.Parse(dateEnd)))
                            list.Add(tmp);
                    }
                }
                //Не трудоустроены работники
                else
                {
                    foreach (ModelLayerMSSQL.Employee current in employees)
                    {
                        string[] tmp = new string[8];
                        tmp.SetValue(current.GetFirstName(), 0);
                        tmp.SetValue(current.GetMiddleName(), 1);
                        tmp.SetValue(current.GetSecondName(), 2);
                        tmp.SetValue(current.GetPassport(), 3);
                        tmp.SetValue(current.GetAddress(), 4);
                        tmp.SetValue(current.GetPhone(), 5);
                        tmp.SetValue(Convert.ToString(current.GetExperience()), 6);
                        tmp.SetValue(current.GetStatus().ToString(), 7);
                        //Проверка диапазона дат
                        if (!current.GetStatus())
                            list.Add(tmp);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Возвращает true если дата находится между
        /// </summary>
        public bool DateIsBetween(DateTime toCompare, DateTime start, DateTime end)
        {
            if (start == end)
                return toCompare == start;
            if (start > end)
                return toCompare <= end || toCompare >= start;
            else
                return toCompare >= start && toCompare <= end;

        }

        public void RegisterEmployee(string passport, string firstName, string secondName, string middleName,
            string address, string phone, string experience)
        {
            if (passport.Equals(""))
                throw new Exception("Данные о паспорте не могут быть пустыми");
            else if (firstName.Equals(""))
                throw new Exception("Имя не может быть пустым");
            else if (secondName.Equals(""))
                throw new Exception("Фамилия не может быть пустой");
            else if (address.Equals(""))
                throw new Exception("Адрес не может быть пустым");
            try
            {
                ModelLayerMSSQL.Employee newEmpoyee = new ModelLayerMSSQL.Employee(passport, firstName, secondName,
                    middleName, address, phone, experience.Equals("") ? 0 : Convert.ToUInt32(experience));
                //Если ни одна специальность не выбрана - выбрать все
                if (SelectedSpecialties.Count == 0)
                {
                    List<ModelLayerMSSQL.Specialty> specialties = ModelLayerMSSQL.Specialty.GetAll();
                    foreach (var item in specialties)
                        SelectedSpecialties.Add(item.GetName());
                }
                foreach (string item in SelectedSpecialties)
                    newEmpoyee.AddPriorSpecialty(item);
                //Если ни один тип занятости не выбран - выбрать все
                if (SelectedEmploymentTypes.Count == 0)
                {
                    Array list = Enum.GetValues(typeof(ModelLayerMSSQL.EmploymentType));
                    foreach(var item in list)
                        SelectedEmploymentTypes.Add(item.ToString());
                }
                foreach (string item in SelectedEmploymentTypes)
                    newEmpoyee.AddPriorEmploymentType(
                        (ModelLayerMSSQL.EmploymentType)Enum.Parse(typeof(ModelLayerMSSQL.EmploymentType), item));
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

        public void ChangeEmployeeInfo(string oldPassport, string firstName, string middleName, 
            string secondName, string newPassport, string address, string phone, uint experience, string status)
        {
            ModelLayerMSSQL.Employee employee = ModelLayerMSSQL.Employee.GetByPassport(oldPassport);
            employee.ChangePassport(newPassport);
            employee.ChangeFirstName(firstName);
            employee.ChangeMiddleName(middleName);
            employee.ChangeSecondName(secondName);
            employee.ChangeAddress(address);
            employee.ChangePhone(phone);
            employee.ChangeExperience(experience);
            if( !status.Equals(""))
            {
                DateTime date = DateTime.Parse(status);
                employee.ChangeDateWhenJobFounded(date);
            }
        }

        public List<string> GetSelectedEmploymentTypes()
        {
            return this.SelectedEmploymentTypes;
        }

        public List<string> GetSelectedEmploymentTypes(string passportData)
        {
            throw new NotImplementedException();
        }

        public void SetSelectedEmploymentTypes(List<string> employmentTypes)
        {
            this.SelectedEmploymentTypes = employmentTypes;
        }

        public void SetSelectedEmploymentTypes(string passportData, List<string> employmentTypes)
        {
            throw new NotImplementedException();
        }
    }
}
