using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLayer;

namespace ViewLayer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Программа требует предварительной настройки
            //DataBase.Initialize("necheukhin.ddns.net", "1521");
            DataBase.Initialize("192.168.1.50", "1521");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
