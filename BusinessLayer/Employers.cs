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
            throw new Exception("Нужно реализовать метод получения вакансий для работодателя");
        }

        public void RegisterEmployer(string name, string itn, string address, string phone)
        {
            throw new Exception("Нужно реализовать регистрацию работодателя");
        }
    }
}
