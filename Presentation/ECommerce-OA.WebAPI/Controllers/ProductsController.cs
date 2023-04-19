using ECommerce_OA.Application.Repositories.ProductRepository;
using ECommerce_OA.Application.ViewModels.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;

namespace ECommerceOA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductReadRepository _productReadRepository;
        IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = _productReadRepository.GetAll(false);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productReadRepository.GetByIdAsync(id, false);
            return Ok(result);

        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(VM_CreateProduct vmodel)
        {
           var result = await _productWriteRepository.AddAsync(new()
            {
                Name = vmodel.Name, UnitPrice = vmodel.UnitPrice, Description = vmodel.Description, 
                UnitsInStock = vmodel.UnitsInStock
            });
            await _productWriteRepository.SaveAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(VM_UpdateProduct vmodel)
        {
            var result = await _productReadRepository.GetByIdAsync(vmodel.Id);
            result.Id = vmodel.Id;
            result.Description = vmodel.Description;
            result.UnitPrice = vmodel.UnitPrice;
            result.Name = vmodel.Name;
            result.UnitsInStock = vmodel.UnitsInStock;
            await _productWriteRepository.SaveAsync();
            return Ok();
            
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _productReadRepository.GetByIdAsync(id);
            _productWriteRepository.Remove(result);
            await _productWriteRepository.SaveAsync();
            return Ok();

        }
    }
}
