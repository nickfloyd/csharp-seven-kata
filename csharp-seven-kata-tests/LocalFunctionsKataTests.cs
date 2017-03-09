using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;
using System.Collections.Generic;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class LocalFunctionsKataTests
    {
        [TestMethod]
        public void Validate_Local_Functions()
        {
            var localFunctionsKata = new LocalFunctionsKata();

            var widgets = localFunctionsKata.ManufactureWidgets();

            Assert.AreEqual(10, widgets.Count);
        }

    }
}
