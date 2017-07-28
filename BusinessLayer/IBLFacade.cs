using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBLFacade
    {
        FirmDetails RegisterFirm(FirmDetails firmdetails);
        bool Sell(Invoice invoice);
        bool Purchase(Invoice invoice);

    }
}
