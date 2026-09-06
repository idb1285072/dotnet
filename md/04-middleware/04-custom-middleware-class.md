# Custom Middleware Class

## What?

- Middleware class is used to separate the middleware logic from a lambda expression to a separate / reusable class

## Syntax

```cs
// STEP 1: Create Middleware
class MiddlewareClassName : IMiddleware
{
  public async Task InvokeAsync(HttpContext context, RequestDelegate next)
  {
    // before logic
    await next(context);
    // after logic
  }
}

// STEP 2: Register
builder.Services.AddTransient<MiddlewareClassName>();

// STEP 3: Use
app.UseMiddleware<MiddlewareClassName>();
```

## Syntax - by Extension Method

```cs
// STEP 1: Create Middleware
class MiddlewareClassName : IMiddleware
{
  public async Task InvokeAsync(HttpContext context, RequestDelegate next)
  {
    // before logic
    await next(context);
    // after logic
  }
}

// STEP 2: Extension Method
public static class MiddlewareClassNameExtension
{
    public static IApplicationBuilder UseMiddleWareName(this IApplicationBuilder app)
    {
       return app.UseMiddleware<MiddlewareName>();
    }
}

// STEP 3: Register
builder.Services.AddTransient<MiddlewareClassName>();

// STEP 4: Use
app.UseMiddleWareName();
```

## Syntax - Conventional Middleware

- Add New Item -> Search Middleware -> Middleware Class Template

```cs
class MiddlewareClassName
{
  private readonly RequestDelegate _next;
  public MiddlewareClassName(RequestDelegate next)
  {
    _next = next;
  }
  public async Task InvokeAsync(HttpContext context)
  {
    // before logic
    await _next(context);
    // after logic
  }
}

```
