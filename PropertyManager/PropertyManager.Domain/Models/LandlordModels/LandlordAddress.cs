namespace PropertyManager.Domain.Models
{
    public class LandlordAddress : Address
    {
        public string LandlordId { get; set; }

        //Navigation properties
        public virtual Landlord Landlord { get; set; }
    }
}
