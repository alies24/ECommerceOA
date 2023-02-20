using ECommerce_OA.Application.Repositories.CustomerRepository;
using ECommerce_OA.Application.Repositories.ProductRepository;
using ECommerce_OA.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceOA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        List<Customer> customers;


        public ValuesController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
             customers = new List<Customer>
            {
                new()
                {
                     CustomerName = "Ali", Orders = null, CreatedDate = DateTime.UtcNow,


                },
                  new()
                {
                     CustomerName = "Ali", Orders = null, CreatedDate = DateTime.UtcNow,


                },
                  new()
                {
                     CustomerName = "Ali", Orders = null, CreatedDate = DateTime.UtcNow,


                }





            };
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
           
            await _customerWriteRepository.AddRangeAsync(customers);
            await  _customerWriteRepository.SaveAsync();
            return Ok();

        }
        [HttpGet("id")]
        public async Task<IActionResult> GetId(int id)
        {
           var result = await _customerReadRepository.GetByIdAsync(id);
            return Ok(result.CustomerName);
        }
    }
}
