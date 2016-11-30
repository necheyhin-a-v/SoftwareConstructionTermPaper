using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа требует предварительной настройки
            DataBase.Initialize("necheukhin.ddns.net", "1521");

            Employer emp1 = Employer.GetByItn("7014026629");
        Vacancy vac = new Vacancy("Инженер технического центра", "производство",
                EmploymentType.FullTime,
                "Оказание консультационных услуг и технической поддержки потребителю касаемо особенностей работы выпускаемой предприятием продукции, методов устранения нештатных ситуаций при эксплуатации", 55000, 3);
            emp1.AddVacancy(vac);
            vac.SetEmployer("7014026629");
           /* Employer emp = new Employer(
                "7707083893",
                "ПУБЛИЧНОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО \"СБЕРБАНК РОССИИ\"",
                "117997,ГОРОД МОСКВА, УЛИЦА ВАВИЛОВА, 19",
                "");*/
            Specialty spec = Specialty.GetAll().ElementAt(0);
            /*Vacancy vac = new Vacancy("Программист C#", "7707083893", spec, 
                EmploymentType.FullTime, null, 0, 0);
            vac.Delete();*/

            //vac = new Vacancy("Другой программист", spec, EmploymentType.FullTime, "", 0, 0);

            Console.Read();
        }
    }
}
