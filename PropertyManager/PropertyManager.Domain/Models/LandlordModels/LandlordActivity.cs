using PropertyManager.Domain.Common;

namespace PropertyManager.Domain.Models
{
    public class LandlordActivity : AuditableEntity
    {
        public string Id { get; set; }
        public string Action { get; set; }
        public string Text { get; set; }
        public string LandlordId { get; set; }

        //Navigation Properties
        public virtual Landlord Landlord { get; set; }
    }
}
