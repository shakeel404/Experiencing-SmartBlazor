using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartLearning.Shared.Utility
{
    public class PassingMarksComparer: ValidationAttribute
    {
        private string CompareWith; 
        public PassingMarksComparer(string compareWith)
        {
            CompareWith = compareWith; 
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var comparingProperty = validationContext.ObjectType.GetProperty(CompareWith);

            if (comparingProperty == null)
            {
                return new ValidationResult($"Unknown Property {CompareWith}");
            }

            var compareValue = comparingProperty.GetValue(validationContext.ObjectInstance, null);

            var comparer = (int)value;
            var compareTo = (int)compareValue; 

            if (comparer > compareTo)
            {
                return new ValidationResult($"{validationContext.DisplayName} marks cannot be greater then Allowed Marks", new []{validationContext.MemberName});
            }
            else
            {
                return ValidationResult.Success;
            }

        }

    }
}
