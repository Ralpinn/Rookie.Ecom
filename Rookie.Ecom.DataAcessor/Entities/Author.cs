using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAcessor.Entities
{
    public class Author : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }
    }
}
