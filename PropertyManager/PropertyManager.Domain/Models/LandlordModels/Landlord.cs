using System.Collections.Generic;

namespace PropertyManager.Domain.Models
{
    public class Landlord : Person
    {
        public string RegisterNumber { get; set; }

        //Navigation Properties
        public virtual IEnumerable<LandlordNote> Notes { get; set; }
        public virtual IEnumerable<LandlordActivity> Activity { get; set; }
        public virtual LandlordAddress ContactAddress { get; set; }
        public virtual LandlordApprovalRecord ApprovalRecord { get; set; }
    }
}
