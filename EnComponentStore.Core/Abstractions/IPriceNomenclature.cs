namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Стоимость номенклатуры
    /// </summary>
    /// 


    interface IPriceNomenclature 
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        Guid guidNomenclature {get; set;}

        /// <summary>
        /// Идентификатор поставщика
        /// </summary>
        Guid guidProvider {get; set;}

        /// <summary>
        /// Минимальная цена по которой продовал данный товар поставщик
        /// </summary>
        int minPriceProvider {get; set;}

        /// <summary>
        /// Максимальная цена компании поставщика
        /// </summary>
        int maxPriceProvider {get; set;}

        /// <summary>
        /// Текущая цена по которой продает поставщик
        /// </summary>
        int currentPriceProvider {get; set;}

        /// <summary>
        /// Установленная цена продажи товара от сервиса
        /// </summary>
        int offeredPrice {get; set;}
    }
}
