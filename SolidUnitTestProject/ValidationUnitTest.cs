using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleResponsibilityPrinciple.Validation;

namespace SolidUnitTestProject
{
    /// <summary>
    /// Summary description for ValidationUnitTest
    /// </summary>
    [TestClass]
    public class ValidationUnitTest
    {
        [TestMethod]
        public void TestValidation()
        {
            const string email = "email@gmail.com";
            const string number = "0123456789";
            const string text = "some text";
            var validation = new SingleResponsibilityPrinciple.Validation.Validation(new ValidationText(), new ValidationEmail(), new ValidationNumber());
            validation.ValidateForm(text, text, email, number);
        }
    }
}
