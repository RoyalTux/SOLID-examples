using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleResponsibilityPrinciple.Validation;

namespace SolidUnitTestProject
{
    /// <summary>
    /// Summary description for ValidationTextUnitTest
    /// </summary>
    [TestClass]
    public class ValidationTextUnitTest
    {
        [TestMethod]
        public void TestTextValidation()
        {
            const string text = "some text";
            var validationText = new ValidationText();
            validationText.Validate(text);
        }
    }
}
