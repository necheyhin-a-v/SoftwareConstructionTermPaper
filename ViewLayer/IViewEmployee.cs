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
    public interface IViewEmployee
    {
        /// <summary>
        /// Зарегистрировать работника
        /// </summary>
        /// <param name="passport">Паспортные данные работника</param>
        /// <param name="firstName">Имя работника</param>
        /// <param name="secondName">Фамилия работника</param>
        /// <param name="middleName">Отчество работника</param>
        /// <param name="address">Адрес работника</param>
        /// <param name="phone">Телефон работника</param>
        /// <param name="experience">Опыт работника</param>
        /// <param name="specialty">Предпочитаемая специальность работника</param>
        void RegisterEmployee(string passport, string firstName, string secondName, string middleName, string address,
                                        string phone, string experience, string specialty);
        /// <summary>
        /// Получить список работников
        /// name1, itn1, address1, phone1
        /// name2, itn2, address2, phone2
        /// ...
        /// </summary>
        /// <returns></returns>
        List<string[]> GetEmployees(string filter = "");
    }
}
