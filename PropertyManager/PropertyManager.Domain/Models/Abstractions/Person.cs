using PropertyManager.Domain.Common;
using PropertyManager.Domain.Enum;
using System;

namespace PropertyManager.Domain.Models
{
    public abstract class Person : AuditableEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime Dob { get; set; }
        public ActiveStatus ActiveStatus { get; set; }
    }
}
