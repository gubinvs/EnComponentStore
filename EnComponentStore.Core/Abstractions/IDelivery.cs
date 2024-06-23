
namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    ///  Интерфейс про сроки достаки и транспортную компанию
    /// </summary>
    /// 


    interface IDelivery
    {
        /// <summary>
        /// Срок доставки в днях
        /// </summary>
        int dayDelivery { get; set;}

        /// <summary>
        /// Наименование службы доставки
        /// </summary>
        string nameDelivery {get; set;}

        /// <summary>
        /// Стоимость доставки
        /// </summary>
        int priceDelivery {get; set;}

    }
}