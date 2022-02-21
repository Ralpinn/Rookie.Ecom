using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class CustomerAddress : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        public decimal PaymentMethod { get; set; }

        public string ShippingAddress { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public object UserId { get; set; }
    }
}
