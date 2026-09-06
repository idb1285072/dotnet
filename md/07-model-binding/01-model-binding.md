## What?

- Model Binding is feature of asp.net core that reads values from http requests and pass them as arguments to the action method.

## From Where?

- Form Fields - `x-www-form-urlencoded` and `form-data`
- Request Body
- Route Data - `/{param1}/{param2}`
- Query String Parameters - `?param1=value1&param2=value2`

## Models

- Model is a class than represents structure of data (as properties) that you would like to receive from the request and/or send to the response
- also known as **POCO** (Plain Old CLR Objects)

## Model Validation

```cs
class ClassName
{
  [Attribute]
  public type PropertyName {get; set;}
}

[Required(ErrorMessage="value")]
[StringLength(int maximumLength, MinimumLength=value,ErrorMessage="value")]
[Range(int minimum, int maximum, ErrorMessage="value")]
[RegularExpression(string pattern, ErrorMessage="value")]
[EmailAddress(ErrorMessage="value")]
[Phone(ErrorMessage="value")]
[Compare(string otherProperty, ErrorMessage="value")]
[Url(ErrorMessage="value")]
[ValidateNever]
```

> HTTP Request -> Model Binding -> Model Validation -> Controllers

## ModelState

- `IsValid`: Specifies whether there is at least one validation error or not (true or false)
- `Values`: Contains each model property value with corresponding Errors property that contains list of validation errors of that model property
- `ErrorCount`: Returns number of errors

## Custom Validation

```cs
class ClassName : ValidationAttribute
{
  public override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    // return ValidationResult.Success;
    // [or] return new ValidationResult("error message");
  }
}
```

## `IValidatableObject`

```cs
class ClassName:IValidatableObject
{
  // model properties here
  public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
  {
    if(condition){
      yield return new ValidationResult("error message");
    }
  }
}
```

## `[Bind]` and `[BindNever]`

- `[Bind]` attribute specifies that only the specified properties should be included in model binding
- Prevents over-posting (post values into unexpected properties) especially in Create scenarios

```cs
class ClassNameController: Controller
{
  public IActionResult ActionMethodName([Bind(nameof(ClassName.PropertyName), nameof(ClassName.PropertyName))] ClassName parameterName)
}
```

## Custom Model Binder

```cs
class ClassName: IModelBinder
{
  public Task BindModelAsync(ModelBindingContext bindingContext)
  {
    // gets value from request
    bindingContext.ValueProvider.GetValue("FirstName");

    // returns model object after reading data from the request
    bindingContext.Result = ModelBindingResult.Success(yourObject)
  }
}
```

## Custom Model Binder Provider

```cs
class ClassName: IModelBinderProvider
{
  public IModelBinder GetBinder(ModelBinderProviderContext providerContext)
  {
    // return type of custom model binder class to be invoked
    return new BinderTypeModelBinder(typeof(YourModelBinderClassName));
  }
}
```
