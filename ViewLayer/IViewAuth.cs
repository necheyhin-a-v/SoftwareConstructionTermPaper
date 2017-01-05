using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    /// <summary>
    /// Интерфейс для взаимодейтсвия с формой авторизации
    /// </summary>
    public interface IViewAuth
    {
        /// <summary>
        /// Проверка возможности авторизации
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CanAuth(String login, String password);
    }
}
