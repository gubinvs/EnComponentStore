namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Количество товара на складах сервиса
    /// </summary>
    /// 


    public class QuantityWarehouse
    {
        public QuantityWarehouse(string vendorCode, string idWarehouse, int quantity)
        {
            this.VendorCode = vendorCode;
            this.IdWarehouse = idWarehouse;
            this.Quantity = quantity;

        }

        /// <summary>
        /// Артикул номенклатуры
        /// </summary>
        string VendorCode{ get; set; }

        /// <summary>
        /// Идентификатор склада
        /// </summary>
        string IdWarehouse { get; set; }

        /// <summary>
        /// Количество товара на складе
        /// </summary>

        int Quantity { get; set; }
    }
}