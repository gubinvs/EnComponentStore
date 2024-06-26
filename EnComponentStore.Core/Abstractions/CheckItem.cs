using EnComponentStore.Core.Models;

namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Абстрактный класс с элементами используемыми при проверке на ошибки заполнения форм и создания новых экземпляров класса
    /// </summary>
    internal class CheckItem
    {
        /// <summary>
        /// Класс пользоваталя системы
        /// </summary>
        /// 
        public string str = string.Empty;

        /// <summary>
        /// Константа с параметром длины символов в поле
        /// </summary>
        public const int MAXIMUM_TEXT_LENGTH = 255;
    }
}