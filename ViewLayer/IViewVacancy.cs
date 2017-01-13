using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    /// <summary>
    /// Интерфейс взаимодействия с формой AddVacancy
    /// </summary>

    public interface IViewVacancy
    {
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
        void CreateVacancy(String name, String employerItn, String specialty, String type,
            String description, uint salary, uint requiredExperience);
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
        /// Изменить параметры вакансии с именем oldName
        /// </summary>
        /// <param name="oldEmployerName">Старое наименование работодателя</param>
        /// <param name="oldName">Старое наименование вакансии</param>
        /// <param name="newSpecialty">Специальность в строковом формате</param>
        /// <param name="newName">Имя вакансии</param>
        /// <param name="newExperience">Опыт работы в месяцах</param>
        /// <param name="newEmploymentType">Тип занятости</param>
        /// <param name="newSalary">Зарплата</param>
        /// <param name="newDescription">Описание вакансии</param>
        void ChangeVacancy(string oldEmployerName, string oldName, string newSpecialty, string newName, uint newExperience,
    string newEmploymentType, uint newSalary, string newDescription);
    }
}
