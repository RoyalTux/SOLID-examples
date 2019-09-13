using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleResponsibilityPrinciple.Validation;

namespace SolidUnitTestProject
{
    /// <summary>
    /// Summary description for ValidationNumberUnitTest
    /// </summary>
    [TestClass]
    public class ValidationNumberUnitTest
    {
        [TestMethod]
        public void TestNumberValidation()
        {
            const string number = "0123456789";
            var validationNumber = new ValidationNumber();
            validationNumber.Validate(number);
        }
    }
}
