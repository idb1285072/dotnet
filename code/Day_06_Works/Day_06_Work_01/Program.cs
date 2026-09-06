using Day_06_Work_01.Controllers;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddTransient<HomeController>();
builder.Services.AddControllers();// adds all the controller classes as services

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers(); // routing

app.Run();
