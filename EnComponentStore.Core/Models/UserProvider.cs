using EnComponentStore.Core.Abstractions;

namespace EnComponentStore.Core.Models
{
    public class UserProvider : User
    {
        /// Метод проверяет заполнение формы и создает экземпляр класса, в случае не заполненного поля возвращает строку с информацией о незаполненном поле, в случае
        /// корректного заполнения полей вернет пустую строку и заполненный экземпляр класса 

        public (string str, UserProvider user) AddUser(string name, string login, string password, string email, string position)
        {
            if (name == string.Empty || name > MAXIMUM_TEXT_LENGTH) 
            {
                str = "Имя пользователя не указано или длина символов более 255 символов";
            }
                else if (login == string.Empty || name > MAXIMUM_TEXT_LENGTH) {
            {
                str = "Логин пользователя не указан или его длина более 255 символов";
            }
                else if (password == string.Empty || password > MAXIMUM_TEXT_LENGTH)
            {
                str = "Пароль пользователя не указан или его длина более 255 символов";
            }   
                else if (email == string.Empty || email > MAXIMUM_TEXT_LENGTH)
            {
                str = "E-mail пользователя не указан или его длина более 255 символов";
            }
                else if (email == string.Empty || email > MAXIMUM_TEXT_LENGTH)
            {
                str = "E-mail пользователя не указан или его длина более 255 символов";
            };
            
            UserProvider user = new UserProvider(name, login, password, email, position);
        return (str, user)
        
        }
    }
}
