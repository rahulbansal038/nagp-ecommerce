using System.Collections.Generic;

namespace AmCart.Domain
{
    public class Cart : DomainBase
    {
        public IList<Product> Products { get; set; }
    }
}
