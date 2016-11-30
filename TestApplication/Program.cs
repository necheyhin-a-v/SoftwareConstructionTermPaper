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

            Vacancy vac = Vacancy.GetAll().ElementAt(0);
            String savedName = vac.GetName();
            vac.ChangeName("NewName");
            vac.ChangeName(savedName);

            Console.Read();
        }
    }
}
