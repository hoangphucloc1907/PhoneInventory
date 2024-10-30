namespace PhoneWarehouse.Models
{
    internal class Export : IModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ExportDate { get; set; }
    }
}
