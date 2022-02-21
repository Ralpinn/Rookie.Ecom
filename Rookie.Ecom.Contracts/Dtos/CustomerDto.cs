using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class CustomerDto
    {
        public Guid? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime ApprovedDate { get; set; }

        public Guid? UserId { get; set; }
    }
}
