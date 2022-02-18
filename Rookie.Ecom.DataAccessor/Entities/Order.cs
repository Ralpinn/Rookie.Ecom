using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Number { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }

        public decimal Total { get; set; }

        public decimal OrderCharge { get; set; }

        public decimal PaymentMethod { get; set; }

        public string DeliveryAddress { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
