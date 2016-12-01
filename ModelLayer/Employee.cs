using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;


namespace ModelLayer
{
    /// <summary>
    /// Класс взаимодействуя с базой данных на низком уровне
    /// извлекает информацию из БД, сохраняет информацию и т.д. 
    /// </summary>
    public class Employee : DBEntity
    {
        private String PassportNumber;
        private String FirstName;
        private String SecondName;
        private String MiddleName;
        private String Address;
        private String Phone;
        private Boolean HasFoundJob;
        private DateTime DateWhenWorkFounded;
        private uint Experience;                //Опыт работы в месяцах
        /// <summary>
        /// Конструктор закрыт для внешнего воздействия
        /// </summary>
        private Employee() { }
        /// <summary>
        /// Создает объект на основе параметров и добавляет в базу данных
        /// </summary>
        /// <param name="passportNumber">Паспорт(серия и номер без пробела)</param>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="middleName">Отчество (может быть null)</param>
        /// <param name="address">Адрес регистрации</param>
        /// <param name="phone">Номер телефона</param>
        /// <param name="experience">Опыт работы в месяцах</param>
        public Employee(String passportNumber, String firstName, String secondName, String middleName,
            String address, String phone, uint experience)
        {
            this.PassportNumber = passportNumber;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.MiddleName = middleName;
            this.Address = address;
            this.Phone = phone;
            this.HasFoundJob = false;
            this.Experience = experience;
            AddEntityToDB();
        }
        /// <summary>
        /// Проверяет может ли быть найдена запись по паспорту в базе данных или нет.
        /// </summary>
        /// <param name="passport">Серия и номер паспорта без пробела</param>
        /// <returns>True если запись в базе данных существует</returns>
        public static Boolean CanFindByPassport(String passport)
        {
            String query = "SELECT * FROM PERMANENT_USER.EMPLOYEE "
                + "WHERE PASSPORT = '" + passport + "'";
            Employee newEmployee = new Employee();
            if (newEmployee.ExecuteSelect(query).Count != 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Пытается найти человека по номеру паспорта, создает объект и возвращает ссылку на него. 
        /// Обратите внимание, что это статический метод, может использоваться без создания объекта
        /// </summary>
        /// <param name="passport">Серия и номер паспорта без пробела</param>
        /// <returns>Возвращает новый инициализированный объект Employee на основе данных из базы данных</returns>
        /// <returns>Или возвращает ссылку на null если данных нет в базе данных</returns>
        public static Employee GetByPassport(String passport)
        {
            String query = "SELECT * FROM PERMANENT_USER.EMPLOYEE "
                + "WHERE PASSPORT = '" + passport + "'";
            Employee newEmployee = new Employee();
            List<Object[]> list = newEmployee.ExecuteSelect(query);
            //Ожидается, что будет возвращен один объект
            if (list.Count == 0)
                return null;
            else
            {
                try
                {
                    newEmployee.PassportNumber = (String)list.ElementAt(0).ElementAt(0);
                    newEmployee.FirstName = (String)list.ElementAt(0).ElementAt(1);
                    newEmployee.SecondName = (String)list.ElementAt(0).ElementAt(2);
                    newEmployee.MiddleName = (String)list.ElementAt(0).ElementAt(3);
                    newEmployee.Address = (String)list.ElementAt(0).ElementAt(4);
                    newEmployee.Phone = (String)list.ElementAt(0).ElementAt(5);
                    if (list.ElementAt(0).ElementAt(6).ToString().CompareTo("") == 0)
                    {
                        newEmployee.HasFoundJob = false;
                    }
                    else
                    {
                        newEmployee.HasFoundJob = true;
                        newEmployee.DateWhenWorkFounded = (DateTime)list.ElementAt(0).ElementAt(6);
                    }
                    newEmployee.Experience = Convert.ToUInt32(list.ElementAt(0).ElementAt(7));
                    return newEmployee;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Невозможно корректно преобразовать данные из базы");
                    throw e;
                }
            }                
        }
        /// <summary>
        /// Вставляет новую запись в базу данных
        /// Вызывает исключение если невозможно вставить запись в базу данных
        /// </summary>
        protected override void AddEntityToDB()
        {
            String query = "INSERT INTO PERMANENT_USER.EMPLOYEE"
                + "(PASSPORT, FIRSTNAME, SECONDNAME, MIDDLENAME, ADDRESS, PHONE, HASFOUNDJOB, EXPERIENCE)"
                + "VALUES ("
                + "'" + this.PassportNumber + "',"
                + "'" + this.FirstName + "',"
                + "'" + this.SecondName + "',"
                + "'" + this.MiddleName + "',"
                + "'" + this.Address + "',"
                + "'" + this.Phone + "',"
                + "'" + (this.HasFoundJob ? DateWhenWorkFounded.ToString("dd.MM.yy") : null) + "', "
                + this.Experience;
            try
            {
                ExecuteNonSelectQuery(query);
                Console.WriteLine("Вставлена новая запись в базу данных");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно вставить новую запись в базу данных");
                throw e;
            }

        }
        /// <summary>
        /// Удаляет существующую запись пользователя и все связанные с ней из базы данных
        /// </summary>
        public void Delete()
        {
            this.DeleteEntityFromDB();
        }
        /// <summary>
        /// Удаляет текущую сущность из базы данных.
        /// Обратите внимание, что после удаления все параметры текущего объекта остаются и
        /// вызвав метод UPDATE можно вернуть данные в базу
        /// Вызывает исключение в случае невозможности удаления данных
        /// </summary>
        protected override void DeleteEntityFromDB()
        {
            try
            {
                String query = "DELETE FROM PERMANENT_USER.EMPLOYEE "
                    + "WHERE PASSPORT = "
                    + "'" + this.PassportNumber + "'";
                ExecuteNonSelectQuery(query);
                Console.WriteLine("Удалена запись из базы данных");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно удалить запись из базы");
                throw e;
            }
        }
        /// <summary>
        /// Установить сущности новый номер паспорта и изменить запись в базе данных
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        /// <param name="newPassportNumber">Серия и номер паспорта для смены старого</param>
        public void ChangePassport(String newPassportNumber)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET PASSPORT = '" + newPassportNumber + "'"
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.PassportNumber = newPassportNumber;
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка изменения паспорта");
                throw e;
            }

        }
        /// <summary>
        /// Установить новое имя и внести исправления в базу данных
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        /// <param name="newFirstName">Новое имя</param>
        public void ChangeFirstName(String newFirstName)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET FIRSTNAME = '" + newFirstName + "'"
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.FirstName = newFirstName;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения имени");
                throw e;
            }

        }
        /// <summary>
        /// Установить новую фамилию и внести исправления в базу данных
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        /// <param name="newSecondName">Новая фамилия</param>
        public void ChangeSecondName(String newSecondName)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET SECONDNAME = '" + newSecondName + "'"
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.SecondName = newSecondName;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения фамилии") ;
                throw e;
            }

        }
        /// <summary>
        /// Изменение отчества и внесение исправления в базу данных
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        /// <param name="newMiddleName">Новое отчество</param>
        public void ChangeMiddleName(String newMiddleName)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET MIDDLENAME = '" + newMiddleName + "'"
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.MiddleName = newMiddleName;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения отчества");
                throw e;
            }
        }
        /// <summary>
        /// Смена адреса и внесение исправления в базу данных
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        /// <param name="newAddress">Новый адрес</param>
        public void ChangeAddress(String newAddress)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET ADDRESS = '" + newAddress + "'"
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.Address = newAddress;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения адреса");
                throw e;
            }
        }
        /// <summary>
        /// Смена телефона и внесение исправления в базу данных
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        /// <param name="newPhone">Новый номер телефона</param>
        public void ChangePhone(String newPhone)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET PHONE = '" + newPhone + "'"
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.Phone = newPhone;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения телефона");
                throw e;
            }
        }
        /// <summary>
        /// Устанавливает дату, когда была найдена работа сотрудником
        /// В случае ошибки вызывается ислкючение и поле остается неименным
        /// </summary>
        public void ChangeDateWhenJobFounded(DateTime newDate)
        {
            String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                + "SET HASFOUNDJOB = :newDate "
                + "WHERE PASSPORT = '" + this.PassportNumber + "'";
            DataBase.GetCommand().Parameters.Add(new OracleParameter("newDate",
                                       OracleDbType.Date,
                                       newDate,
                                       ParameterDirection.InputOutput));

            try
            {
                ExecuteNonSelectQuery(query);
                //Если запись может быть успешно добавлена в базу данных, только тогда
                //происходит смена текущего параметра в базе данных
                this.DateWhenWorkFounded = newDate;
                this.HasFoundJob = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения даты, когда найдена работа сотрудником");
                throw e;
            }
            finally
            {
                DataBase.GetCommand().Parameters.Clear();   //Очистить список параметров после использования
            }


        }
        /// <summary>
        /// Возвращает значение пасспорта для текущего объекта
        /// </summary>
        /// <returns>Возвращает паспорт в виде серия и номер без пробела</returns>
        public String GetPassport()
        {
            return this.PassportNumber;
        }
        /// <summary>
        /// Получить имя
        /// </summary>
        /// <returns>Возвращает имя</returns>
        public String GetFirstName()
        {
            return this.FirstName;
        }
        /// <summary>
        /// Получить фамилию
        /// </summary>
        /// <returns>Возвращает фамилию</returns>
        public String GetSecondName()
        {
            return this.SecondName;
        }
        /// <summary>
        /// Получить отчество
        /// </summary>
        /// <returns>Возвращает отчество или "-" в случае отсутствия такового</returns>
        public String GetMiddleName()
        {
            try
            {
                return this.MiddleName;
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// Получить адрес места жительства
        /// </summary>
        /// <returns>Возвращает адрес</returns>
        public String GetAddress()
        {
            return this.Address;
        }
        /// <summary>
        /// Получить номер телефона
        /// </summary>
        /// <returns>Возвращает номер телефона или "-" в случае отсутствия такогого</returns>
        public String GetPhone()
        {
            try
            {
                return this.Phone;
            }
            catch
            {
                return "";
            }
            
        }
        /// <summary>
        /// Возвращает статус о том найдена ли работа или еще в поиске
        /// </summary>
        /// <returns>Возвращает true в случае если человек нашел работу</returns>
        public Boolean GetStatus()
        {
            return this.HasFoundJob;
        }
        /// <summary>
        /// Возвращает дату, когда работа была найдена
        /// Либо выдает исключение о том, что невозможно получить дату
        /// </summary>
        /// <returns>Возвращает дату</returns>
        public DateTime GetDateWhenJobFounded()
        {
            if (this.HasFoundJob == true)
                return this.DateWhenWorkFounded;
            else
                throw new Exception("Невозможно получить дату");
        }
        /// <summary>
        /// Возвращает имя отчество и фамилию
        /// </summary>
        /// <returns>Возвращает строку в виде Имя Отчество Фамилия</returns>
        public override string ToString()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.SecondName;
        }
        /// <summary>
        /// Обновить данные о рабочем в базе данных на основе данных из класса
        /// </summary>
        protected override void UpdateEntityInDB()
        {
            //TODO: Employee.UpdateEntityInDB(). Написать реализацию метода
            throw new Exception("Дайте знать если появилось это исключение Employee.UpdateEntityInDB()");
        }
        /// <summary>
        /// Получает список всех работников из базы даных
        /// </summary>
        /// <returns>Список объектов (работников)</returns>
        public static List<Employee> GetAll()
        {
            try
            {
                String query = "SELECT * FROM PERMANENT_USER.EMPLOYEE";
                //Временный объект для получения функционала базового класса
                Employee temp = new Employee();
                List<Object[]> list = temp.ExecuteSelect(query);
                if (list.Count == 0) throw new Exception("Невозможно получить список работников");
                List<Employee> result = new List<Employee>();
                foreach (Object[] currentObject in list)
                {
                    Employee newEmployee = new Employee();
                    newEmployee.PassportNumber = currentObject.ElementAt(0).ToString();
                    newEmployee.FirstName = currentObject.ElementAt(1).ToString();
                    newEmployee.SecondName = currentObject.ElementAt(2).ToString();
                    newEmployee.MiddleName = currentObject.ElementAt(3).ToString();
                    newEmployee.Address = currentObject.ElementAt(4).ToString();
                    if(currentObject.ElementAt(5).ToString().CompareTo("") == 0)
                        newEmployee.HasFoundJob = false;
                    else
                    {
                        newEmployee.HasFoundJob = true;
                        newEmployee.DateWhenWorkFounded = (DateTime)currentObject.ElementAt(5);
                    }
                    newEmployee.Experience = Convert.ToUInt32(currentObject.ElementAt(6));
                    result.Add(newEmployee);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно получить список работников");
                throw e;
            }

        }
        /// <summary>
        /// Получить из базы данных опыт работы в месяцах
        /// </summary>
        /// <returns>Опыт работы сотрудника в месяцах</returns>
        public uint GetExperience()
        {
            return this.Experience;
        }
        /// <summary>
        /// Сменить опыт работника и обновить данные в базе
        /// </summary>
        /// <param name="newExperience">Новый опыт работы в месяцах</param>
        public void ChangeExperience(uint newExperience)
        {
            try
            {
                String query = "UPDATE PERMANENT_USER.EMPLOYEE "
                    +"SET EXPERIENCE = " + newExperience;
                ExecuteNonSelectQuery(query);
                //Изменение поля происходит только после успешного изменения в базе данных
                this.Experience = newExperience;
                Console.WriteLine("Опыт работника успешно изменен");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить опыт работника");
                throw e;
            }
        }


    }
}
