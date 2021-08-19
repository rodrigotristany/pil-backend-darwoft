using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pil_backend_darwoft.Services;

namespace pil_backend_darwoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository surveyRepository)
        {
            _userRepository = surveyRepository ?? throw new ArgumentNullException(nameof(surveyRepository));
        }

        [HttpGet]
        public IActionResult GetUser(int userId)
        {
            var user = _userRepository.GetUser(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
