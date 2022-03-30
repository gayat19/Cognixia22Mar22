using EShoppingGatewayAPI.Models;
using EShoppingGatewayAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingGatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userRepo;
        public UserController(IUser userRepo)
        {
            _userRepo = userRepo;
        }
        [HttpPost]
        [Route("Login")]
        public ActionResult<UserLoginDTO> Login(UserLoginDTO user)
        {
            var resultUser = _userRepo.Login(user);
            if(resultUser != null)
                return Ok(resultUser);
            user.Password = "";
            return Unauthorized(user);
        }
        [HttpPost]
        [Route("Register")]
        public ActionResult<UserLoginDTO> Register(UserDTO user)
        {
            var resultUser = _userRepo.Register(user);
            if (resultUser != null)
                return Ok(resultUser);
            user.Password = "";
            return BadRequest(user);
        }
    }
}
