using Evently.Application.Services.Event.Interface;
using Evently.Application.Services.Event.ViewModel;
using Evently.Shared.Core.Http;
using Evently.WebApi.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Evently.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController(IEventService eventService) : ControllerBase
    {
        private readonly IEventService _eventService = eventService;

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventViewModel model)
        {
            try
            {
                return Ok(ResponseResult.Ok(await _eventService.CreateEvent(model), HttpStatusCode.Created));
            }
            catch (Exception ex)
            {
                return ExceptionHandler.Handle(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            try
            {
                return Ok(ResponseResult.Ok(await _eventService.GetEvents(), HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return ExceptionHandler.Handle(ex);
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetEventById(Guid id)
        {
            try
            {
                return Ok(ResponseResult.Ok(await _eventService.GetEventById(id), HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return ExceptionHandler.Handle(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveEvent(Guid id)
        {
            try
            {
                await _eventService.RemoveEvent(id);
                return Ok(ResponseResult.Ok<object?>(null, HttpStatusCode.NoContent));
            }
            catch (Exception ex)
            {
                return ExceptionHandler.Handle(ex);
            }
        }
    }
}
