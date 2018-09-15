using System;

namespace AmCart.Domain
{
    public class UserAddress : DomainBase
    {
        public Guid UserId { get; set; }

        public string Nickname { get; set; }

        public AddressType AddressType { get; set; }

        public string RecipientName { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZIP { get; set; }

        public long Phone { get; set; }
    }
}
