using Day_07_Work_02.CustomModelBinders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    //options.ModelBinderProviders.Insert(0, new PersonModelBinderProvider());

});

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.Run();
