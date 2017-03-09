using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class PatternMatchingKataTests
    {
        private PatternMatchingKata patternMatchingKata;

        [TestInitialize]
        public void Init() {
            patternMatchingKata = new PatternMatchingKata();
        }

        [TestMethod]
        public void Validate_IsExpression()
        {
           var result = patternMatchingKata.PatternMatchingIsExpression("Foo");
            Assert.AreEqual("FooBar", result);

        }

        [TestMethod]
        public void Validate_Switch_Matching()
        {
            var rebMoblin = new Moblin { Strength = 10, HitPoints = 25, Color = "Red" };
            var result = patternMatchingKata.PatternMatchingSwitch(rebMoblin);

            Assert.AreEqual("Red Moblin", result);

        }
    }
}
