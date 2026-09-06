- In older versions, we accomplish routing with individual methods- `UseRouting` and `UseEndpoints`. From version 6, Routing is automatically enabled. Framework automatically handles the routing configuration.
- Endpoints are Middleware

## Custom Route Constraint

```cs
// Step 1: Create
public class ClassName: IRouteConstraint
{
  public bool Match(HttpContext? context, IRoute? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection){
    // return true or false
  }
}

// Step 2: register
builder.Services.AddRouting(options=>{
  options.ConstraintMap.Add("name", typeof(ClassName))
});

// Step 3: Use
app.Map("student/{id:name}", ...);
```

## Endpoint Selection Order

- URL template with more segments. e.g. `a/b/c/d` is higher than `a/b/c`
- URL template with literal text has more precedence than a parameter segment. e.g. `a/b` is higher than `a/{parameter}`
- URL template that has a parameter segment with constraints has more precedence than a parameter segment without constraints. e.g. `a/{b:int}` is higher than `a/{b}`
- Catch-All parameters (**). e.g. `a/{b}` is higher than `a/**`

## WebRoot and UseStaticFiles

- The default WebRoot folder is `wwwroot`.
- You can configure manually
- `UseStaticFiles()` send the file as response
