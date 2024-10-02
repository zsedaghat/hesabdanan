using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdanan.Model
{
    public class Result
    {
        public string InvoiceNumber { get; set; }
        public string PoductId { get; set; }
        public long SellCount { get; set; }
        public long SellAmount { get; set; }
        public string SellUnitPrice { get; set; }
        public string ProductName { get; set; }
    }
}
