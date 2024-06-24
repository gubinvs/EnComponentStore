namespace EnComponentStore.Core.Abstractions 
{
    interface IUser
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


        public (User user, string str) AddUser(string userName, string userLogin, string userPassword, string userEmail, string userPosition)
        {
            // Прописать проверки на соответствие ,если проверка на соответствие не пройдена, заполнить строку данными.
            if (userName != "d") { str = "kkasjkasjd"; }

            User user = new User(name, login, password, email, position);

            // Возвращает созданного пользователя и состояние строки. если была ошибка строка будет заполнена.
            return (user, str);
        }
    }
}