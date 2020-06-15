namespace PropertyManager.Domain.Models
{
    public class LandlordNote : Note
    {
        public string LandlordId { get; set; }

        //Navigation properties
        public virtual Landlord Landlord { get; set; }
    }
}
