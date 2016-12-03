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


            //Employee emp = new Employee("6909847329", "Анастасия", "Минкевич", "Владимировна", "г. Томск, ул. Сибирская, д. 101, кв. 2", "", 8);
            //uint experience = emp.GetExperience();

            Employee emp = Employee.GetByPassport("6912514093");
            emp.AddPriorSpecialty("it");
            List<Specialty> list = emp.GetPriorSpecialties();
            Console.Read();
        }
    }
}
