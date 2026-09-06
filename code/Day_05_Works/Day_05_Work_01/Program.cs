var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// Routing is automatically enabled.
// No need for app.UseRouting() anymore

// Endpoints are directly on the "app" object
app.Map("map1", async (HttpContext context) =>
{
    await context.Response.WriteAsync("In Map 1");
});

app.Map("map2", async (HttpContext context) =>
{
    await context.Response.WriteAsync("In Map 2");
});

app.MapGet("map3", async (HttpContext context) =>
{
    await context.Response.WriteAsync("In Map 3");
});

app.MapPost("map4", async (HttpContext context) =>
{
    await context.Response.WriteAsync("In Map 4");
});

app.MapFallback(async (HttpContext context) =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();
