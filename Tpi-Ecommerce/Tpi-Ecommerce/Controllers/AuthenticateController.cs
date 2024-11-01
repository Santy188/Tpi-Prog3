using Aplication.Interfaces;
using Aplication.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tpi_Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ICustomAuthenticateService _customAuthenticateService;

        public AuthenticateController(IConfiguration config, ICustomAuthenticateService customAuthenticateService)
        {
            _config = config;
            _customAuthenticateService = customAuthenticateService;
        }
        [HttpPost]
        public ActionResult<string> Autenticar(AuthenticateRequest authenticationRequest) //Enviamos como parámetro la clase que creamos arriba
        {
            string? token = _customAuthenticateService.Authenticate(authenticationRequest); //Lo primero que hacemos es llamar a una función que valide los parámetros que enviamos.

            if (token.IsNullOrEmpty()) return BadRequest("Incorrect user or password");
            return Ok(token);
        }
    }
}
