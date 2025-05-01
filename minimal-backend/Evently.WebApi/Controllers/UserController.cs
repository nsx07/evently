using Evently.Domain.User;
using Evently.Domain.User.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Evently.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserRepository _repository) : ControllerBase
    {
        [HttpGet]
        [Route("/{id:guid}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _repository.GetUserById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.GetAllUsers();
        }
    }
}
