using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace StoreProject.Validation
{
    public class ProductNumberFormatAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            return Regex.IsMatch(value.ToString(), @"^p-\d+$");
        }

        public override string FormatErrorMessage(string name)
            => $"{name} must be preceded by 'p-' then followed by a number.";
    }
}