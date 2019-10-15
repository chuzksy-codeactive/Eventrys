using System.Collections.Generic;
using System.Threading.Tasks;
using Eventrys.Src.Domain.Entities;
using Eventrys.Src.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventrys.Src.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        private readonly ILogger _logger;
        public UserController (IUser user, ILogger<UserController> logger)
        {
            _user = user;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers ()
        {
            var users = await _user.GetAll ();

            if (users == null) return NotFound ();

            return Ok (users);
        }

        [HttpGet ("id")]
        public async Task<IActionResult> GetUser (int id)
        {
            var user = await _user.GetById (id);

            if (user == null) return NotFound ();

            return Ok (user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser (User u)
        {
            var user = await _user.Create (u);

            return Ok(user);
        }
    }
}