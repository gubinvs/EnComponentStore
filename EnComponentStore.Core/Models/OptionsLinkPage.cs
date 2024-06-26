namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Ссылки на картинки и страницу номенклатуры товара
    /// используется для собственного API
    /// </summary>
    /// 

    public class OptionsLinkPage
    {
        public OptionsLinkPage(string linkPage, string linkImgPage, string linkImgCard, string linkImgBasket)
        {
            this.LinkPage = linkPage;
            this.LinkImgPage = linkImgPage; 
            this.LinkImgCard = linkImgCard; 
            this.LinkImgBasket = linkImgBasket;
        }

        /// <summary>
        /// Ссылка на страницу с описанием товара (номенклатуры)
        /// </summary>
        string LinkPage { get; set; }

        /// <summary>
        /// Ссылка на картинку с изображением для страницы с описанием товара (номенклатуры)
        /// </summary>
        string LinkImgPage { get; set; }

        /// <summary>
        /// Ссылка на картинку для карточки товара (номенклатуры)
        /// </summary>
        string LinkImgCard { get; set; }

        /// <summary>
        /// Ссылка на картинку для иконки в строке заказа на странице корзина
        /// </summary>
        string LinkImgBasket { get; set; }

    }
}




