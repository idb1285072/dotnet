// Middleware (Run and Use) and Custom Middleware
using Day_04_Work_01.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyCustomMiddleware>();
builder.Services.AddTransient<AnotherCustomMiddleware>();

var app = builder.Build();

// middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("middleware 1");
    await next(context);
    await context.Response.WriteAsync("middleware 2");
});

// middleware 2
app.UseMiddleware<MyCustomMiddleware>();
app.UseAnotherCustomMiddleware();
app.UseCustomConventionalMiddleware();

// middleware 3: terminating middleware
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello");
});

// middleware 4
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello again");
});

// middleware 5
app.Run();
