- When partial view is invoked, it receives a copy of the parent view's ViewData object.
- So, any changes made in the ViewData in the partial view, do not effect the ViewData of the parent view.
- Optionally, you can supply a custom ViewData object to the partial view, if you don't want the partial view to access the entire ViewData of the parent view.

```cs
@{await Html.RenderPartialAsync("_PartialViewName", ViewData)}

<partial name="_PartialViewName" view-data="ViewData"/>
```
