﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    /// <summary>
    /// Тип занятости предполагающий вакансию
    /// </summary>
    public enum EmploymentType
    {
        /// <summary>
        /// Вакансия с полной занятостью
        /// </summary>
        FullTime = 1,
        /// <summary>
        /// Вакансия с частичной занятостью
        /// </summary>
        PartTime = 2,
        /// <summary>
        /// Стажировка
        /// </summary>
        Traineeship = 3,
        /// <summary>
        /// Волонтерство
        /// </summary>
        Volunteering = 4
    }
    /// <summary>
    /// Класс Vacancy отражает часть схемы базы данных, хранящую информацию
    /// о вакансиях
    /// </summary>
    public class Vacancy : DBEntity
    {
        private String Name;                //Имя вакансии - уникально для каждого работодателя
        private String EmployerItn;         //ИНН работодателя предоставляющего вакансию
        private Specialty CurrentSpecialty; //Специальность для вакансии
        private EmploymentType CurrentEmploymentType;        //Тип занятости для вакансии
        private String Description;         //Описание вакансии, может быть null
        private uint Salary;                 //Заработная плата, может быть null
        private uint RequiredExperience;     //Требуемый уровень для вакансии в месяцах, может быть null
        /// <summary>
        /// Закрытый по умолчанию конструктор для внешнего доступа
        /// </summary>
        private Vacancy() { }
        /// <summary>
        /// Создает вакансию и добавляет информацию о ней в базу данных
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="employerItn">ИНН работодателя, для которого создается вакансия.
        /// ИНН должен существовать в базе данных</param>
        /// <param name="specialty">Специальность для вакансии</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public Vacancy(String name, String employerItn, Specialty specialty, EmploymentType type,
            String description, uint salary, uint requiredExperience)
        {
            this.Name = name;   
            this.EmployerItn = Employer.GetByItn(employerItn).GetItn();       //Проверка введенного имени работодателя
            this.CurrentSpecialty = specialty;                          //Установка специальности с проверкой в базе
            this.CurrentEmploymentType = type;
            this.Description = description;
            this.Salary = salary;
            this.RequiredExperience = requiredExperience;
            AddEntityToDB();
        }
        /// <summary>
        /// Создает вакансию и добавляет информацию о ней в базу данных
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="employer">Работодатель, для которого создается вакансия.</param>
        /// <param name="specialty">Специальность для вакансии</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public Vacancy(String name, Employer employer, Specialty specialty, EmploymentType type,
            String description, uint salary, uint requiredExperience)
        {
            this.Name = name;
            this.EmployerItn = employer.GetItn();
            this.CurrentSpecialty = specialty;                          //Установка специальности с проверкой в базе
            this.CurrentEmploymentType = type;
            this.Description = description;
            this.Salary = salary;
            this.RequiredExperience = requiredExperience;
            AddEntityToDB();
        }
        /// <summary>
        /// Создает вакансию и добавляет информацию о ней в базу данных
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="employerItn">ИНН работодателя, для которого создается вакансия.
        /// Работодатель должен существовать в базе данных</param>
        /// <param name="specialtyName">Имя специальности для вакансии. Должно существовать в базе данных</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public Vacancy(String name, String employerItn, String specialtyName, EmploymentType type,
            String description, uint salary, uint requiredExperience)
        {
            this.Name = name;
            this.EmployerItn = employerItn;                             //Проверка введенного имени работодателя
            this.CurrentSpecialty = Specialty.GetByName(specialtyName); //Установка специальности с проверкой в базе
            this.CurrentEmploymentType = type;
            this.Description = description;
            this.Salary = salary;
            this.RequiredExperience = requiredExperience;
            AddEntityToDB();
        }
        /// <summary>
        /// Создает вакансию, и добавляет информацию о ней в базу данных
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="employer">Работодатель предоставляющий вакансию</param>
        /// <param name="specialtyName">Имя специальности для вакансии. 
        /// Должно существовать в базе данных</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public Vacancy(String name, Employer employer, String specialtyName, EmploymentType type,
            String description, uint salary, uint requiredExperience)
        {
            this.Name = name;
            this.EmployerItn = employer.GetItn();
            this.CurrentSpecialty = Specialty.GetByName(specialtyName); //Установка специальности с проверкой в базе
            this.CurrentEmploymentType = type;
            this.Description = description;
            this.Salary = salary;
            this.RequiredExperience = requiredExperience;
            AddEntityToDB();
        }
        /// <summary>
        /// Создает вакансию, но не добавляет запись в базу данных. Необходимо вызвать метод SetEmployer()
        /// для записи данных в базу. 
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="specialtyName">Специальность для вакансии.
        /// Должно существовать в базе данных</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public Vacancy(String name, String specialtyName, EmploymentType type,
            String description, uint salary, uint requiredExperience)
        {
            this.Name = name;
            this.CurrentSpecialty = Specialty.GetByName(specialtyName); //Установка специальности с проверкой в базе
            this.CurrentEmploymentType = type;
            this.Description = description;
            this.Salary = salary;
            this.RequiredExperience = requiredExperience;
            this.EmployerItn = null;
        }
        /// <summary>
        /// Создает вакансию, но не добавляет запись в базу данных. Необходимо вызвать метод SetEmployer()
        /// для записи данных в базу. 
        /// </summary>
        /// <param name="name">Имя вакансии - уникально для каждого работодателя</param>
        /// <param name="specialty">Специальность для вакансии</param>
        /// <param name="type">Тип занятости для вакансии</param>
        /// <param name="description">Описание вакансии, может быть null</param>
        /// <param name="salary">Заработная плата</param>
        /// <param name="requiredExperience">Требуемый уровень для вакансии</param>
        public Vacancy(String name, Specialty specialty, EmploymentType type,
            String description, uint salary, uint requiredExperience)
        {
            this.Name = name;
            this.CurrentSpecialty = specialty;
            this.CurrentEmploymentType = type;
            this.Description = description;
            this.Salary = salary;
            this.RequiredExperience = requiredExperience;
            this.EmployerItn = null;
        }
        /// <summary>
        /// Получает набор вакансий связанных с работодателем, по его ИНН
        ///
        /// </summary>
        /// <param name="employerITN">ИНН работодателя</param>
        /// <returns>Список вакансий для работодателя</returns>
        public static List<Vacancy> GetAllEmployerVacancies(String employerITN)
        {
            try
            {
                String query = "SELECT * FROM PERMANENT_USER.VACANCIES "
                    + "WHERE EMPLOYERITN = '" + employerITN + "'";
                //Создание временного объекта для получения функционала базового класса
                Vacancy temp = new Vacancy();
                List<Object[]> list = temp.ExecuteSelect(query);
                List<Vacancy> result = new List<Vacancy>();
                if (list.Count == 0) return result;
                foreach (Object[] currentVacancy in list)
                {
                    Vacancy vac = new Vacancy();
                    vac.Name = currentVacancy.ElementAt(0).ToString();            //Имя вакансии
                    vac.EmployerItn = currentVacancy.ElementAt(1).ToString();     //ИНН работодателя предоставившего вакансию
                    vac.CurrentSpecialty = Specialty.GetByID(Convert.ToInt32(currentVacancy.ElementAt(2)));
                    vac.CurrentEmploymentType = (EmploymentType)Enum.Parse(typeof(EmploymentType), currentVacancy.ElementAt(3).ToString());
                    vac.Description = currentVacancy.ElementAt(4).ToString();
                    vac.Salary = Convert.ToUInt32(currentVacancy.ElementAt(5).ToString());
                    vac.RequiredExperience = Convert.ToUInt32(currentVacancy.ElementAt(6).ToString());
                    //Добавить новый объект вакансии в список
                    result.Add(vac);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно получить список вакансий для работодателя");
                throw e;
            }
        }
        /// <summary>
        /// Получить список всех вакансий существующих в базе данных
        /// </summary>
        /// <returns>Список вакансий</returns>
        public static List<Vacancy> GetAll()
        {
            try
            {
                String query = "SELECT * FROM PERMANENT_USER.VACANCIES";
                //Создание временного объекта для получения функционала базового класса
                Vacancy temp = new Vacancy();
                List<Object[]> list = temp.ExecuteSelect(query);
                List<Vacancy> result = new List<Vacancy>();
                if (list.Count == 0) return result;
                foreach (Object[] currentVacancy in list)
                {
                    Vacancy vac = new Vacancy();
                    vac.Name = currentVacancy.ElementAt(0).ToString();            //Имя вакансии
                    vac.EmployerItn = currentVacancy.ElementAt(1).ToString();     //ИНН работодателя предоставившего вакансию
                    vac.CurrentSpecialty = Specialty.GetByID(Convert.ToInt32(currentVacancy.ElementAt(2)));
                    vac.CurrentEmploymentType = (EmploymentType)Enum.Parse(typeof(EmploymentType), currentVacancy.ElementAt(3).ToString());
                    vac.Description = currentVacancy.ElementAt(4).ToString();
                    vac.Salary = Convert.ToUInt32(currentVacancy.ElementAt(5).ToString());
                    vac.RequiredExperience = Convert.ToUInt32(currentVacancy.ElementAt(6).ToString());
                    //Добавить новый объект вакансии в список
                    result.Add(vac);
                }
                return result;

            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно получить список всех вакансий");
                throw e;
            }
        }
        /// <summary>
        /// Изменяет имя вакансии в базе данных, вносит исправления в базу данных на основе переданного параметра
        /// </summary>
        /// <param name="newName">Новое имя вакансии</param>
        public void ChangeName(String newName)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET NAME = '" + newName + "' "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                //Имя меняется только в случае успешного выполнения запроса
                this.Name = newName;
                Console.WriteLine("Имя вакансии успешно изменено");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить имя вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Сменить тип специальности для данной вакансии и внести изменения в базу данных.
        /// Обычно данный метод вызывать не требуется
        /// </summary>
        /// <param name="specialty">Специальность для данной вакансии</param>
        public void ChangeSpecialty(Specialty specialty)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET IDSPECIALTY = " + specialty.GetId() + " "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                this.CurrentSpecialty = specialty;
                Console.WriteLine("Тип специальности изменен для вакансии");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить тип специальности для вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Сменить тип специальности для данной вакансии. Обычно не требуется
        /// Специальность на которую меняется должна существовать в базе данных
        /// </summary>
        /// <param name="specialtyName">Имя специальности существующее в базе данных</param>
        public void ChangeSpecialty(String specialtyName)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");
                //Получить объект по имени специальности
                Specialty specialty = Specialty.GetByName(specialtyName);
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET IDSPECIALTY = " + specialty.GetId() + " "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                this.CurrentSpecialty = specialty;
                Console.WriteLine("Тип специальности изменен для вакансии");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить тип специальности для вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Изменить тип занятости для вакансии (например, полный рабочий день)
        /// </summary>
        /// <param name="newType">Новый тип занятости</param>
        public void ChangeEmploymentType(EmploymentType newType)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");

                int idEmploymentType = Convert.ToInt32(Enum.Parse(typeof(EmploymentType), newType.ToString()));
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET IDTOF = " + idEmploymentType + " "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                this.CurrentEmploymentType = newType;
                Console.WriteLine("Тип занятости изменен для вакансии");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить тип занятости для вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Сменить описание для текущей вакансии
        /// </summary>
        /// <param name="newDescription">Новое описание</param>
        public void ChangeDescription(String newDescription)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET DESCRIPTION = '" + newDescription + "' "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                this.Description = newDescription;
                Console.WriteLine("Изменено описание для вакансии");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить описание для вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Изменить оплату вакансии
        /// </summary>
        /// <param name="newSalary">Новая оплата вакансии</param>
        public void ChangeSalary(uint newSalary)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET SALARY = " + newSalary + " "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                this.Salary = newSalary;
                Console.WriteLine("Изменена заработная плата для вакансии");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить заработную плату для вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Изменить требуемый опыт работы для специальности в месяцах
        /// </summary>
        /// <param name="newExperience">Новый требуемый опыт работы в месяцах</param>
        public void ChangeRequiredExperience(uint newExperience)
        {
            try
            {
                if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
                    throw new Exception("Не задан работодатель");
                String query = "UPDATE PERMANENT_USER.VACANCIES "
                    + "SET REQUIREDEXPERIENCE = " + newExperience + " "
                    + "WHERE NAME = '" + this.Name + "' "
                    + "AND EMPLOYERITN = '" + this.EmployerItn + "'";
                ExecuteNonSelectQuery(query);
                this.RequiredExperience = newExperience;
                Console.WriteLine("Изменен опыт работы для вакансии");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить опыт работы для вакансии");
                throw e;
            }
        }
        /// <summary>
        /// Удаляет все записи из базы данных связанные с этим объектом
        /// </summary>
        public void Delete()
        {
            DeleteEntityFromDB();
        }
        /// <summary>
        /// Удаляет информацию о сущности Vacancy из базы данных
        /// </summary>
        protected override void DeleteEntityFromDB()
        {
            try
            {
                String query = "DELETE FROM PERMANENT_USER.VACANCIES "
                + "WHERE NAME = '" + this.GetName() + "' "
                + "AND EMPLOYERITN = '" + this.GetEmployerItn() + "'";
                this.ExecuteNonSelectQuery(query);
                Console.WriteLine("Вакансия успешно удалена из базы данных");

            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно удалить вакансию из базы данных");
                throw e;
            }
        }
        /// <summary>
        /// Добавляет новую запись в базу данных на основе имеющейся в классе информации
        /// Вызывает исключение в случае неудачи
        /// </summary>
        protected override void AddEntityToDB()
        {
            try
            {
                String query = "INSERT INTO PERMANENT_USER.VACANCIES "
                    + "(NAME, EMPLOYERITN, IDSPECIALTY, IDTOF, DESCRIPTION, SALARY, REQUIREDEXPERIENCE) "
                    + "VALUES ("
                    + "'" + this.Name + "', "
                    + "'" + this.EmployerItn + "', "
                    + "'" + this.CurrentSpecialty.GetId() + "', "
                    + "'" + ((int)this.CurrentEmploymentType).ToString() + "', "
                    + "'" + this.Description + "', "
                    + "'" + this.Salary + "', "
                    + "'" + this.RequiredExperience + "')";
                ExecuteNonSelectQuery(query);
                Console.WriteLine("Новая вакансия успешно добавлена в базу данных");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно добавить вакансию работодателю");
                this.EmployerItn = null;
                throw e;
            }
        }
        /// <summary>
        /// Получение полного имени вакансии
        /// </summary>
        /// <returns>Имя вакансии</returns>
        public String GetName()
        {
            return this.Name;
        }
        /// <summary>
        /// Получение работодателя для которого эта вакансия существует
        /// Если работодатель не установлен, то возвращается null
        /// </summary>
        /// <returns>ИНН работодателя или null если работодатель еще не установлен</returns>
        public String GetEmployerItn()
        {
            if (this.EmployerItn == "" || this.EmployerItn == null)
                return null;
            else
                return this.EmployerItn;
        }
        /// <summary>
        /// Получить объект Специальность
        /// </summary>
        /// <returns>Возвращает объект типа "Специальность"</returns>
        public Specialty GetSpecialty()
        {
            return this.CurrentSpecialty;
        }
        /// <summary>
        /// Возвращает название специальности
        /// </summary>
        /// <returns>Название специальности</returns>
        public String GetSpecialtyName()
        {
            return this.CurrentSpecialty.GetName();
        }
        /// <summary>
        /// Получить тип занятости для текущей вакансии
        /// </summary>
        /// <returns>Тип занятости</returns>
        public EmploymentType GetEmploymentType()
        {
            return this.CurrentEmploymentType;
        }
        /// <summary>
        /// Получить описание для текущей вакансиии, если установлено
        /// Описание для вакансии может быть не установлено
        /// </summary>
        /// <returns>Описание вакансии или пустую строку</returns>
        public String GetDescription()
        {
            return this.Description;
        }
        /// <summary>
        /// Возвращает заработную плату для этой вакансии
        /// </summary>
        /// <returns>заработная плата</returns>
        public uint GetSalary()
        {
            return this.Salary;
        }
        /// <summary>
        /// Получить требуемый для вакансии стаж работы в месяцах
        /// </summary>
        /// <returns>Необходимый стаж в месяцах</returns>
        public uint GetRequiredExperience()
        {
            return this.RequiredExperience;
        }
        /// <summary>
        /// Установить для текущей вакансии работодателя.
        /// Только в этом месте вакансия добавляется в базу данных
        /// Вызывает исключение в случае ошибки добавления вакансии работодателю, также не добавляется в базу данных
        /// </summary>
        /// <param name="employer">Работодатель, предоставивший вакансию</param>
        public void SetEmployer(Employer employer)
        {
            if(this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0 )
            {
                this.EmployerItn = employer.GetItn();
            }
            else
                throw new Exception("Вакансия уже имеет работодателя");
            AddEntityToDB();
        }
        /// <summary>
        /// Установить для текущей вакансии работодателя.
        /// Только в этом месте вакансия добавляется в базу данных
        /// Вызывает исключение в случае ошибки добавления вакансии работодателю
        /// или если ИНН работодателя не найден
        /// </summary>
        /// <param name="itn">ИНН работодателя предоставившего вакансию</param>
        public void SetEmployer(String itn)
        {
            if (this.EmployerItn == null || this.EmployerItn.CompareTo("") == 0)
            {
                Employer employer = Employer.GetByItn(itn);
                this.EmployerItn = employer.GetItn();
            }
            else
                throw new Exception("Вакансия уже имеет работодателя");
            AddEntityToDB();

        }
        /// <summary>
        /// Обновить сущность на основе данных в классе
        /// </summary>
        protected override void UpdateEntityInDB()
        {
            //TODO: Vacancy.UpdateEntityInDB(). Написать реализацию метода
            throw new Exception("Дайте знать если появилось это исключение Vacancy.UpdateEntityInDB()");
        }
    }
}
