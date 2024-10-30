namespace PhoneWarehouse.Models
{
    internal class Product : IModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Description { get; set; }
    }
}
