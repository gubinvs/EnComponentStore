
namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Описание количества товара на складах сервиса
    /// </summary>
    /// 


    interface IQuantityWarehouse
    {
        // Идентификатор номенклатуры
        Guid guidNomenclature {get; set;}

        // Количество товара на основном складе сервиса
        int quantityMainWarehouse { get; set;} 
    }
}