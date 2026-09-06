using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Day_04_Work_01.CustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomConventionalMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomConventionalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("Convensional Middleware - starts");
            await _next(httpContext);
            await httpContext.Response.WriteAsync("Convensional Middleware - starts");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomConventionalMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomConventionalMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomConventionalMiddleware>();
        }
    }
}
