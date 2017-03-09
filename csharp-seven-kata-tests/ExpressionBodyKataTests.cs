using csharp_seven_kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class ExpressionBodyKataTests
    {
        [TestMethod]
        public void Validate_ExpressionBody()
        {
            var expressionBodyKata = new  ExpressionBodyKata("Something");

            Assert.AreEqual("Something", expressionBodyKata.ExpressionBody);
        }
    }
}
