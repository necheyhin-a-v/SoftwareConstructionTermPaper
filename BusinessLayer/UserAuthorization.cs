using System;
using System.Collections.Generic;
using ModelLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Класс авторизаци
    /// </summary>
    public class UserAutorization
    {
        private User _user;
        private bool canAuth = false;
        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public UserAutorization() { }
        /// <summary>
        /// Функция возвращает возможность авторизации с указанными логином и паролем
        /// и также запрашивает данные по пользователю из БД
        /// </summary>
        /// <param name="login">Логин пользователя из базы данных</param>
        /// <param name="password">Пароль пользователя из базы данных</param>
        /// <returns>Возвращает bool</returns>
        public bool CanAuth(String login, String password)
        {
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
