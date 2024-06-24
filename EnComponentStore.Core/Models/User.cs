
namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Параметры пользоваталя в системе
    /// </summary>
    /// 

    class User
    {
        public string str = string.Empty;


        private User (string userName, string userLogin, string userPassword, string userEmail, string userPosition)
        {
            this.userID = Guid.NewGuid();
            this.userName = userName;
            this.userLogin = userLogin;
            this.userPassword = userPassword;
            this.userEmail = userEmail;
            this.userPosition = userPosition;
        }

        public (User user, string str) AddUser(string userName, string userLogin, string userPassword, string userEmail, string userPosition)
        {
            // Прописать проверки на соответствие ,если проверка на соответствие не пройдена, заполнить строку данными.
            if (userName != "d") { str = "kkasjkasjd"; }

            User user = new User(userName, userLogin, userPassword, userEmail, userPosition);
            
            // Возвращает созданного пользователя и состояние строки. если была ошибка строка будет заполнена.
            return (user, str);
        }
       

        /// <summary>
        /// Идентификатор GUID пользователя
        /// </summary>
        Guid userID { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        string userName { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        string userLogin { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string userPassword { get; set; }

        /// <summary>
        /// Email Пользователя
        /// </summary>
        string userEmail { get; set; }

        /// <summary>
        ///  Должность пользователя
        /// </summary>
        string userPosition { get; set; }

    }
}
