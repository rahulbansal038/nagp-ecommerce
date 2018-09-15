using System.Collections.Generic;

namespace AmCart.Domain
{
    public class User : DomainBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public bool IsVerified { get; set; }

        public IList<UserAddress> Addresses { get; set; }

        public IList<UserPaymentInfo> PaymentInfos { get; set; }
    }
}
