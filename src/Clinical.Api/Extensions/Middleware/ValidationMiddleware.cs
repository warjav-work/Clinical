using Clinical.Application.UseCase.Commons.Bases;
using Clinical.Application.UseCase.Commons.Exceptions;
using Clinical.Utilities.Constants;
using System.Text.Json;

namespace Clinical.Api.Extensions.Middleware
{
    public class ValidationMiddleware
    {
        private readonly RequestDelegate _next;

        public ValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context) 
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (ValidationException ex)
            {
                context.Response.ContentType = "application/json";
                await JsonSerializer.SerializeAsync(context.Response.Body, new BaseResponse<object> 
                { 
                    Message = GlobalMessages.MESSAGE_VALIDATE,
                    Errors = ex.Errors
                });
                
            }
        }
    }
}
