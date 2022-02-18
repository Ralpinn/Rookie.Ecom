using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class OrderDetail : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string Quantity { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
