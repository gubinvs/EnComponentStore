
namespace EnComponentStore.Core.Abstractions
{
    abstract class User
    {
        /// <summary>
        /// Параметры пользоваталя в системе
        /// </summary>
        /// 
        public string str = string.Empty;

        private User(string name, string login, string password, string email, string position)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.login = login;
            this.password = password;
            this.email = email;
            this.position = position;
        }

        /// <summary>
        /// Идентификатор GUID пользователя
        /// </summary>
        string id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        string name { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        string login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string password { get; set; }

        /// <summary>
        /// Email Пользователя
        /// </summary>
        string email { get; set; }

        /// <summary>
        ///  Должность пользователя
        /// </summary>
        string position { get; set; }

    };
};
