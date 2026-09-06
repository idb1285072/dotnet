## What?

- Controller is a class that is used to group-up a set of actions (or action methods)

## How?

- Controller after ClassName like HomeController
- Register in Program.cs file. `builder.Services.AddControllers();`
- Route `app.MapControllers();`

## Creating Controllers

- Should be either or both:
  - The class name should be suffixed with Controller. e.g. HomeController
  - The `[Controller]` attribute is applied to the same class or to its base class
- Optional:
  - Is a public class
  - Inherited from `Microsoft.AspNetCore.Mvc.Controller`
- Enable routing in Controllers
  - `builder.Services.AddControllers();`
  - `app.MapControllers();`

```cs
[Controller]
class ClassNameController
{
  // action methods here
}
```

## Responsibility of Controllers

- Reading Requests
- Validation
- Invoking Models
- Preparing Response

## ContentResult

## JsonResult

- JsonResult can represent an object in JavaScript Object Notation (JSON) format.

## FileResult

- File result sends the content of a file as response. e.g. pdf file, txt file, exe file, zip file etc.

## 3 Types of FileResult

- `VirtualFileResult("fileRelativePath", "contentType")`
- `PhysicalFileResult("fileAbsolutePath", "contentType")`
- `FileContentResult(byte_array, "contentType")`

## IActionResult

- It is the parent interface for all action result classes such as ContentResult, JsonResult, RedirectResult, StatusCodeResult, ViewResult etc.
- By mentioning the return type as IActionResult, you can return either of the subtypes of IActionResult

## StatusCodeResult

- `return new StatusCodeResult(status_code)`
- `return new UnauthorizedResult();`
- `return new BadRequest();`
- `return new NotFoundResult()`

## RedirectResult

- Redirect result sends either HTTP 302 or 301 response to the browser, in order to redirect to a specific action or url. e.g. redirect from action1 to action2

```cs
return new RedirectToActionResult("action", "controller", new {route_value}, permanent);

return new LocalRedirectResult("local_url", permanent);

return new RedirectResult("url", permanent);
```
