using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace ModelLayer
{
    /// <summary>
    /// Роли пользователя на основе которых будет определяться доступный пользователю функционал
    /// </summary>
    public enum UserRoles
    {
        /// <summary>
        /// Консультант
        /// </summary>
        Consultant = 1,
        /// <summary>
        /// Человек, который добавляет информацию о работодателях в базу данных
        /// </summary>
        Moderator = 2
    }



    /// <summary>
    /// Класс User отражает часть схемы базы данных, хранящую информацию
    /// о пользователях и их привелегиях или ролях
    /// При смене имени роли в базе данных (руками) проверка на соответствие не делается.
    /// Существующего идентификатора достаточно для работы программы. Однако если нет идентификатора, то программа добавит его
    /// </summary>
    
    public class User : DBEntity
    {
        private String Login;
        private String Password;
        private int RoleId;

        private User() { }
        /// <summary>
        /// Создать нового пользователя и поместить его в базу данных
        /// В случае ошибки вызывается исключение, например логин уже существует
        /// </summary>
        /// <param name="login">Логин нового пользователя</param>
        /// <param name="password">Пароль нового пользователя</param>
        /// <param name="role">Строка отражающая роль пользователя</param>
        //TODO: User.User() При инициализации объекта добавить проверку целостности базы данных на соответствие имен ролей пользователей и их индексов
        public User(String login, String password, UserRoles role = UserRoles.Consultant)
        {
            this.Login = login;
            this.Password = password;
            this.RoleId = (int)role;
            AddEntityToDB();
        }

        /// <summary>
        /// Функция ищет пользователя по логину
        /// Обратите внимание, что это статическая функция и может быть вызвана без создания объекта
        /// </summary>
        /// <param name="login">Логин пользователя для поиска в базе данных</param>
        /// <returns>true, если пользователь с таким логином существует</returns>
        public static Boolean CanFindByLogin(String login)
        {
            String query = "SELECT * FROM PERMANENT_USER.USERS "
                + "WHERE USERLOGIN = '" + login + "'";
            User newUser = new User();
            if (newUser.ExecuteSelect(query).Count != 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Функция возвращает объект пользователя инициализированный на основе данных из базы данных
        /// </summary>
        /// <param name="login">Логин пользователя из базы данных</param>
        /// <returns>Возвращает объект или null</returns>
        public static User GetByLogin(String login)
        {
            String query = "SELECT USERS.USERLOGIN, USERS.USERPASSWORD, USERROLES.ROLEID "
                + "FROM PERMANENT_USER.USERS, PERMANENT_USER.USERROLES "
                + "WHERE USERS.USERLOGIN = '" + login + "' "
                + "AND USERROLES.USERLOGIN = USERS.USERLOGIN";
            User newUser = new User();
            List<Object[]> list = newUser.ExecuteSelect(query);
            if (list.Count == 0)
                return null;
            else
            {
                try
                {
                    newUser.Login = list.ElementAt(0).ElementAt(0).ToString();
                    newUser.Password = list.ElementAt(0).ElementAt(1).ToString();
                    newUser.RoleId = Convert.ToInt32(list.ElementAt(0).ElementAt(2));
                    return newUser;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Невозможно корректно преобразовать данные из базы");
                    throw e;
                }
            }
        }
        /// <summary>
        /// Сменить пароль для пользователя
        /// </summary>
        /// <param name="newPassword">Новый пароль для записи в базу данных</param>
        public void ChangePassword(String newPassword)
        {
            String query = "UPDATE PERMANENT_USER.USERS "
                + "SET USERPASSWORD = '" + newPassword + "'"
                + "WHERE USERPASSWORD = '" + this.Password + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.Password = newPassword;
                Console.WriteLine("Пароль пользователя изменен");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения пароля");
                throw e;
            }
        }
        /// <summary>
        /// Изменяет текущую роль пользователя
        /// </summary>
        /// <param name="newRole">Новая роль пользователя</param>
        public void ChangeRole(UserRoles newRole)
        {
            List<Object[]> list;    //Список для проверки существования роли пользователя в БД
            String[] queries;       //Массив запросов для транзакции
            int indexQuery = 0;     //Индекс текущего запроса. Для составления динамической транзакции
            try
            {
                //Проверка существует ли роль, которую пользователь пытается добавить
                String query = "SELECT * FROM PERMANENT_USER.ROLES "
                    + "WHERE ROLEID = '" + (int)newRole + "'";
                //Проверить сначала на существование текущей роли в базе данных
                list = ExecuteSelect(query);
                //Добавить роль пользователя в базу данных если по каким-то причинам ее нет
                if (list.Count == 0)
                {
                    queries = new String[2];
                    queries[indexQuery++] = "INSERT INTO PERMANENT_USER.ROLES "
                        + "(ROLEID, ROLENAME) "
                        + "VALUES ("
                        + "'" + (int)newRole + "', "
                        + "'" + newRole.ToString() + "')";
                }
                else
                    queries = new String[1];
                queries[indexQuery++] = "UPDATE PERMANENT_USER.USERROLES " 
                    + "SET ROLEID = '" + (int)newRole + "'"
                    + "WHERE USERLOGIN = '" + this.Login + "'";
                //Выполнение транзакции
                ExecuteTransaction(queries);
                Console.WriteLine("Роль пользователя изменена");
            }
            catch(Exception e)
            {
                Console.WriteLine("Невозможно сменить роль пользователя");
                throw e;
            }
        }
        /// <summary>
        /// Удаляет текущего пользователя из базы данных.
        /// Вызывает исключение в случае ошибки
        /// </summary>
        public void DeleteUser()
        {
            DeleteEntityFromDB();
        }
        /// <summary>
        /// Удаляются все связанные записи с сущностью DBEntity из базы данных
        /// Ссылка на DBEntity после успешного удаления равна NULL
        /// В случае ошибки - исключение
        /// </summary>
        protected override void DeleteEntityFromDB()
        {
            try
            {
                String query = @"DELETE FROM PERMANENT_USER.USERS "
                + "WHERE USERLOGIN = "
                + "'" + this.Login + "'";
                ExecuteNonSelectQuery(query);
                Console.WriteLine("Учетная запись пользователя успешно удалена");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно удалить учетную запись из базы");
                throw e;
            }
        }

        /// <summary>
        /// защищенная функция, вставляет в базу данных запись на основе login, password, role
        /// </summary>
        protected override void AddEntityToDB()
        {
            List<Object[]> list;
            String[] queries;
            int indexQuery = 0;
            try
            {
                //Проверка существует ли роль, которую пользователь пытается добавить
                String query = "SELECT * FROM PERMANENT_USER.ROLES "
                    + "WHERE ROLEID = '" + this.RoleId + "'";
                //Проверить сначала на существование текущей роли в базе данных
                list = ExecuteSelect(query);
                //Добавить роль пользователя в базу данных если по каким-то причинам ее нет
                if (list.Count == 0)
                {
                    queries = new String[3];
                    //Попытка преобразовать индекс роли в ее имя для занесения в базу данных
                    UserRoles currentRole = (UserRoles)Enum.Parse(typeof(UserRoles), this.RoleId.ToString());
                    queries[indexQuery++] = "INSERT INTO PERMANENT_USER.ROLES "
                        + "(ROLEID, ROLENAME) "
                        + "VALUES ("
                        + "'" + this.RoleId + "', "
                        + "'" + currentRole.ToString() + "')";
                }
                else
                    queries = new String[2];

                queries[indexQuery++] = @"INSERT INTO PERMANENT_USER.USERS "
                    + "(USERLOGIN, USERPASSWORD)"
                    + "VALUES ("
                    + "'" + this.Login + "',"
                    + "'" + this.Password + "')";
                queries[indexQuery++] = @"INSERT INTO PERMANENT_USER.USERROLES"
                    + "(ROLEID, USERLOGIN)"
                    + "VALUES ("
                    + "'" + this.RoleId + "',"
                    + "'" + this.Login + "')";

                ExecuteTransaction(queries);
                Console.WriteLine("Учетная запись успешно создана");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно создать нового пользователя");
                throw e;
            }
        }
        /// <summary>
        /// Функция возвращает текущий пароль пользователя
        /// Используйте шифрование перед установкой пароля для того, чтобы пароль не передавался в открытом виде
        /// </summary>
        /// <returns>Текущий пароль пользователя</returns>
        public String GetPassword()
        {
            return this.Password;
        }
        /// <summary>
        /// Возвращает логин пользователя. Обратите внимание, что по архитектуре сменить логин невозможно
        /// </summary>
        /// <returns>Текущий логин пользователя</returns>
        public String GetLogin()
        {
            return this.Login;
        }
        /// <summary>
        /// Возвращает текущую роль пользователя
        /// </summary>
        /// <returns>Текущая роль пользователя</returns>
        public UserRoles GetRole()
        {
            try
            {
                return (UserRoles)Enum.Parse(typeof(UserRoles), this.RoleId.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно распознать роль пользователя");
                throw e;
            }
        }
        /// <summary>
        /// Обновляет сущность на основе данных класса в базе данных
        /// </summary>
        protected override void UpdateEntityInDB()
        {
            //TODO: User.UpdateEntityInDB(). Написать реализацию метода
            throw new Exception("Дайте знать если появилось это исключение Users.UpdateEntityInDB()");
        }
    }
}
