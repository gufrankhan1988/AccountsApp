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
            throw new NotImplementedException();
        }

        public FirmDetails RegisterFirm(FirmDetails firmdetails)
        {
            throw new NotImplementedException();

        }

        public bool Sell(Invoice invoice)
        {
            
            throw new NotImplementedException();
        }
        public Address GetAddressByFirmIDandType(int FirmId, int AddressTypeId)
        {
            return new Address();
        }

        public FirmDetails SaveFirm(FirmDetails firmdetails)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAllAddress(int FirmId)
        {
            throw new NotImplementedException();
        }

        public List<FirmDetails> GetAllFirms()
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAllInvoice()
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceByNumber(int InvoiceNumber)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetInvoicesByDateRange(DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetInvoiceByFirm(int FirmId)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetInvoiceByPurchaserName(string PurchaserName)
        {
            throw new NotImplementedException();
        }

        public Invoice UpdateInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
