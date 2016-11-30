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
            Vacancy vac = Vacancy.GetAllEmployerVacancies("7707083893").ElementAt(0);
            uint saved = vac.GetRequiredExperience();
            vac.ChangeRequiredExperience(6555555);
            vac.ChangeRequiredExperience(saved);


            Console.Read();
        }
    }
}
