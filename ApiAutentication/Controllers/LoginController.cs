using ApiAuthentication.DTOs;
using ApiAuthentication.Repositories;
using ApiAuthentication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ApiAuthentication.Controllers
{

    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] LoginRequestDTO loginDTO)
        {
            var user = UserRepository.Get(loginDTO.UserName, loginDTO.Password);
            if (user == null)
                return NotFound(new { message = "Usuário ou Senha Inválidos" });

            TokenService tokenService = new TokenService(_configuration);
            var tokenString = tokenService.GenerateToken(user);

            return new LoginResponseDTO
            {
                user = new UserDTO
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Roles = user.Roles
                },
                token = tokenString
            };
        }
    }
}
