using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webAppCust.Models
{
    public class TargetNum : ValidationAttribute
    {
        private readonly int _maxLength;

        public TargetNum(int maxLength)
        {
            _maxLength = maxLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stringValue = value as string;

            if (stringValue != null && stringValue.Length != _maxLength)
            {
                return new ValidationResult($"The length of {validationContext.DisplayName} should not exceed {_maxLength} characters.");
            }

            return ValidationResult.Success;
        }
    }
}