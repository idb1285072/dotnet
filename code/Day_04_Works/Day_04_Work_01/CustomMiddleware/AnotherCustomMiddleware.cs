namespace Day_04_Work_01.CustomMiddleware
{
    public class AnotherCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My Custom Middleware - Starts");
            await next(context);
            await context.Response.WriteAsync("My Custom Middleware - Ends");
        }
    }

    public static class AnotherCustomMiddlewareExtension
    {
        public static IApplicationBuilder UseAnotherCustomMiddleware(this IApplicationBuilder app)
        {
           return app.UseMiddleware<AnotherCustomMiddleware>();
        }
    }
}
