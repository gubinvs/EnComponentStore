
namespace EnComponentStore.Core.Models
{
    public class User
    {
        /// <summary>
        /// Класс пользоваталя системы
        /// </summary>
        /// 

        public string str  = string.Empty;

        /// <summary>
        /// Константа с параметром длины символов в поле
        /// </summary>
        public const int MAXIMUM_TEXT_LENGTH = 255;

        private User(string name, string login, string password, string email, string position)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Login = login;
            this.Password = password;
            this.Email = email;
            this.Position = position;
        }

        /// <summary>
        /// Идентификатор GUID пользователя
        /// </summary>
        Guid Id { get; set;}

        /// <summary>
        /// Имя пользователя
        /// </summary>
        string Name { get; set;} = string.Empty;

        /// <summary>
        /// Логин пользователя
        /// </summary>
        string Login { get; set;} = string.Empty;

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string Password { get; set;} = string.Empty;

        /// <summary>
        /// Email Пользователя
        /// </summary>
        string Email { get; set;} = string.Empty;

        /// <summary>
        ///  Должность пользователя
        /// </summary>
        string Position { get; set;} = string.Empty;

        /// Метод проверяет заполнение формы и создает экземпляр класса, в случае не заполненного поля возвращает строку с информацией о незаполненном поле, в случае
        /// корректного заполнения полей вернет пустую строку и заполненный экземпляр класса  <summary>
        /// Метод проверяет заполнение формы и создает экземпляр класса, в случае не заполненного поля возвращает строку с информацией о незаполненном поле, в случае
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="login">Логин пользователя в системе</param>
        /// <param name="password">Пароль пользователя</param>
        /// <param name="email">E-mail пользователя</param>
        /// <param name="position">Должность пользователя</param>
        /// 
        public  (string str, User user) Create(string name, string login, string password, string email, string position)
        {
            /// IsNullOrEmpty - если принимаемая строка пустая или количество символов больше константы
            if (string.IsNullOrEmpty(name) || name.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Имя пользователя не указано или длина символов более 255 символов";
            }
            else if (string.IsNullOrEmpty(login) || login.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Логин пользователя не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(password) || password.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Пароль пользователя не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(email) || email.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "E-mail пользователя не указан или его длина более 255 символов";
            }
            else if (position.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Должность пользователя содержит более 255 символов";
            };

            User user = new User(name, login, password, email, position);

            return (str, user);
        }

    };
};
