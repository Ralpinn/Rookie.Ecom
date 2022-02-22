using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.Dashboard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ICategoryService _categoryService;

        public ProductController(
            ILogger<ProductController> logger,
            ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAsync()
        {
            return (IEnumerable<ProductDto>)await _categoryService.GetAllAsync();
        }
    }
}
