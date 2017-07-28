using System.Collections.Generic;

namespace Entities
{
    public class TaxDetail
    {
        public int taxDetailId { get; set; }
        public int ItemId { get; set; }
        public List<TaxType> Taxdetails { get; set; }

    }

    public class TaxType
    {
        public int Id { get; set; }
        public string TaxName { get; set; }
        public float TaxPercentage { get; set; }
        public int taxDetailId { get; set; }
    }
}