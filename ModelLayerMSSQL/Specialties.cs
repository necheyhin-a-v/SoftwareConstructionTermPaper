using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayerMSSQL
{
    /// <summary>
    /// Класс специальность работает со специальностями на основе базы данных
    /// Используйте метод GetAll для поиска специальности прежде чем создать новую
    /// </summary>
    public class Specialty : DBEntity
    {
        int Id;             //ID сферы деятельности в базе данных
        String Name;        //Имя сферы деятельности

        /// <summary>
        /// Закрытый для общего доступа конструктор
        /// </summary>
        private Specialty() { }
        /// <summary>
        /// Создает новую специальность с именем name. Производится проверка существования в базе данных и если запись уже существует
        /// то возвращаются данные на основе этой записи
        /// </summary>
        /// <param name="name"></param>
        public Specialty(String name)
        {
            this.Name = name.ToLower();
            this.AddEntityToDB();
        }
        /// <summary>
        /// Удалить сферу деятельности из базы данных
        /// </summary>
        protected override void DeleteEntityFromDB()
        {
            //TODO: Specialties.DeleteEntityFromDB(). Написать реализацию метода
            throw new Exception("Дайте знать если появилось это исключение Specialties.DeleteEntityFromDB()");
        }
        /// <summary>
        /// Обновляет базу данных на основе данных в классе
        /// </summary>
        protected override void UpdateEntityInDB()
        {
            //TODO: Specialties.UpdateEntityInDB(). Написать реализацию метода
            throw new Exception("Дайте знать если появилось это исключение Specialties.UpdateEntityInDB()");
        }
        /// <summary>
        /// Возвращает список всех специальностей существующих в базе данных
        /// </summary>
        /// <returns>Список всех записей (специальностей) в БД</returns>
        public static List<Specialty> GetAll()
        {
            String query = "SELECT * FROM PERMANENT_USER.SPECIALTIES";
            List<Specialty> result = new List<Specialty>();
            try
            {
                //Временный объект без инициализации полей и другой ерунды только для доступа к базовым функциям
                Specialty temp = new Specialty();
                List<Object[]> objects = temp.ExecuteSelect(query);
                foreach (Object[] item in objects)
                {
                    Specialty current = new Specialty();
                    //Попытка преобразования объекта к специальности
                    current.Id = Convert.ToInt32(item[0]);  //id
                    current.Name = item[1].ToString();      //name
                    //Добавить в результирующий список
                    result.Add(current);
                }

                return result;
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно получить список специальностей");
                throw;
            }
        }
        /// <summary>
        /// Возвращает объект "Специальность" созданный на основе данных в базе
        /// Вызывается исключение если специальности в базе не существует
        /// </summary>
        /// <param name="name">Имя специальности</param>
        /// <returns>Объект специальности</returns>
        public static Specialty GetByName(String name)
        {
            try
            {
                Specialty specialty = new Specialty();
                String query = "SELECT * FROM PERMANENT_USER.SPECIALTIES "
                    + "WHERE SPECIALTY = '" + name +"'";
                List<Object[]> list = specialty.ExecuteSelect(query);
                if (list.Count == 0) throw new Exception("Запрос вернул 0 строк");
                specialty.Id = Convert.ToInt32(list.ElementAt(0).ElementAt(0));
                specialty.Name = list.ElementAt(0).ElementAt(1).ToString();
                return specialty;
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно получить объект специальности по имени");
                throw e;
            }
        }
        /// <summary>
        /// Возвращает объект специальности по идентификатору, переданному в качестве параметра
        /// </summary>
        /// <param name="id">Идентификатор специальности которую нужно вернуть</param>
        /// <returns>Специальность на основе данных из базы</returns>
        public static Specialty GetByID(int id)
        {
            try
            {
                Specialty specialty = new Specialty();
                String query = "SELECT * FROM PERMANENT_USER.SPECIALTIES "
                    + "WHERE ID = " + id ;
                List<Object[]> list = specialty.ExecuteSelect(query);
                if (list.Count == 0) throw new Exception("Запрос вернул 0 строк");
                specialty.Id = Convert.ToInt32(list.ElementAt(0).ElementAt(0));
                specialty.Name = list.ElementAt(0).ElementAt(1).ToString();
                return specialty;
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно получить объект специальности по имени");
                throw e;
            }
        }
        /// <summary>
        /// Проверяется можно ли получить специальность из базы данных по идентификатору
        /// </summary>
        /// <param name="id">id специальности</param>
        /// <returns>true если запись специальности с id существует в базе данных</returns>
        public static bool CanGetByID(int id)
        {
            try
            {
                Specialty specialty = new Specialty();
                String query = "SELECT * FROM PERMANENT_USER.SPECIALTIES "
                    + "WHERE ID = " + id;
                List<Object[]> list = specialty.ExecuteSelect(query);
                if (list.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при поиске специальности");
                throw e;
            }

        }
        /// <summary>
        /// Проверяет существует ли специальность в базе данных с именем name
        /// </summary>
        /// <param name="name">true если запись в базе данных существует</param>
        /// <returns></returns>
        public static bool CanGetByName(String name)
        {
            try
            {
                Specialty specialty = new Specialty();
                String query = "SELECT * FROM PERMANENT_USER.SPECIALTIES "
                    + "WHERE SPECIALTY = '" + name + "'";
                if (specialty.ExecuteSelect(query).Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при поиске специальности");
                throw e;
            }
        }
        /// <summary>
        /// Пытаемся сначала насилу запихать новую запись в базу данных (а вдруг прокатит)
        /// После вставки (успешной или нет) проверяем запросом запись и получаем ID созданных автоматически СУБД.
        /// Если запрос после вставки ничего не вернул, то значит чего-то пошло не так и невозможно добавить запись в БД
        /// </summary>
        protected override void AddEntityToDB()
        {
            List<Object[]> list;
            try
            {
                String query = "INSERT INTO PERMANENT_USER.SPECIALTIES "
                    + "(SPECIALTY) VALUES ("
                    + "'" + this.Name + "')";
                ExecuteNonSelectQuery(query);
            }
            catch (Exception)
            {
                //Либо есть дубликат в БД либо что-то пошло не так, но это особо не волнует пока не проверится ниже
            }
            //Тут уже проверяется есть ли в базе данных запись или нет. И если нет записи
            //или невозможно проверить наличие такой записи, то исключение
            try
            {
                //Проверка существует ли специальность, которую пользователь пытался добавить
                String query = "SELECT * FROM PERMANENT_USER.SPECIALTIES "
                    + "WHERE SPECIALTY = '" + this.Name + "'";
                //Проверить сначала на существование текущей роли в базе данных
                list = ExecuteSelect(query);
                //Добавить специальность в базу данных если ее нет, иначе создать объект на основе записи в базе данных
                if (list.Count == 0)
                {
                    throw new Exception("Запись не была добавлена в базу данных");
                }
                else
                {
                    //Тут тоже может быть потенциальное исключение
                    this.Id = Convert.ToInt32(list.ElementAt(0).ElementAt(0));
                }

                Console.WriteLine("Специальность создана либо на основе данных из базы, либо новая");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно добавить новую специальность");
                throw e;
            }
        }
        /// <summary>
        /// Возвращает идентификатор текущей сферы деятельности (специальности)
        /// </summary>
        /// <returns>Идентификатор специальности в базе данных</returns>
        public int GetId()
        {
            return this.Id;
        }
        /// <summary>
        /// Возвращает текущее имя специальности
        /// </summary>
        /// <returns>Название специальности (сферы деятельности)</returns>
        public String GetName()
        {
            return this.Name;
        }
    }
}
