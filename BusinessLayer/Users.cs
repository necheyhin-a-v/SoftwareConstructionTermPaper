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
    public class Users : IViewAuth
    {
        private User CurrentUser;
        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public Users() { }
        /// <summary>
        /// Функция возвращает возможность авторизации с указанными логином и паролем
        /// и также запрашивает данные по пользователю из БД
        /// </summary>
        /// <param name="login">Логин пользователя из базы данных</param>
        /// <param name="password">Пароль пользователя из базы данных</param>
        /// <returns>Возвращает bool</returns>
        public bool CanAuth(String login, String password)
        {
            bool canAuth = false;
            if(User.CanFindByLogin(login))
            {
                CurrentUser = User.GetByLogin(login);
                if(CurrentUser != null)
                    if (CurrentUser.GetPassword() == password)
                    {
                        canAuth = true;
                    }
            }
            return canAuth;
        }
        /// <summary>
        /// Возвращает авторизованного пользователя, либо исключение
        /// </summary>
        public User GetAuthorizedUser()
        {
            if (CurrentUser != null)
                return CurrentUser;
            else
                return null;
        }
        /// <summary>
        /// Функция возвращает роль текущего авторизованного пользователя
        /// </summary>
        /// <returns>Возвращает UserRoles</returns>
        public UserRoles GetRole()
        {
            if (CurrentUser != null)
                return CurrentUser.GetRole();
            else
                throw new Exception("Пользователь не авторизован");
        }
        /// <summary>
        /// Сбросить существующую авторизацию
        /// </summary>
        public void Unauthorize()
        {
            this.CurrentUser = null;
        }
    }
}
