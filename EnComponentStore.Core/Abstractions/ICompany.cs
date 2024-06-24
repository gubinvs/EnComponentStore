
namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Интерфейс с описанием компаний
    /// </summary>
    /// 

    interface ICompany
    {    
        /// <summary>
        /// Полное наименование компании
        /// </summary>
        string name { get;}

        /// <summary>
        /// Роль компании в системе покупатель или поставщик
        /// </summary>
        string role { get;}

        /// <summary>
        /// Сокращенное наименование компании
        /// </summary>
        string minName { get; set; }

        /// <summary>
        /// ИНН Компании
        /// </summary>
        string inn { get; set; } 
    
        /// <summary>
        /// ОГРН Компании
        /// </summary>
        string ogrn { get; set; }
    
        /// <summary>
        /// Юридический адрес компании
        /// </summary>
        string legalAddress { get; set; }

        /// <summary>
        /// Почтовый адрес компании
        /// </summary>
        string mailingAddress { get; set; }

        /// <summary>
        /// Email Адрес компании
        /// </summary>
        string emailAddress { get; set; }

        /// <summary>
        /// Телефон для связи компании
        /// </summary>
        string phone { get; set; }

        /// <summary>
        /// Должность руководителя, директор или генеральный директор
        /// </summary>
        string boss { get; set;}
    
        /// <summary>
        /// ФИО руководителя
        /// </summary>
        string nameBoss  { get; set; }

        /// <summary>
        /// БИК Банка компании
        /// </summary>
        string bikBank { get; set; }

        /// <summary>
    /// Расчетный счет в банке компании
    /// </summary>
    string  accountBank { get; set; }
    }  
}