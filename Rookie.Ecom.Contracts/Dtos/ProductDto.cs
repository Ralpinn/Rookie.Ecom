using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }

        public string Desc { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal? Cost { get; set; }

        public bool IsFeatured { get; set; }

        public Guid? CategoryId { get; set; }

        public Guid? PublisherId { get; set; }

        public Guid? AuthorId { get; set; }

    }
}
