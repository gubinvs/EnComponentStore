using EnComponentStore.Core.Abstractions;

namespace EnComponentStore.Core.Models
{
    /// <summary>
    ///  Интерфейс про сроки достаки и транспортную компанию
    /// </summary>
    /// 

    class Delivery : CheckItem
    {
        private Delivery(string vendorCode,  int dayDelivery, string nameDelivery, decimal priceDeliver) 
        {
            this.VendorCode = vendorCode;
            this.DayDelivery = dayDelivery;
            this.NameDelivery = nameDelivery;
            this.PriceDelivery = priceDeliver;   
        }

        /// <summary>
        /// Артикул производителя на товар
        /// </summary>
        string VendorCode { get; set; }

        /// <summary>
        /// Срок доставки в днях
        /// </summary>
        int DayDelivery { get; set; }

        /// <summary>
        /// Наименование службы доставки
        /// </summary>
        string NameDelivery { get; set; }

        /// <summary>
        /// Стоимость доставки
        /// </summary>
        decimal PriceDelivery { get; set; }

        public (string str, Delivery delivery) Create(string vendorCode, int dayDelivery, string nameDelivery, decimal priceDeliver)
        {
            /// IsNullOrEmpty - если принимаемая строка пустая или количество символов больше константы

            if (string.IsNullOrEmpty(vendorCode) || vendorCode.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Артикул номенклатуры не указан или его длина более 255 символов";
            }
            else if (string.IsNullOrEmpty(nameDelivery) || nameDelivery.Length > MAXIMUM_TEXT_LENGTH)
            {
                str = "Наменование службы доставки не указано или его длина более 255 символов";
            };

            Delivery delivery = new Delivery(vendorCode, dayDelivery, nameDelivery, priceDeliver);

            return (str, delivery);
        }

    }
}