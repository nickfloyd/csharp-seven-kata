using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class LocalReferencesKataTests
    {
        [TestMethod]
        public void Validate_Local_References()
        {
            const string message = "the more you know";

            var localReferencesKata = new LocalReferencesKata();
            localReferencesKata.SetMessage(message);

            var shootingStar = localReferencesKata.GetShootingStar();
            Assert.AreEqual(message, shootingStar.ToString());
        }
    }
}
