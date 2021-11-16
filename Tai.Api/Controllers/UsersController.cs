using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tai.Infrastructure.Services;

namespace Tai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService=userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var notes = _userService.GetAll();

            return Ok(notes);
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var note = _userService.Get(id);
            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }
    }
}
