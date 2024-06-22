namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Стоимость номенклатуры
    /// </summary>
    /// 


    interface IPriceNomenclature 
    {
        // Идентификатор товара
        Guid guidNomenclature {get; set;}

        // Идентификатор поставщика
        Guid guidProvider {get; set;}

        // Минимальная цена по которой продовал данный товар поставщик
        int minPriceProvider {get; set;}

        // Максималтная цена компании поставщика
        int maxPriceProvider {get; set;}

        // Current Price offered by the service
        int currentPriceProvider {get; set;}

        // Установленная цена продажи товара в сервисе
        int offeredPrice {get; set;}
    }
}
