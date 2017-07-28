using System.Collections.Generic;

namespace Entities
{
    public class RegistrationDetails
    {
        public int RegistrationDetailsId{ get; set; }
        public int firmId { get; set; }
        public List<RegistrationFeild> registrationFeilds { get; set; }
        public List<Address> address { get; set; }
    }
}