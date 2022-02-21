using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class OrderDetailDto
    {
        public Guid? Id { get; set; }
        public string Quantity { get; set; }

        public Guid? ProductId { get; set; }

        public Guid? OrderId { get; set; }
    }
}
