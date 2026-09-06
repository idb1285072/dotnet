// HTTP Request
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// POST: (body->row->text) name=Raj&age=20&age=30
app.Run(async (HttpContext context) =>
{
    System.IO.StreamReader reader = new StreamReader(context.Request.Body);
    string body = await reader.ReadToEndAsync();

    Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

    if (queryDict.ContainsKey("name"))
    {
        string? name = queryDict["name"][0];
        await context.Response.WriteAsync(name ?? "no-value");
    }
});

app.Run(async (HttpContext context) =>
{
    if (context.Request.Method == "GET")
    {
        if (context.Request.Query.ContainsKey("name"))
        {
            // QueryString /student?id=1&name=raj
            string? name = context.Request.Query["name"];
            await context.Response.WriteAsync($"<h1>Hello, {name}!</h1>");
        }

        // request headers
        if (context.Request.Headers.ContainsKey("User-Agent"))
        {
            string? userAgent = context.Request.Headers["User-Agent"];
            await context.Response.WriteAsync($"<p>{userAgent}</p>");
        }

        if (context.Request.Headers.ContainsKey("CustomRequestHeader"))
        {
            // POST: (Headers -> CustomRequestHeader)
            string? customRequestHeader = context.Request.Headers["CustomRequestHeader"];
            await context.Response.WriteAsync($"<p>Custom Request Header: {customRequestHeader}</p>");
        }
    }
});

app.Run(async (HttpContext context) =>
{
    // request path and url
    string path = context.Request.Path;
    string method = context.Request.Method;

    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync($"<h1>Path: {path}</h1>");
    await context.Response.WriteAsync($"<h1>Method: {method}</h1>");
});

app.Run();
