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
        /// Добавить специальность
        /// </summary>
        void AddSpecialty(string name);
    }
}