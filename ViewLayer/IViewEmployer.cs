using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    /// <summary>
    /// Интерфейс для взаимодействия со слоем представления
    /// </summary>
    public interface IViewEmployer
    {
        /// <summary>
        /// Зарегистрировать предпринимателя или предприятие
        /// </summary>
        /// <param name="name">Название организации</param>
        /// <param name="itn">ИНН предприятия</param>
        /// <param name="address">Адрес</param>
        /// <param name="phone"></param>
        void RegisterEmployer(string name, string itn, string address, string phone);
        /// <summary>
        /// Получить список работодателей
        /// name1, itn1, address1, phone1
        /// name2, itn2, address2, phone2
        /// ...
        /// </summary>
        /// <returns></returns>
        List<string[]> GetEmployers(string filter = "");
    }
}
