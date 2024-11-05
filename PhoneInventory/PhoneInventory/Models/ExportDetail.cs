namespace PhoneWarehouse.Models
{
    internal class ExportDetail : IModel
    {
        public int Id { get; set; }
        public int ExportId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Product Product { get; set; }
        public Export Export { get; set; }
        public Customer Customer { get; set; }
        public User Employee { get; set; }
    }
}
