
namespace EnComponentStore.Core.Abstractions;
{
    /// <summary>
    /// Параметры пользоваталя в системе
    /// </summary>
    /// 

    abstract class User
    {

        /// <summary>
        /// Идентификатор GUID пользователя
        /// </summary>
        string id { get; }

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

    }
}
