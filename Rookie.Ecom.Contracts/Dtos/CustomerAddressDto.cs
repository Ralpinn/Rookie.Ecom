using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class CustomerAddressDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }

        public decimal PaymentMethod { get; set; }

        public string ShippingAddress { get; set; }

        public Guid? UserId { get; set; }
        public Guid? CustomerId { get; set; }
    }
}
