## Syntax

```cs
app.Use(async(HttpContext context, RequestDelegate next)=>
{
  //before logic
  await next(context);
  //after logic
});
```

## What?

- The extension method called `Used` is used to execute a non-terminating / Short-circuiting middleware that may / may not forward the request the request to the next middleware
