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
        void RegisterEmployee(string passport, string firstName, string secondName, string middleName, string address,
                                        string phone, string experience);
        /// <summary>
        /// Получить список работников
        /// name1, itn1, address1, phone1
        /// name2, itn2, address2, phone2
        /// ...
        /// </summary>
        List<string[]> GetEmployees(string filter = "");
        /// <summary>
        /// Получить список специальностей, выбранных пользователем
        /// </summary>
        List<string> GetSelectedSpecialties();
        /// <summary>
        /// Установить список специальностей, выбранных пользователем
        /// </summary>
        void SetSelectedSpecialties(List<string> specialties);
        /// <summary>
        /// Установить выбранные специальности для работника и сохранить 
        /// значения для конкретного работника
        /// </summary>
        void SetSelectedSpecialties(string passportData, List<string> specialties);
        /// <summary>
        /// Получить выбранные специальности для конкретного работника
        /// </summary>
        List<string> GetSelectedSpecialties(string passportData);

        /// <summary>
        /// Изменение информации о работнике
        /// </summary>
        void ChangeEmployeeInfo(string oldPassport, string firstName, string middleName,string secondName,
            string newPassport, string address, string phone, uint experience, string status);
        /// <summary>
        /// Получить список типов занятости, выбранных пользователем
        /// </summary>
        List<string> GetSelectedEmploymentTypes();
        /// <summary>
        /// Получить выбранные типы занятости для конкретного работника
        /// </summary>
        List<string> GetSelectedEmploymentTypes(string passportData);
        /// <summary>
        /// Установить список типов занятостей, выбранных пользователем
        /// </summary>
        void SetSelectedEmploymentTypes(List<string> employmentTypes);
        /// <summary>
        /// Установить выбранные типы занятостей для работника и сохранить 
        /// значения для конкретного работника
        /// </summary>
        void SetSelectedEmploymentTypes(string passportData, List<string> employmentTypes);
        /// <summary>
        /// Получение работников, удовлетворяющих фильтрам
        /// </summary>
        /// <param name="dateStart">дата начала диапазона</param>
        /// <param name="dateEnd">дата окончания диапазона</param>
        /// <param name="status">статус (true, false) о трудоустройстве</param>
        /// <returns></returns>
        List<string[]> GetEmployeeAsStatistics(string dateStart = "", string dateEnd = "", string status = "");
    }
}
