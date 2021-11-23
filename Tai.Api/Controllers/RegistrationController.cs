using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tai.Infrastructure.DB.Models;
using Tai.Infrastructure.DTO.Request;

namespace Tai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public RegistrationController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        /// <summary>
        /// Register new user to the system
        /// </summary>
        /// <param name="request">Request with new user email, password, first name, last name and phone number</param>
        /// <param name="cancellationToken">Propagates notification that operation should be canceled</param>
        /// <returns>Created user id</returns>
        [HttpPost("registerUser")]
        [ProducesResponseType(typeof(IEnumerable<IdentityError>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> RegisterUser(RegisterRequest request, CancellationToken cancellationToken)
        {
            var userToCreate = _mapper.Map<User>(request);

            var creatingUserResult = await _userManager.CreateAsync(userToCreate, request.Password);
            if (!creatingUserResult.Succeeded)
            {
                return BadRequest(creatingUserResult.Errors);
            }

            return Ok(userToCreate.Id);
        }
    }
}
