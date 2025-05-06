using Evently.Domain.User;
using Evently.Domain.User.Interfaces;
using Evently.Shared.Core.Http;
using Evently.WebApi.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Evently.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserRepository _repository) : ControllerBase
    {
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            try
            {
                var user = await _repository.GetUserById(id);
                if (user == null)
                    return NotFound(ResponseResult.Fail("Usuário não encontrado", System.Net.HttpStatusCode.NotFound));
                return Ok(ResponseResult.Ok(user));
            }
            catch (Exception ex)
            {
                return ExceptionHandler.Handle(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(ResponseResult.Ok(await _repository.GetAllUsers()));
            } catch (Exception ex)
            {
                return ExceptionHandler.Handle(ex);
            }
        }
    }
}
