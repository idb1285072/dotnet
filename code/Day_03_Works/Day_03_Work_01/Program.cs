// HTTP Response
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    // status code
    context.Response.StatusCode = 400;

    // response headers
    context.Response.Headers["MyKey"] = "my value";
    context.Response.Headers["Server"] = "no server";
    context.Response.Headers["Content-Type"] = "text/html";

    // response body
    await context.Response.WriteAsync("<h1>Hello World</h1>");
    await context.Response.WriteAsync("<h3>DotNet Core</h3>");
});

app.Run();
