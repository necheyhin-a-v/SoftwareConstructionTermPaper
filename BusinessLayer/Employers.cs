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
    }
}
