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
        /// Создать вакансию предпринимателя
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="employerItn">ИНН работодателя, для которого создается вакансия.
        /// ИНН должен существовать в базе данных</param>
        /// <param name="specialty">Специальность для вакансии</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        void CreateVacancy(String name, String employerItn, String specialty, int type,
            String description, uint salary, uint requiredExperience);
        /// <summary>
        /// Получить список работодателей
        /// name1, itn1, address1, phone1
        /// name2, itn2, address2, phone2
        /// ...
        /// </summary>
        /// <returns></returns>
        List<string[]> GetEmployers(string filter = "");
        /// <summary>
        /// Получить список вакансий
        /// В виде:
        /// имя вакансии, специальность, предприятие, требуемый опыт, тип занятости, оплата, описание
        /// </summary>
        List<string[]> GetVacancies(string filter = "");
        /// <summary>
        /// Получить список типов занятости
        /// </summary>
        List<string> GetEmploymentTypes();
        /// <summary>
        /// Получить список специальностей
        /// </summary>
        List<string> GetSpecialties();
        /// <summary>
        /// Добавить специальность
        /// </summary>
        void AddSpecialty(string name);
    }
}
