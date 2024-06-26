using EnComponentStore.Core.Abstractions;

namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Абстрактный класс описавыющий компанию
    /// </summary>
    /// 

    class Company : CheckItem
    {
        private Company(
            string name,
            string role,
            string minName,
            string inn,
            string ogrn,
            string legalAddress,
            string mailingAddress,
            string emailAddress,
            string phone,
            string boss,
            string nameBoss,
            string bikBank,
            string accountBank
            )
        {
            Id = Guid.NewGuid();
            this.Name = name;
            this.Role = role;
            this.MinName = minName;
            this.Inn = inn;
            this.Ogrn = ogrn;
            this.LegalAddress = legalAddress;
            this.MailingAddress = mailingAddress;
            this.EmailAddress = emailAddress;
            this.Phone = phone;
            this.Boss = boss;
            this.NameBoss = nameBoss;
            this.BikBank = bikBank;
            this.AccountBank = accountBank;
        }

        public Guid Id { get; set; }
        /// <summary>
        /// Полное наименование компании
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Роль компании в системе покупатель или поставщик
        /// </summary>
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// Сокращенное наименование компании
        /// </summary>
        public string MinName { get; set; } = string.Empty;

        /// <summary>
        /// ИНН Компании
        /// </summary>
        public string Inn { get; set; } = string.Empty;

        /// <summary>
        /// ОГРН Компании
        /// </summary>
        public string Ogrn { get; set; } = string.Empty;

        /// <summary>
        /// Юридический адрес компании
        /// </summary>
        public string LegalAddress { get; set; } = string.Empty;

        /// <summary>
        /// Почтовый адрес компании
        /// </summary>
        public string MailingAddress { get; set; } = string.Empty;

        /// <summary>
        /// Email Адрес компании
        /// </summary>
        public string EmailAddress { get; set; } = string.Empty;

        /// <summary>
        /// Телефон для связи компании
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Должность руководителя, директор или генеральный директор
        /// </summary>
        public string Boss { get; set; } = string.Empty;

        /// <summary>
        /// ФИО руководителя
        /// </summary>
        public string NameBoss { get; set; } = string.Empty;

        /// <summary>
        /// БИК Банка компании
        /// </summary>
        public string BikBank { get; set; } = string.Empty;

        /// <summary>
        /// Расчетный счет в банке компании
        /// </summary>
        public string AccountBank { get; set; } = string.Empty;

        /// <summary>
        /// Метод проверяет заполнение формы и создает экземпляр класса, в случае не заполненного поля возвращает строку с информацией о незаполненном поле, в случае
        /// корректного заполнения полей вернет пустую строку и заполненный экземпляр класса  <summary>
        /// Метод проверяет заполнение формы и создает экземпляр класса, в случае не заполненного поля возвращает строку с информацией о незаполненном поле, в случае
        /// </summary>

        /// 
        public (string str, Company company) Create(
                                                string name,
                                                string role,
                                                string minName,
                                                string inn,
                                                string ogrn,
                                                string legalAddress,
                                                string mailingAddress,
                                                string emailAddress,
                                                string phone,
                                                string boss,
                                                string nameBoss,
                                                string bikBank,
                                                string accountBank)
        {
            /// IsNullOrEmpty - если принимаемая строка пустая или количество символов больше константы
            if (string.IsNullOrEmpty(name) || name.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Поле, наименование компании, не указано или длина символов более 255 символов";
            }
            else if (string.IsNullOrEmpty(minName) || minName.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Сокращенное наменование компании не указано или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(inn) || inn.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "ИНН компании не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(ogrn) || ogrn.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "ОГРН компании не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(legalAddress) || legalAddress.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Юридический адрес компании не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(mailingAddress) || mailingAddress.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Почтовый адрес компании не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(emailAddress) || emailAddress.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "E-mail компании не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(phone) || phone.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Телефон компании не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(boss) || boss.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Должность руководителя компании не указана или её длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(nameBoss) || nameBoss.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "ФИО руководителя компании не указаны или их длина более 255 символов";
            }
            else if (bikBank.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "БИК Банка получателя содержит более 255 символов";
            }
            else if (accountBank.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Расчетный счет компании содержит более 255 символов";
            };

            Company company = new Company(
                                    name,
                                    role,
                                    minName,
                                    inn,
                                    ogrn,
                                    legalAddress,
                                    mailingAddress,
                                    emailAddress,
                                    phone,
                                    boss,
                                    nameBoss,
                                    bikBank,
                                    accountBank);

            return (str, company);
        }
    }
}