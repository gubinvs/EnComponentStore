namespace EnComponentStore.Core.Models
{
    /// <summary>
    /// Описание склада сервиса
    /// </summary>
    /// 


    public class Warehouse
    {
        public Warehouse(string nameWarehouse)
        {
            this.IdWarehouse = Guid.NewGuid();
            this.NameWarehouse = nameWarehouse;
        }

        /// <summary>
        /// Идентификатор склада
        /// </summary>
        Guid IdWarehouse { get; set; }

        /// <summary>
        /// Название склада
        /// </summary>
        string NameWarehouse { get; set; }

    }
}


