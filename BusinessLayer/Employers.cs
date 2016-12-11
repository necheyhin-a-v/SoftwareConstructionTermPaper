using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using ModelLayer;

namespace BusinessLayer
{
    class Employers : IViewEmployer
    {
        public List<string[]> GetEmployers()
        {
            List<Employer> employers = Employer.GetAll();
            List<string[]> list = new List<string[]>();
            foreach(Employer current in employers)
            {
                string[] tmp = new string[4];
                tmp.SetValue(current.GetName(), 0);
                tmp.SetValue(current.GetItn(), 1);
                tmp.SetValue(current.GetAddress(), 2);
                tmp.SetValue(current.GetPhone(), 3);
                list.Add(tmp);
            }
            return list;
        }

        public List<string[]> GetVacancies()
        {
            List<Vacancy> vacancies = Vacancy.GetAll();
            List<string[]> list = new List<string[]>();
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
            return list;
        }

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
    }
}
