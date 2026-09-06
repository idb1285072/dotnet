## Syntax

```cs
app.Run(async(HttpContext context)=>
{
  // code
});
```

## What?

- The extension method called `Run()` used to execute a **terminating / short-circuiting** middleware that doesn't forward the request to the next middleware.
