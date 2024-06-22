
namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    ///  Интерфейс про сроки достаки и транспортную компанию
    /// </summary>
    /// 


    interface IDelivery
    {
        // Срок доставки в днях
        int dayDelivery { get; set;}

        // Наименование службы доставки
        string nameDelivery {get; set;}

    
        // Стоимость доставки
        int priceDelivery {get; set;}

    }
}