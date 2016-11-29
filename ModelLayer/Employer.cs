using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    /// <summary>
    /// Класс Employer отражает часть схемы базы данных, хранящую информацию
    /// о работодателях и их вакансиях
    /// Обратите внимание, что по Российскому законодательству смена ИНН не производится
    /// Также смена ИНН невозможно из программы
    /// Добавление вакансии работодателю может производится как при помощи текущего класса (метод AddVacancy())
    /// так и при помощи класса Vacancy, передав ему в качестве параметра работодателя
    /// </summary>
    public class Employer : DBEntity
    {
        private String Itn;     //ИНН организации или работодателя
        private String Name;    //Название организации или имя частного предпринимателя
        private String Address; //Юридический адрес работодателя
        private String Phone;   //Контактный номер телефона работодателя
        /// <summary>
        /// Закрытый для создания по умолчанию конструктор
        /// </summary>
        private Employer() {}
        /// <summary>
        /// Занесение сведений о работодателе в базу данных и создание на основе этих данных объекта
        /// </summary>
        /// <param name="itn">ИНН организации или работодателя</param>
        /// <param name="name">Название организации или имя частного предпринимателя</param>
        /// <param name="address">Юридический адрес работодателя</param>
        /// <param name="phone">Контактный номер телефона работодателя</param>
        public Employer(String itn, String name, String address, String phone)
        {
            this.Itn = itn;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            AddEntityToDB();
        }
        /// <summary>
        /// Удаляет все записи связанные с текущим работодателем из базы данных
        /// ВНИМАНИЕ!!! Также удаляются все вакансии связанные с работодателем
        /// </summary>
        public void DeleteEmployer()
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
                //Удалить самого работодателя а с ним каскадно удалятся вакансии
                String query = "DELETE FROM PERMANENT_USER.EMPLOYER "
                    + "WHERE ITN = '" + this.Itn + "'";
                ExecuteNonSelectQuery(query);
                //Удаление объекта после успешного запроса
                Console.WriteLine("Работодатель успешно удален из базы данных");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка удаления работодателя из базы");
                throw e;
            }
        }
        /// <summary>
        /// Вставить новую запись о работодателе в базу данных. Исключение в случае ошибки
        /// </summary>
        protected override void AddEntityToDB()
        {
            try
            {
                //q используется для экранирования символов
                String query = "INSERT INTO PERMANENT_USER.EMPLOYER "
                    + "(ITN, NAME, ADDRESS, PHONE) VALUES ("
                    + "" + this.Itn + ", "
                    + "'" + this.Name + "', "
                    + "'" + this.Address + "', "
                    + "'" + this.Phone + "')";
                ExecuteNonSelectQuery(query);
                Console.WriteLine("Новый работодатель успешно добавлен в базу данных");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно добавить информацию о работодателе в базу данных");
                throw e;
            }
        }
        /// <summary>
        /// Проверяет можно ли получить из базы данных сведения о работодателе с переданным ИНН
        /// Может вызвать исключение
        /// </summary>
        /// <param name="itn">ИНН для поиска информации о работодателе</param>
        /// <returns>true если информация о работодателе в базе данных существует</returns>
        public static bool CanGetByItn(String itn)
        {
            try
            {
                String query = "SELECT * FROM PERMANENT_USER.EMPLOYER "
                    + "WHERE ITN = '" + itn + "'";
                //Временный объект для доступа к функциям базового класса
                Employer temp = new Employer();
                if (temp.ExecuteSelect(query).Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка поиска работодателя по ИНН");
                throw e;
            }
        }

        /// <summary>
        /// Добавляет новую вакансию к текущему работодателю, производит необходимые связки в базе данных
        /// В случае ошибки вызывается исключение
        /// </summary>
        /// <param name="vacancy">Вакансия работодателя для добавления</param>
        //TODO: Employer.AddVacancy() отладить
        public void AddVacancy(Vacancy vacancy)
        {
            vacancy.SetEmployer(this);
        }
        /// <summary>
        /// Именяет текущее наименование организации или имя частного предпринимателя.
        /// В случае ошибки вызывает исключение
        /// </summary>
        /// <param name="newName">Новое имя организации или частного предпринимателя</param>
        public void ChangeName(String newName)
        {
            try
            {
                String query = "UPDATE PERMANENT_USER.EMPLOYER "
                    + "SET NAME = '" + newName + "' "
                    + "WHERE ITN = '" + this.Itn + "'";
                ExecuteNonSelectQuery(query);
                //Имя меняется только в случае успешного выполнения запроса
                this.Name = newName;
                Console.WriteLine("Имя работодателя успешно изменено");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить имя работодателя");
                throw e;
            }
        }
        /// <summary>
        /// Изменяет текущий адрес работодателя на новый.
        /// В случае ошибки вызывает исключение
        /// </summary>
        /// <param name="newAddress">Новый адрес работодателя</param>
        public void ChangeAddress(String newAddress)
        {
            try
            {
                String query = "UPDATE PERMANENT_USER.EMPLOYER "
                    + "SET ADDRESS = '" + newAddress + "'"
                    + "WHERE ITN = '" + this.Itn + "'";
                ExecuteNonSelectQuery(query);
                //Адрес меняется только в случае успешного выполнения запроса
                this.Address = newAddress;
                Console.WriteLine("Адрес работодателя успешно изменен");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно сменить адрес работодателя");
                throw e;
            }
        }
        /// <summary>
        /// Изменяет текущий контактный телефон работодателя
        /// </summary>
        /// <param name="newPhone">Новый телефонный номер</param>
        public void ChangePhone(String newPhone)
        {
            try
            {
                String query = "UPDATE PERMANENT_USER.EMPLOYER "
                    + "SET PHONE = '" + newPhone + "'"
                    + "WHERE ITN = '" + this.Itn + "'";
                ExecuteNonSelectQuery(query);
                //Телефон меняется только в случае успешного выполнения запроса
                this.Phone = newPhone;
                Console.WriteLine("Номер телефона успешно изменен");
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно изменить номер телефона");
                throw e;
            }

        }
        /// <summary>
        /// Проверяет в базе данных запись о работодателе с переданным в качестве параметра ИНН
        /// и в случае существования последней возвращает объект, созданный на основе данных из базы
        /// </summary>
        /// <param name="itn">ИНН работодателя для поиска</param>
        /// <returns>Возвращает объект работодателя на основе данных из базы</returns>
        public static Employer GetByItn(String itn)
        {
            try
            {
                Employer result = new Employer();
                String query = "SELECT * FROM PERMANENT_USER.EMPLOYER "
                    + "WHERE ITN = '" + itn + "'";
                List<Object[]> list = result.ExecuteSelect(query);
                if (list.Count == 0)
                    throw new Exception("Не найдена запись в базе данных");
                else
                {
                    result.Itn = list.ElementAt(0).ElementAt(0).ToString();     //ИНН
                    result.Name = list.ElementAt(0).ElementAt(1).ToString();    //Имя
                    result.Address = list.ElementAt(0).ElementAt(2).ToString(); //Адрес
                    result.Phone = list.ElementAt(0).ElementAt(3).ToString();   //Телефон
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Невозможно получить работодателя по ИНН из базы данных");
                throw e;
            }
        }

        /// <summary>
        /// Функция для получения ИНН работодателя (текущего объекта)
        /// </summary>
        /// <returns>Возвращает ИНН работодателя</returns>
        public String GetItn()
        {
            return this.Itn;
        }
        /// <summary>
        /// Получение названия компании, либо имени частного предпринимателя
        /// </summary>
        /// <returns>Возвращает имя компании либо частного предпринимателя</returns>
        public String GetName()
        {
            return this.Name;
        }
        /// <summary>
        /// Получение адреса работодателя
        /// Вообще адрес вроде должен быть один у каждого работодателя, т.к. каждый филиал
        /// регистрируется в налоговой службе отдельно. В программе считается, что у каждого
        /// работодателя один адрес. В реальности же это может быть не так
        /// </summary>
        /// <returns>Возвращает адрес работодателя</returns>
        public String GetAddress()
        {
            return this.Address;
        }
        /// <summary>
        /// Функция получения контактного номера с работодателем
        /// </summary>
        /// <returns>Номер телефона работодателя</returns>
        public String GetPhone()
        {
            return this.Phone;
        }
        /// <summary>
        /// Одновляет базу данных на основе сведений из класса
        /// </summary>
        protected override void UpdateEntityInDB()
        {
            //TODO: Employer.DeleteEntityFromDB(). Написать реализацию метода
            throw new Exception("Дайте знать если появилось это исключение Employer.UpdateEntityInDB()");
        }
    }
}
