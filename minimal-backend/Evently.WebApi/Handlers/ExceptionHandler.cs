using Evently.Shared.Core.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Evently.WebApi.Handlers
{
    public static class ExceptionHandler
    {
        public static IActionResult Handle(Exception exception)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            var message = "O servidor falhou em atender a requisição!";
            var errors = new List<string> { exception.Message };
            if (exception is DomainException domainException)
            {
                statusCode = HttpStatusCode.BadRequest;
                message = domainException.ErrorMessage ?? message;
                errors = domainException.Errors ?? errors;
            }
            return new ObjectResult(new ResponseResult(false, message, null, errors, statusCode))
            {
                StatusCode = (int)statusCode
            };
        }
    }
}
