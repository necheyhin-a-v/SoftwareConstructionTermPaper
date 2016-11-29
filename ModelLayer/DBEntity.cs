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
    /// Абстрактный класс, выполняющий подключение к базе данных
    /// Обратите внимание, что при запросах к базе данных одиночные кавычки должны дублироваться
    /// </summary>
    public abstract class DBEntity
    {
        /// <summary>
        /// Добавляет сущность в базу данных
        /// </summary>
        protected abstract void AddEntityToDB();
        /// <summary>
        /// Удаляет все записи связанные с текущей записью из базы данных
        /// </summary>
        protected abstract void DeleteEntityFromDB();
        /// <summary>
        /// Выполняет обновление на основе существующих данных в базе
        /// </summary>
        protected abstract void UpdateEntityInDB();

        /// <summary>
        /// Выполняет SQL запрос
        /// В случае невозможного выполнения запроса вызывается исключение
        /// </summary>
        /// <param name="query">Строка запроса</param>
        protected void ExecuteNonSelectQuery(String query)
        {
            try
            {
                DataBase.OpenConnection();
                DataBase.GetCommand().CommandText = query;
                int affectedRows = DataBase.GetCommand().ExecuteNonQuery();
                if (affectedRows == 0)
                    throw new Exception("Не Select запрос не изменил состояние базы данных");
            }
            catch (Exception e)
            {
                //Console.WriteLine("Ошибка выполнения не select запроса к базе данных");
                throw e;
            }
            finally
            {
                DataBase.CloseConnection();
            }
        }
        /// <summary>
        /// Выполняет select запрос к базе данных
        /// В случае ошибки вызывается исключение
        /// </summary>
        /// <param name="query">Строка запроса</param>
        /// <returns>Возвращает список, состоящий из массива объектов(столбцов)</returns>
        protected List<Object[]> ExecuteSelect(String query)
        {
            try
            {
                List<Object[]> returnedData = new List<object[]>();
                DataBase.OpenConnection();
                DataBase.GetCommand().CommandText = query;
                OracleDataReader reader = DataBase.GetCommand().ExecuteReader();
                if (!reader.HasRows)
                    return returnedData;
                while (reader.Read())
                {
                    Object[] currentLine = new Object[reader.FieldCount];
                    reader.GetValues(currentLine);  //Заполнить текущую запись полями
                    returnedData.Add(currentLine);  //Добавить текущую запись в список
                }
                DataBase.CloseConnection();
                return returnedData;

            }
            catch (Exception e)
            {
                //Console.WriteLine("Ошибка выполнения Select запроса к базе данных");
                throw e;
            }
            finally
            {
                DataBase.CloseConnection();
            }
        }
        /// <summary>
        /// Выполняет транзакцию, состоящую из массива запросов. Каждый запрос обрабатывается
        /// отдельно и в случае невыполнения одного из запросов база данных "откатывается"
        /// и все изменения, сделанные до этого также возвращаются.
        /// </summary>
        /// <param name="queries">Список запросов на выполнение.</param>
        protected void ExecuteTransaction(String[] queries)
        {
            //Создание транзакции для изменения состояния 3 таблиц
            //Если что-то пошло не так, то все изменения откатываются
            DataBase.OpenConnection();
            OracleTransaction transaction = DataBase.GetConnection().BeginTransaction(IsolationLevel.ReadCommitted);
            DataBase.GetCommand().Transaction = transaction;
            try
            {
                //Выполнить все транзакции
                //В том же методе происходит открытие соединения с базой данных
                for (int i = 0; i < queries.Count(); i++)
                {
                    DataBase.GetCommand().CommandText = queries[i];
                    int affectedRows = DataBase.GetCommand().ExecuteNonQuery();
                    if (affectedRows == 0)
                        throw new Exception("Один из запросов не изменил состояния базы данных");
                }
                //Попытка завиксировать транзакцию
                transaction.Commit();
            }
            catch (Exception errTransaction)
            {
                try
                {
                    //Отмена транзакции
                    transaction.Rollback();
                }
                catch (Exception errRollback)
                {
                    //Console.WriteLine("Сбой при откате транзакции. Данные в базе не изменены.");
                    throw errRollback;
                }
                finally
                {
                    DataBase.CloseConnection();
                }
                //Console.WriteLine("Ошибка выполнения транзакции");
                throw errTransaction;
            }
            finally
            {
                DataBase.CloseConnection();
            }
        }
    }
}
