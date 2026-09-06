using Day_07_Work_02.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Day_07_Work_02.CustomModelBinders
{
    public class PersonModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            Person person = new Person();

            // FirstName and LastName
            if (bindingContext.ValueProvider.GetValue("FirstName").Count() > 0)
            {
                person.PersonName = bindingContext.ValueProvider.GetValue("FirstName").FirstValue;

                if (bindingContext.ValueProvider.GetValue("LastName").Count() > 0)
                {
                    person.PersonName += " " + bindingContext.ValueProvider.GetValue("LastName");
                }
            }

            bindingContext.Result = ModelBindingResult.Success(person);
            return Task.CompletedTask;
        }
    }
}
