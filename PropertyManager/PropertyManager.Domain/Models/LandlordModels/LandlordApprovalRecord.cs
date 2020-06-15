using System;
using PropertyManager.Domain.Common;
using PropertyManager.Domain.Enum;

namespace PropertyManager.Domain.Models
{
    public class LandlordApprovalRecord : AuditableEntity
    {
        public string Id { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string LandlordId { get; set; }

        //Navigation properties
        public virtual Landlord Landlord { get; set; }
    }
}
