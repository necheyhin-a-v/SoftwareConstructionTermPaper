using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
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
            ModelLayer.DataBase.Initialize("192.168.1.50", "1521");
            //Запуск авторизации из Business уровня
            UserAutorization auth = new BusinessLayer.UserAutorization();
        }
    }
}