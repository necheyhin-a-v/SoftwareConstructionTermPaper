using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    /// <summary>
    /// Интерфейс для взаимодействия с формой AddSpecialty
    /// </summary>
    public interface IViewSpecialty
    {
        /// <summary>
        /// Добавить новую специальность
        /// </summary>
        void AddSpecialty(string name);
        /// <summary>
        /// Получить список специальностей из базы данных
        /// </summary>
        List<string> GetSpecialties();
        /// <summary>
        /// Получить список всех типов занятости
        /// </summary>
        List<string> GetEmploymentTypes();
    }
}