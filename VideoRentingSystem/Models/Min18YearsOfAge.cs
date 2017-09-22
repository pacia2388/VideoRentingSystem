using System;
using System.ComponentModel.DataAnnotations;

namespace VideoRentingSystem.Models
{
    public class Min18YearsOfAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is Required.");

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year -
                      ((DateTime.Today.Month > customer.BirthDate.Value.Month) ? 1
                      : (DateTime.Today.Day > customer.BirthDate.Value.Day ? 1 : 0));
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership. ");
        }
    }
}