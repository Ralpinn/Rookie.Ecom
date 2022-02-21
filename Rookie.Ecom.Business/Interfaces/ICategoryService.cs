using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Interfaces
{
    public interface ICategoryService 
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<IEnumerable<CustomerDto>> GetAllCustomerAsync();
        Task<IEnumerable<CustomerAddressDto>> GetAllCustomerAddressAsync();
        Task<IEnumerable<OrderDto>> GetAllOrderAsync();
        Task<IEnumerable<OrderDetailDto>> GetAllOrderDetailAsync();
        Task<IEnumerable<ProductRatingDto>> GetAllProductRatingAsync();
        Task<IEnumerable<AuthorDto>> GetAllAuthorAsync();
        Task<IEnumerable<PublisherDto>> GetAllPublisherAsync();
        Task<IEnumerable<UserDto>> GetAllUserAsync();
        Task<IEnumerable<RoleDto>> GetAllRoleAsync();
        Task AddAsync(CategoryDto categoryDto);
        Task<CategoryDto> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(CategoryDto categoryDto);
    }
}
