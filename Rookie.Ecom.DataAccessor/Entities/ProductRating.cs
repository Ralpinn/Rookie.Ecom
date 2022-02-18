using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class ProductRating :BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Rating { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Comment { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
