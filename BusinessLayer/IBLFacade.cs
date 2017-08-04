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
        FirmDetails SaveFirm(FirmDetails firmdetails);
        bool Sell(Invoice invoice);
        bool Purchase(Invoice invoice);
        Address GetAddressByFirmIDandType(int FirmId, int AddressTypeId);
        List<Address> GetAllAddress(int FirmId);
        List<FirmDetails> GetAllFirms();
        List<Invoice> GetAllInvoice();
        Invoice GetInvoiceByNumber(int InvoiceNumber);
        List<Invoice> GetInvoicesByDateRange(DateTime From, DateTime To);
        List<Invoice> GetInvoiceByFirm(int FirmId);
        List<Invoice> GetInvoiceByPurchaserName(string PurchaserName);
        Invoice UpdateInvoice(Invoice invoice);
    }
}
