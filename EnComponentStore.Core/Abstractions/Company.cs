
namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Абстрактный класс описавыющий компанию
    /// </summary>
    /// 

    abstract class Company
    {    
        public string id { get; }
        /// <summary>
        /// Полное наименование компании
        /// </summary>
        public string name { get; }

        /// <summary>
        /// Роль компании в системе покупатель или поставщик
        /// </summary>
        public string role { get; }

        /// <summary>
        /// Сокращенное наименование компании
        /// </summary>
        public string minName { get; }

        /// <summary>
        /// ИНН Компании
        /// </summary>
        public string inn { get; } 
    
        /// <summary>
        /// ОГРН Компании
        /// </summary>
        public string ogrn { get; }
    
        /// <summary>
        /// Юридический адрес компании
        /// </summary>
        public string legalAddress { get; }

        /// <summary>
        /// Почтовый адрес компании
        /// </summary>
        public string mailingAddress { get; }

        /// <summary>
        /// Email Адрес компании
        /// </summary>
        public string emailAddress { get;}

        /// <summary>
        /// Телефон для связи компании
        /// </summary>
        public string phone { get; }

        /// <summary>
        /// Должность руководителя, директор или генеральный директор
        /// </summary>
        public string boss { get; }
    
        /// <summary>
        /// ФИО руководителя
        /// </summary>
        public string nameBoss  { get; }

        /// <summary>
        /// БИК Банка компании
        /// </summary>
        public string bikBank { get; }

        /// <summary>
        /// Расчетный счет в банке компании
        /// </summary>
        public string  accountBank { get; }
    }  
}