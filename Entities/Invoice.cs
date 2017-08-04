using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<Item> InvoiceGoods { get; set; }
        public FirmDetails SellerDetail { get; set; }
        public List<FirmDetails> PurchaserDetails { get; set; }

    }
}
