using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App1.Attribute
{
    public class TextValidatorAttribute : ValidationAttribute
    {
        public TextValidatorAttribute(int maxWords) : base("输入的字符请保证在{0}之内...")
        {
            MaxWords = maxWords;
        }

        public int MaxWords { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value?.ToString().Length > MaxWords)
            {
                return new ValidationResult(string.Format(context.DisplayName, MaxWords));
            }
            return ValidationResult.Success;
        }
    }
}