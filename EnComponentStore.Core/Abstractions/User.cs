

namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Описание пользователя
    /// </summary>
    interface IUser
    {
        string userID { get; set; }
        
        string userName { get; set;}

        string userLogin { get; set;}

        string userPassword { get; set;}

        string userEmail { get; set; }

        /// <summary>
        ///  Должность пользователя
        /// </summary>
        string userPosition { get; set; }

    }
}
