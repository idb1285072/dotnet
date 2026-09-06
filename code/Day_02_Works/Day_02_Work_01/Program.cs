var builder = WebApplication.CreateBuilder(args);

/*
builder.Configuration
builder.Services
builder.Environment
*/

var app = builder.Build();

/*
app.Middleware 
*/
app.MapGet("/", () => "Hello World!");

app.Run();
