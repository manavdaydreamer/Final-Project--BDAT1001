using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApi_Manav.Models;
using MyApi_Manav.Services;

namespace MyApi_Manav.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateService _authenticateService;

        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Student model)
        {
            var student = _authenticateService.Authenticate(model.UserName, model.Password);
            if (student == null)
            {
                return BadRequest(new { Message = "invalid username or password" });
            }
            else
                return Ok(student);
        }
    }

}
