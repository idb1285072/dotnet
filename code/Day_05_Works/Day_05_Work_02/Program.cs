// Route Parameter
// Default Value - {id=1}
// Optional Parameter - {id?}

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Here, fileName, extension are route parameters
// Route parameters are case insensitive
// GET: /files/{fileName}.{extension}
app.Map("files/{fileName}.{extension}", async (HttpContext context) =>
{
    string? fileName = Convert.ToString(context.Request.RouteValues["fileName"]);
    string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
    await context.Response.WriteAsync($"In Files - {fileName} {extension}");
});

// GET: /employee/profile/{employeeName}
// Default Parameters
app.Map("employee/profile/{employeeName=scott}", async (HttpContext context) =>
{
    string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
    await context.Response.WriteAsync($"{employeeName}");
});

// GET: product/details/{id}
app.Map("product/details/{id?}", async (HttpContext context) =>
{
    if (context.Request.RouteValues.ContainsKey("id"))
    {

        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Product Details - {id}");
    }
    else
    {
        await context.Response.WriteAsync("Product Details - No id is supplied");
    }
});

app.MapFallback(async (HttpContext context) =>
{
    await context.Response.WriteAsync($"The path is: {context.Request.Path}");
});

app.Run();
