using Day_07_Work_02.CustomValidators;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Day_07_Work_02.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage = "{0} cannot be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} characters long")]
        [RegularExpression("^[A-Za-z .]$", ErrorMessage = "{0} should contain only alphabets, space and dot")]
        public string? PersonName { get; set; }

        [EmailAddress(ErrorMessage = "{0} should be proper email address")]
        [Required(ErrorMessage = "{0} cannot be blank")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "{0} should contain 10 digits")]
        //[ValidateNever]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "{0} cannot be blank")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "{0} cannot be blank")]
        [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        public decimal? Price { get; set; }

        [MinimumYearValidator(2002, ErrorMessage = "Date of Birth should be never than Jan 01, {0}")]
        //[BindNever]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? FromDate { get; set; }
        [DateRangeValidator("FromDate", ErrorMessage = "'From Date' should be older than or equal to 'To Date'")]
        public DateTime? ToDate { get; set; }
        public int? Age { get; set; }
        public override string ToString()
        {
            return $"Person Name: {PersonName}, Email: {Email}, Phone: {Phone}, Password: {Password}, ConfirmPassowrd: {ConfirmPassword}, Price:{Price}";
        }

        // If no validation errors of the model class then execute the method only
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!DateOfBirth.HasValue && !Age.HasValue)
            {
                yield return new ValidationResult("Either of Date of Birth or Age must be supplied", new[] { nameof(Age) });
            }
        }
    }
}
