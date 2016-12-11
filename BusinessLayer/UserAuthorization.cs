using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLayer;
using ViewLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Класс авторизаци
    /// </summary>
    public class UserAutorization : IViewAuth
    {
        private User _user;
        private bool canAuth = false;
        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public UserAutorization()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization(this));


        }
        /// <summary>
        /// Функция возвращает возможность авторизации с указанными логином и паролем
        /// и также запрашивает данные по пользователю из БД
        /// </summary>
        /// <param name="login">Логин пользователя из базы данных</param>
        /// <param name="password">Пароль пользователя из базы данных</param>
        /// <returns>Возвращает bool</returns>
        public bool CanAuth(String login, String password)
        {
            canAuth = false;
            if(User.CanFindByLogin(login))
            {
                _user = User.GetByLogin(login);
                if(_user != null)
                    if (_user.GetPassword() == password)
                    {
                        canAuth = true;
                    }
            }
            return canAuth;
        }

        /// <summary>
        /// Функция возвращает роль текущего авторизованного пользователя
        /// </summary>
        /// <returns>Возвращает UserRoles</returns>
        public UserRoles GetRole()
        {
            if (canAuth)
                return _user.GetRole();
            else
                throw new Exception("Невозможно авторизоваться");
        }
    }
}
