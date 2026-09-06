//var builder = WebApplication.CreateBuilder(args);

// Method 2: anyFolderName + WebApplicationOptions() + UseStaticFiles()
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "myroot"
});

var app = builder.Build();

// Method 1: wwwroot folder name + app.UseStaticFiles()
app.UseStaticFiles();

// Method 3: for more than one folder
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "mywebroot"))
});

app.MapGet("/", () => "Hello World!");

app.Run();
