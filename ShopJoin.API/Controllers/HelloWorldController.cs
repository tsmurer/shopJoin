using Microsoft.AspNetCore.Mvc;

namespace ShopJoin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Content("Hello World");
        }
    }
}