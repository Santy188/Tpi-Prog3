using Aplication.Interfaces;
using Aplication.Models.Request;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tpi_Ecommerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
       // [Authorize(Roles = "Administrador")]
        public ActionResult<User?> GetByName(string name) 
        {  
            var result = _userService.GetByName(name);
            if(result == null)  return NotFound("Usuario no registrado"); 
            return result;
              
        }

        [HttpPost]
        public ActionResult Add([FromBody]AddUserRequest request) 
        {
            if(!ModelState.IsValid)
            {  return BadRequest(ModelState.Values.ToList()); }
            return Ok(_userService.AddUser(request));
        }
       

    }
}
