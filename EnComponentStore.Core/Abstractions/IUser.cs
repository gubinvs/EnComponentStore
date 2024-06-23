

namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Описание пользователя
    /// </summary>
    /// 

    interface IUser
    {
        /// <summary>
        /// Идентификатор GUID пользователя
        /// </summary>
        Guid userID { get; set; }
        
        /// <summary>
        /// Имя пользователя
        /// </summary>
        string userName { get; set;}

        /// <summary>
        /// Логин пользователя
        /// </summary>
        string userLogin { get; set;}

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string userPassword { get; set;}

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
