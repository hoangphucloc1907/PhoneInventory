namespace PhoneWarehouse.Models
{
    internal class ImportDetail : IModel
    {
        public int Id { get; set; }
        public int ImportId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Product Product { get; set; }
        public Import Import { get; set; }
        public Supplier Supplier { get; set; }
        public User Employee { get; set; }
    }
}
