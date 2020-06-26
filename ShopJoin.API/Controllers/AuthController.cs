using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopJoin.API.Data;
using ShopJoin.API.Dtos;
using ShopJoin.API.Models;

namespace ShopJoin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]

        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            //validate request

            if (await _repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Username already exists"); 
            
            var userToCreate = new User
            {
                Username = userForRegisterDto.Username,
                Name = userForRegisterDto.Name
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);
            
            return StatusCode(201);
        } 

        //[HttpPost("login")]
        //public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
    }
}