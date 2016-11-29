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
            DataBase.Initialize("192.168.1.50", "1521");

           Vacancy vac = new Vacancy("Консультант/аналитик 1С", Employer.GetByItn("7707083893").GetItn(), "it",
                EmploymentType.FullTime, "Консультация пользователей по функционалу программ на базе 1С", 0, 0);


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
