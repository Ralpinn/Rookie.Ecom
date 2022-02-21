using AutoMapper;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.DataAccessor;
using Rookie.Ecom.DataAccessor.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Rookie.Ecom.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _genericRepository;
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<OrderDetail> _orderDetailRepository;
        private readonly IGenericRepository<Customer> _customerRepository;
        private readonly IGenericRepository<CustomerAddress> _customerAddressRepository;
        private readonly IGenericRepository<ProductRating> _productRatingRepository;
        private readonly IGenericRepository<Author> _authorRepository;
        private readonly IGenericRepository<Publisher> _publisherRepository;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public CategoryService(
            IGenericRepository<Category> genericRepository,
            IGenericRepository<Product> productRepository,
            IGenericRepository<Order> orderRepository,
            IGenericRepository<OrderDetail> orderDetailRepository,
            IGenericRepository<Customer> customerRepository,
            IGenericRepository<CustomerAddress> customerAddressRepository,
            IGenericRepository<ProductRating> productRatingRepository,
            IGenericRepository<Author> authorRepository,
            IGenericRepository<Publisher> publisherRepository,
            IGenericRepository<User> userRepository,
            IGenericRepository<Role> roleRepository,
            IMapper mapper)
        {
            _genericRepository = genericRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _customerRepository = customerRepository;
            _customerAddressRepository = customerAddressRepository;
            _productRatingRepository = productRatingRepository;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var result = await _genericRepository.GetAllAsync();
            var result2 = await _productRepository.GetAllAsync();

            var rs = (from q1 in result
                      join q2 in result2
                      on q1.Id equals q2.CategoryId
                      select new { CategoryName = q1.Name, ProductName = q2.Name }
                      ).ToList();
            return _mapper.Map<IEnumerable<CategoryDto>>(result);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var result = await _productRepository.GetAllAsync();
            var result2 = await _productRatingRepository.GetAllAsync();
            var result3 = await _orderDetailRepository.GetAllAsync();
            var rs = (from q1 in result
                      join q2 in result2
                      on q1.Id equals q2.ProductId
                      select new { ProductRatingId = q1.Id, ProductId = q2.Id }
                      ).ToList();
            var rs2 = (from q1 in result
                      join q3 in result3
                      on q1.Id equals q3.ProductId
                      select new { OrderDetailId = q1.Id, ProductId = q3.Id }
                      ).ToList();
            return _mapper.Map<IEnumerable<ProductDto>>(result);
        }
        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync()
        {
            var result = await _orderRepository.GetAllAsync();
            var result2 = await _orderDetailRepository.GetAllAsync();
            var rs = (from q1 in result
                       join q2 in result2
                       on q1.Id equals q2.OrderId
                       select new { OrderDetailId = q1.Id, OrderId = q2.Id }
                     ).ToList();
            return _mapper.Map<IEnumerable<OrderDto>>(result);
        }
        public async Task<IEnumerable<OrderDetailDto>> GetAllOrderDetailAsync()
        {
            var result = await _orderDetailRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<OrderDetailDto>>(result);
        }
        public async Task<IEnumerable<CustomerDto>> GetAllCustomerAsync()
        {
            var result = await _customerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(result);
        }
        public async Task<IEnumerable<CustomerAddressDto>> GetAllCustomerAddressAsync()
        {
            var result = await _customerAddressRepository.GetAllAsync();
            
            return _mapper.Map<IEnumerable<CustomerAddressDto>>(result);
        }
        public async Task<IEnumerable<ProductRatingDto>> GetAllProductRatingAsync()
        {
            var result = await _productRatingRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductRatingDto>>(result);
        }
        public async Task<IEnumerable<AuthorDto>> GetAllAuthorAsync()
        {
            var result = await _authorRepository.GetAllAsync();
            var result2 = await _productRepository.GetAllAsync();

            var rs = (from q1 in result
                      join q2 in result2
                      on q1.Id equals q2.AuthorId
                      select new { AuthorName = q1.Name, ProductName = q2.Name }
                      ).ToList();
            return _mapper.Map<IEnumerable<AuthorDto>>(result);
        }
        public async Task<IEnumerable<PublisherDto>> GetAllPublisherAsync()
        {
            var result = await _publisherRepository.GetAllAsync();
            var result2 = await _productRepository.GetAllAsync();

            var rs = (from q1 in result
                      join q2 in result2
                      on q1.Id equals q2.PublisherId
                      select new { PublisherName = q1.Name, ProductName = q2.Name }
                      ).ToList();
            return _mapper.Map<IEnumerable<PublisherDto>>(result);
        }
        public async Task<IEnumerable<UserDto>> GetAllUserAsync()
        {
            var result = await _userRepository.GetAllAsync();
            var result2 = await _customerAddressRepository.GetAllAsync();
            var result3 = await _customerRepository.GetAllAsync();
            var result4 = await _orderRepository.GetAllAsync();
            var rs = (from q1 in result
                      join q2 in result2
                      on q1.Id equals q2.UserId
                      select new { UserId = q1.Id, CustomerAddressId = q2.Id }
                      ).ToList();
            
            var rs2 = (from q1 in result
                      join q3 in result3
                      on q1.Id equals q3.UserId
                      select new { UserId = q1.Id, CustomerId = q3.Id }
                     ).ToList();

            var rs3 = (from q1 in result
                       join q4 in result4
                       on q1.Id equals q4.UserId
                       select new { UserId = q1.Id, OrderId = q4.Id }
                     ).ToList();
            return _mapper.Map<IEnumerable<UserDto>>(result);
        }
        public async Task<IEnumerable<RoleDto>> GetAllRoleAsync()
        {
            var result = await _roleRepository.GetAllAsync();
            var result2 = await _userRepository.GetAllAsync();

            var rs = (from q1 in result
                      join q2 in result2
                      on q1.Id equals q2.RoleId
                      select new { RoleName = q1.Id, UserName = q2.Id }
                      ).ToList();
            return _mapper.Map<IEnumerable<RoleDto>>(result);
        }

        public Task<IEnumerable<OrderDto>> GetAllOrderAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
