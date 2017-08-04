using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ItemTax
    {
        public int ItemTaxId { get; set; }
        public int ItemId { get; set; }
        public int TaxTypeId { get; set; }
        public int InvoiceNumber { get; set; }
        public int CreationDate { get; set; }
    }
}
