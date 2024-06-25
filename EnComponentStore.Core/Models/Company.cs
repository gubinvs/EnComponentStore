
namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Абстрактный класс описавыющий компанию
    /// </summary>
    /// 

    class Company
    {    
        public Guid Id { get; set; }
        /// <summary>
        /// Полное наименование компании
        /// </summary>
        public string Name { get; set;}= string.Empty;

        /// <summary>
        /// Роль компании в системе покупатель или поставщик
        /// </summary>
        public string Role { get; set;}= string.Empty;

        /// <summary>
        /// Сокращенное наименование компании
        /// </summary>
        public string MinName { get; set;}= string.Empty;

        /// <summary>
        /// ИНН Компании
        /// </summary>
        public string Inn { get; set;}= string.Empty; 
    
        /// <summary>
        /// ОГРН Компании
        /// </summary>
        public string Ogrn { get; set;}= string.Empty;
    
        /// <summary>
        /// Юридический адрес компании
        /// </summary>
        public string LegalAddress { get; set;}= string.Empty;

        /// <summary>
        /// Почтовый адрес компании
        /// </summary>
        public string MailingAddress { get; set;}= string.Empty;

        /// <summary>
        /// Email Адрес компании
        /// </summary>
        public string EmailAddress { get; set;}= string.Empty;

        /// <summary>
        /// Телефон для связи компании
        /// </summary>
        public string Phone { get; set; }= string.Empty;

        /// <summary>
        /// Должность руководителя, директор или генеральный директор
        /// </summary>
        public string Boss { get; set; }= string.Empty;
    
        /// <summary>
        /// ФИО руководителя
        /// </summary>
        public string NameBoss  { get; set;}= string.Empty;

        /// <summary>
        /// БИК Банка компании
        /// </summary>
        public string BikBank { get; set;}= string.Empty;

        /// <summary>
        /// Расчетный счет в банке компании
        /// </summary>
        public string  AccountBank { get; set;} = string.Empty;
    }  
}