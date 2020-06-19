using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopJoin.API.Data;

namespace ShopJoin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetValues()
        {
            var data = _context.users.ToList();

            return Ok(data);
        }


        [HttpGet("{id}")]

        public IActionResult GetValue(int id)
        {
            var value = _context.users.FirstOrDefault(x => x.Id == id);

            return Ok(value); 
        }

    }

}