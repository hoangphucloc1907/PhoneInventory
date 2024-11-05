using PhoneWarehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneInventory.Models
{
    public class CurrentStock : IModel
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int TotalImported { get; set; }
        public int TotalExported { get; set; }
        public int StockBalance { get; set; }
    }
}
