using System;

namespace AmCart.Domain
{
    public class Product : DomainBase
    {
        public Guid ProductCategoryId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }
    }
}
