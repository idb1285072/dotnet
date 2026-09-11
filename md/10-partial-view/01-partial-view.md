```cs
<partial name="_PartialViewName" />
// Returns the content to the parent view

@await Html.PartialAsync("_PartialViewName")
// Returns the content to the parent view

@{await Html.RenderPartialAsync("_PartialViewName");}
// Streams the content to the browser
```
