using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiUsingCrudStored.Repo;

namespace WebApiUsingCrudStored.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdController : ControllerBase
    {
      private readonly IRepository _repository;

        public ProdController(IRepository repository)
        {
           this._repository = repository;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetMyProducts()
        {
            var data = _repository.GetProducts();
            return Ok(data);
        }


        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct([FromBody] Models.Product product)
        {
            _repository.AddProduct(product);
            return Ok("Product Added Successfully");
        }

    }
}
