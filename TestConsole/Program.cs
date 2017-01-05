using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayerMSSQL;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase.Initialize("192.168.1.50", "1433");
            Employee emp = Employee.GetByPassport("6912514093");
            emp.ChangeDateWhenJobFounded(DateTime.Now);
        }
    }
}
