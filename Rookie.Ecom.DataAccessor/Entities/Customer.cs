using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Customer : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime ApprovedDate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
