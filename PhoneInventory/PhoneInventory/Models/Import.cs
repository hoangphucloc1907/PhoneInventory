﻿namespace PhoneWarehouse.Models
{
    internal class Import : IModel
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ImportDate { get; set; }

        public Supplier Supplier { get; set; }
        public User Employee { get; set; }
    }
}
