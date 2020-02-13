using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(GetDummyUsers());
        }

        public IEnumerable<User> GetDummyUsers()
        {
            var users = new List<User>()
            {
                new User
                {
                    Id = 1,
                    Name = "Rakesh",
                    Email = "rakesh.jha@zydus.in"
                },
                new User
                {
                    Id = 2,
                    Name = "Ramesh",
                    Email = "ramesh.jha@zydus.in"
                }
            };

            return users;
        }
    }
}
