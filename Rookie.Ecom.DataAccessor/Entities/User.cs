using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Password { get; set; }

        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }
        public ICollection<Role> Roles { get; set; }
        public object RoleId { get; set; }
        public object CustomerAddressId { get; set; }
    }
}
