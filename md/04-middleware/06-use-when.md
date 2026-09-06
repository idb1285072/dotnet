```cs

app.UseWhen(
  (HttpContext context) =>  context.Request.Query.ContainsKey("username"),
  (IApplicationBuilder app) =>
  {
  app.Use(async (HttpContext context, RequestDelegate next) =>
  {
    await context.Response.WriteAsync("Hello from Middleware branch");
    await next(context);
  });
  });

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello from Main chain.");
});
```
