using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class ProductRatingDto
    {
        public string Rating { get; set; }
        public string Comment { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? UserId { get; set; }
    }
}
