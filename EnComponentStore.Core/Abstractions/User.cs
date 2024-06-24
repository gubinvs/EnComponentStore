
namespace EnComponentStore.Core.Abstractions;
{
    /// <summary>
    /// Параметры пользоваталя в системе
    /// </summary>
    /// 

    internal abstract class User
    {
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


        public (User user, string str) AddUser (string name, string login, string password, string email, string position)
        {
            // Прописать проверки на соответствие ,если проверка на соответствие не пройдена, заполнить строку данными.
            if (name != "d") { str = "kkasjkasjd"; }

            User user = new User(name, login, password, email, position);

            // Возвращает созданного пользователя и состояние строки. если была ошибка строка будет заполнена.
            return (user, str);
        }

        /// <summary>
        /// Идентификатор GUID пользователя
        /// </summary>
        string id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        string name { get; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        string login { get; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string password { get; }

        /// <summary>
        /// Email Пользователя
        /// </summary>
        string email { get; }

        /// <summary>
        ///  Должность пользователя
        /// </summary>
        string position { get; }

    };
};
