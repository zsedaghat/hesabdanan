using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdanan.Model
{
    public class SellerList
    {
        public string PId { get; set; }
        public string Date { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Count { get; set; }
        public string UnitPrice { get; set; }
        public bool IsUsed { get; set; }
        public string NewCount { get; set; }
    }
}
