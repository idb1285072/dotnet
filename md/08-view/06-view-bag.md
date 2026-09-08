## What?

- ViewBag is a property of `Microsoft.AspNetCore.Mvc.Controller` class and `Microsoft.AspNetCore.Mvc.Razor.RazorPageBase` class
- It is of `dynamic` type
- The dynamic type similar to var keyword. But it checks the datatype and at run time, rather than at compilation time
- If you try to access a non-existing property in the ViewBag, it return null.

## Benefits of ViewBag over ViewData

- ViewBag's syntax is easier to access its properties than ViewData. e.g. `ViewBag.property` [vs] `ViewData["key"]`
- You need not type-cast the values while reading it. e.g. `ViewBag.objectName.property` [vs] `(ViewData["Key"] as ClassName).Property`
