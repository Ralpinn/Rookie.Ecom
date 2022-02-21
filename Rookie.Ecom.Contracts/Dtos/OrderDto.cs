using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class OrderDto
    {
        public Guid? Id { get; set; }
        public string Number { get; set; }
        public string Desc { get; set; }

        public decimal Total { get; set; }

        public decimal OrderCharge { get; set; }

        public decimal PaymentMethod { get; set; }

        public string DeliveryAddress { get; set; }

        public Guid? CustomerAddresseId { get; set; }

        public Guid? UserId { get; set; }
    }
}
