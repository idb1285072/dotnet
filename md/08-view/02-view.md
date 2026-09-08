## What?

- View is a web page (.cshtml) that is responsible for containing presentation logic that merges data along with static design code


## Rule

- View contains HTML markup with Razor markup (C# code in view to render dynamic content)
- View is NOT supposed to have lots of C# code. Any code written in the view should relate to presenting the content (presentation logic)
- Razor is the view engine that defines syntax to write C# code in the view. `@` is the syntax of Razor syntax.
- View should neither directly call the business model, nor call the controller's action methods. But it can send requests to controllers.
