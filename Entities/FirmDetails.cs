using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FirmDetails
    {
        public int Id { get; set; }
        public string firmName { get; set; }
        public ContactNumber contactNumber { get; set; }
        public List<RegistrationFeild> registrationFeilds { get; set; }
        public List<Address> address { get; set; }
        public FirmType firmtype { get; set; }
    }
}
