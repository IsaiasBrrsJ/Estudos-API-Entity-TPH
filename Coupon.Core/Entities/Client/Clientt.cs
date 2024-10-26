using Cumpom.Core.Entities.Coupon;
using Cumpom.Core.Enums;

namespace Cumpom.Core.Entities.Client.Coupon
{
    public class Clientt : EntityBase
    {
        //ef
        public Clientt()
        {
            
        }
        public Clientt(string name, string lastName, string phoneNumber, string email, TypeClient typeClient)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            TypeClient = typeClient;
            CreatedAt = DateTime.Now;
            IsActive = true;
        }

        public string Name { get; init; } = default!;
        public string LastName { get; init; } = default!;
        public string PhoneNumber { get; init; } = default!;
        public string Email { get; init; }  
        public TypeClient TypeClient { get; init; }
        public DateTime CreatedAt { get; init; }

        public bool IsActive { get; init; }
        public virtual ICollection<Couponn> Coupons  { get; init; }



    }
}
