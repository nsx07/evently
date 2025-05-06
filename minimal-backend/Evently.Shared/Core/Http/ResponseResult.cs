using System.Net;

namespace Evently.Shared.Core.Http
{
    public class ResponseResult(bool success, string? message, object? data = null, List<string>? errors = null, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        public object? Data { get; set; } = data;
        public bool Success { get; set; } = success;
        public string? Message { get; set; } = message;
        public HttpStatusCode StatusCode { get; set; } = statusCode;
        public List<string>? Errors { get; set; } = errors;

        public static ResponseResult Ok<T>(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new ResponseResult(true, null, data, null, statusCode);
        }

        public static ResponseResult NoContent(string message, HttpStatusCode statusCode = HttpStatusCode.NoContent)
        {
            return new ResponseResult(true, message, null, null, statusCode);
        }

        public static ResponseResult Fail(string message, HttpStatusCode statusCode, List<string>? errors = null)
        {
            return new ResponseResult(false, message, null, errors?.Count > 0 ? errors : [message], statusCode);
        }
    }
}
