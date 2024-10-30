namespace PhoneWarehouse.Models
{
    internal class ExportDetail : IModel
    {
        public int Id { get; set; }
        public int ExportId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
