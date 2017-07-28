using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer
{
    public class BLFacade : IBLFacade
    {
        public bool Purchase(Invoice invoice)
        {
            AddInvoice(invoice);
        }

        public FirmDetails RegisterFirm(FirmDetails firmdetails)
        {
            throw new NotImplementedException();
        }

        public bool Sell(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
