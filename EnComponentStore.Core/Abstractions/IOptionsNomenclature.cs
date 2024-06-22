namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Ссылки на картинки и страницу номенклатуры
    /// используется для собственного API
    /// </summary>
    /// 



    interface IOptionsNomenclature 
    {
        
        // Ссылка на страницу с описанием товара (номенклатуры)
        string linkPage { get; set;}

        // Ссылка на картинку с изображением для страницы с описанием товара (номенклатуры)
        string linkImgPage {get; set;}

        // Ссылка на картинку для карточки товара (номенклатуры)
        string linkImgCard {get; set;}

        // Ссылка на картинку для иконки в строке заказа на странице корзина
        string linkImgBasket {get; set;}

    } 
}




