using System;

namespace SingleResponsibilityPrinciple.Validation
{
    internal class ValidationEmail
    {
        public void Validate(string emailField)
        {
            if (!emailField.Contains("@") || !emailField.Contains("."))
            {
                throw new Exception("The email is invalid!");
            }
        }
    }
}