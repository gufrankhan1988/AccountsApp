using System.Collections.Generic;

namespace Entities
{
    public class Tax
    {
        public int Id { get; set; }
        public string TaxName { get; set; }
        public float TaxPercentage { get; set; }
        public int TaxDescription { get; set; }
    }
}