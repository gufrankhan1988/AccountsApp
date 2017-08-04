using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Stock
    {
        public int StockID { get; set; }
        public Item item { get; set; }
        public UnitType Unit { get; set; }

    }
}
