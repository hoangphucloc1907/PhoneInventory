namespace PhoneWarehouse.Models
{
    internal class Supplier : IModel
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
