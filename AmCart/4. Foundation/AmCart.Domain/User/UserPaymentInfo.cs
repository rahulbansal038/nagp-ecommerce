using System;

namespace AmCart.Domain
{
    public class UserPaymentInfo : DomainBase
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public CardType CardType { get; set; }

        public string CardNumber { get; set; }

        public string ExpiryMonth { get; set; }

        public string ExpiryYear { get; set; }
    }
}
