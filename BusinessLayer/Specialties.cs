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
        private List<string> SelectedSpecialties;
        public Specialties()
        {
            SelectedSpecialties = new List<string>();
        }

        /// <summary>
        /// Метод определяет добавление специальностей
        /// </summary>
        public void AddSpecialty(string name)
        {
            ModelLayerMSSQL.Specialty specialty = new ModelLayerMSSQL.Specialty(name);
        }

        public List<string> GetSpecialties()
        {
            List<ModelLayerMSSQL.Specialty> specialties = ModelLayerMSSQL.Specialty.GetAll();
            List<string> list = new List<string>();
            foreach (ModelLayerMSSQL.Specialty specialty in specialties)
                list.Add(specialty.GetName());
            return list;
        }

        public void SetSelectedSpecialties(List<string> specialties)
        {
            throw new NotImplementedException();
        }
        public List<string> GetSelectedSpecialties()
        {
            throw new NotImplementedException();
        }
    }
}
