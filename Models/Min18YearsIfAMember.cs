using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movie_Store_MVC_5.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.DateOfBirth == null)
                return new ValidationResult("Date of birth is required");

            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;
            return (age >= 18)
                 ? ValidationResult.Success
                 : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }
    }
}