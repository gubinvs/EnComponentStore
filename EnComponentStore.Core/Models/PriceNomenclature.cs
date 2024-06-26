namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Стоимость номенклатуры
    /// </summary>
    /// 

    public class PriceNomenclature
    {

        public PriceNomenclature(Guid idProvider, string vendorCode, int currentPriceProvider)
        {
            this.IdProvider = idProvider;
            this.VendorCode = vendorCode;
            this.CurrentPriceProvider = currentPriceProvider;
        }

        /// <summary>
        /// Идентификатор компании поставщика (продавца)
        /// </summary>
        Guid IdProvider { get; set; }

        /// <summary>
        /// Артикул завода изготовителя номенклатуры
        /// </summary>
        string VendorCode { get; set; }

  
        /// <summary>
        /// Текущая цена по которой продает поставщик
        /// </summary>
        int CurrentPriceProvider { get; set; }

    }
}
