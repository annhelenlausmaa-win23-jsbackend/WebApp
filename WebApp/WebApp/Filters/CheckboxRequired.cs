﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Filters
{
    public class CheckboxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is bool b && b;
        }
    }
}
