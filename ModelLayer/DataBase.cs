using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;         //Using oracle DB

namespace ModelLayer
{
    /// <summary>
    /// Класс для настройки базы данных, хранит 
    /// </summary>
    public static class DataBase
    {
        //Логин и пароль и схема для подключения к базе данных
        private const String SCHEMA = "PERMANENT_USER";
        private const String USER_NAME = "PERMANENT_USER";
        private const String PASSWORD = "password";

        private static OracleConnection Connection;             //Объект подключения к базе данных
        private static OracleCommand Command;                   //Объект выполнения запроса
        private static String ConnectionString;                 //Строка подключения
        private static String HostName;
        private static String Port;

        /// <summary>
        /// Инициализирует БД с портом и хостом
        /// </summary>
        /// <param name="host">Хост или ip адрес удаленного компьютера</param>
        /// <param name="port">порт</param>
        public static void Initialize(String host, String port)
        {
            HostName = host;
            Port = port;
            //Настройки можно посмотреть в файле tnsnames.ora
            ConnectionString = "Data Source=(DESCRIPTION ="
                + "(ADDRESS=(PROTOCOL = TCP)"
                + "(HOST=" + HostName + ")"
                + "(PORT=" + Port + "))"
                + "(CONNECT_DATA ="
                + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));"
                + "User Id=" + USER_NAME + ";"
                + "Password=" + PASSWORD + ";";
            Connection = new OracleConnection(ConnectionString);
            Command = new OracleCommand();
            Command.Connection = DataBase.GetConnection();
        }
        /// <summary>
        /// Открывает подключение к базе данных
        /// В случае каких-либо ошибок вызывает иключение
        /// </summary>
        public static void OpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Невозможно открыть соединение с базой данных");
            }
        }
        /// <summary>
        /// Закрывает подключение к базе данных
        /// </summary>
        public static void CloseConnection()
        {
            Connection.Close();
        }
        /// <summary>
        /// Возвращает объект подключения к базе данных
        /// </summary>
        /// <returns>Возвращает объект подключения к базе данных</returns>
        public static OracleConnection GetConnection()
        {
            return Connection;
        }
        /// <summary>
        /// Возвращает объект выполнения запроса
        /// </summary>
        /// <returns>Возвращает объект выполнения запроса</returns>
        public static OracleCommand GetCommand()
        {
            return Command;
        }
    }
}
