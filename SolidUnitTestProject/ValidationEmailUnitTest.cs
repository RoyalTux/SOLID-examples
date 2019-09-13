using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleResponsibilityPrinciple.Validation;

namespace SolidUnitTestProject
{
    /// <summary>
    /// Summary description for ValidationEmailUnitTest
    /// </summary>
    [TestClass]
    public class ValidationEmailUnitTest
    {
        [TestMethod]
        public void TestEmailValidation()
        {
            const string email = "email@gmail.com";
            var validationEmail = new ValidationEmail();
            validationEmail.Validate(email);
        }
    }
}
