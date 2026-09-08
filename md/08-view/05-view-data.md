## What?

- ViewData is a dictionary object that is automatically created up on receiving a request and will be automatically deleted before sending response to the client.
- It is mainly used to send data from controller to view
- ViewData is a property of `Microsoft.AspNetCore.Mvc.Controller` class and `Microsoft.Asp.NetCore.Mvc.Razor.RazorPage` class
- It is of `Microsoft.AspNet.Mvc.ViewFeatures.ViewDataDictionary` type
- It is derived from `IDictionary<KeyValuePair<string, object>>` type. That means, it acts as a dictionary of key/value pairs.
  - Key is of `string` type.
  - Value is of `object` type.
