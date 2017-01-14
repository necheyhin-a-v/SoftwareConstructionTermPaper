using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Programm
{
    static class Programm
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //Программа требует предварительной настройки
                //ModelLayerMSSQL.DataBase.Initialize("necheukhin.ddns.net", "1433");
                ModelLayerMSSQL.DataBase.Initialize("192.168.1.50", "1433");
                //Создание нового контроллера форм
                BusinessLayer.FormController controller = new BusinessLayer.FormController();
                //Передать дальнейшее управление контролееру форм
                controller.Authorization();
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Application.Run();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Main();
            }

        }
    }
}