using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Day_07_Work_02.CustomValidators
{
    public class DateRangeValidator : ValidationAttribute
    {
        public string OtherPropertyName { get; set; }

        public DateRangeValidator(string otherPropertyName)
        {
            OtherPropertyName = otherPropertyName;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime toDate = Convert.ToDateTime(value);
                PropertyInfo? otherProperty = validationContext.ObjectType.GetProperty(OtherPropertyName);
                if (otherProperty != null)
                {
                    DateTime fromDate = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));

                    if (fromDate > toDate)
                    {
                        return new ValidationResult(ErrorMessage, new string[] { OtherPropertyName, validationContext.MemberName });
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return null;
        }
    }
}
