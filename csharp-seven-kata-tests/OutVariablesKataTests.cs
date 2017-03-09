using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class OutVariablesKataTests
    {
        [TestMethod]
        public void Validate_Out_Varible()
        {
            var outVariablesKata = new OutVariablesKata();
            var result = outVariablesKata.ParseInteger("1");

            Assert.AreEqual(1, result);
        }
    }
}
