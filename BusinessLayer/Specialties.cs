using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;

namespace BusinessLayer
{
    class Specialties : IViewSpecialty
    {
        /// <summary>
        /// Метод определяет добавление специальностей
        /// </summary>
        public void AddSpecialty(string name)
        {
            ModelLayerMSSQL.Specialty specialty = new ModelLayerMSSQL.Specialty(name);
        }
    }
}
