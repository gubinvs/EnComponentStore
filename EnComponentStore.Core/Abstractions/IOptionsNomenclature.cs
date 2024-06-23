namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Ссылки на картинки и страницу номенклатуры
    /// используется для собственного API
    /// </summary>
    /// 


    interface IOptionsNomenclature 
    {
        
        /// <summary>
        /// Ссылка на страницу с описанием товара (номенклатуры)
        /// </summary>
        string linkPage { get; set;}

        /// <summary>
        /// Ссылка на картинку с изображением для страницы с описанием товара (номенклатуры)
        /// </summary>
        string linkImgPage {get; set;}

        /// <summary>
        /// Ссылка на картинку для карточки товара (номенклатуры)
        /// </summary>
        string linkImgCard {get; set;}

        /// <summary>
        /// Ссылка на картинку для иконки в строке заказа на странице корзина
        /// </summary>
        string linkImgBasket {get; set;}

    } 
}




