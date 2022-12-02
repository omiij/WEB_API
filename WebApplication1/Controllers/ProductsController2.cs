using Microsoft.AspNetCore.Mvc;
using WebApplication1.NewFolder4;

namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController2 : Controller
    {
        private readonly IProductRepocs _ProductRepo; 
        public ProductsController2(IProductRepocs ProductRepo)
        {
            _ProductRepo = ProductRepo;
        }
        [HttpPost("")]
        public IActionResult Index([FromBody] Products product)
        {
             

            _ProductRepo.addProduct(product);
            var products = _ProductRepo.GetAllProducts();
            return Ok( products );
        }
    }
}
