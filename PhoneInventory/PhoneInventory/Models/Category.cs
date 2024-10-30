namespace PhoneWarehouse.Models
{
    internal class Category : IModel
    {
        public int Id { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
    }
}
