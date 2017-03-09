using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class ThrowExpressionsKataTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "")]
        public void Validate_Property_Exception_Throw()
        {
           var throwExpressionsKata = new ThrowExpressionsKata()
            {
                PropertyException = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "")]
        public void Validate_Initialization_Exception_Throw()
        {
           var throwExpressionsKata = new ThrowExpressionsKata();
        }
    }
}
