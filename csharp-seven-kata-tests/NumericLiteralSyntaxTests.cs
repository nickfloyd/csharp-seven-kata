using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class NumericLiteralSyntaxTests
    {
        [TestMethod]
        public void Validate_Decimal_Formats()
        {
            Assert.AreEqual(0b00000001, NumericLiteralSyntax.OneDecimalFormat);
            Assert.AreEqual(0b00000010, NumericLiteralSyntax.TwoDecimalFormat);
            Assert.AreEqual(0b00000100, NumericLiteralSyntax.FourDecimalFormat);
            Assert.AreEqual(0b00001000, NumericLiteralSyntax.EightDecimalFormat);
            Assert.AreEqual(0b00010000, NumericLiteralSyntax.SixteenDecimalFormat);
            Assert.AreEqual(0b00100000, NumericLiteralSyntax.ThirtyTwoDecimalFormat);
            Assert.AreEqual(0b01000000, NumericLiteralSyntax.SixtyFourDecimalFormat);
        }

        [TestMethod]
        public void Validate_Hex_Formats()
        {
            Assert.AreEqual(0b00000001, NumericLiteralSyntax.OneHexFormat);
            Assert.AreEqual(0b00000010, NumericLiteralSyntax.TwoHexFormat);
            Assert.AreEqual(0b00000100, NumericLiteralSyntax.FourHexFormat);
            Assert.AreEqual(0b00001000, NumericLiteralSyntax.EightHexFormat);
            Assert.AreEqual(0b00010000, NumericLiteralSyntax.SixteenHexFormat);
            Assert.AreEqual(0b00100000, NumericLiteralSyntax.ThirtyTwoHexFormat);
            Assert.AreEqual(0b01000000, NumericLiteralSyntax.SixtyFourHexFormat);
        }

        [TestMethod]
        public void Validate_Bit_Shift_Formats()
        {
            Assert.AreEqual(0b00000001, NumericLiteralSyntax.OneBitShiftFormat);
            Assert.AreEqual(0b00000010, NumericLiteralSyntax.TwoBitShiftFormat);
            Assert.AreEqual(0b00000100, NumericLiteralSyntax.FourBitShiftFormat);
            Assert.AreEqual(0b00001000, NumericLiteralSyntax.EightBitShiftFormat);
            Assert.AreEqual(0b00010000, NumericLiteralSyntax.SixteenBitShiftFormat);
            Assert.AreEqual(0b00100000, NumericLiteralSyntax.ThirtyTwoBitShiftFormat);
            Assert.AreEqual(0b01000000, NumericLiteralSyntax.SixtyFourBitShiftFormat);
        }

        [TestMethod]
        public void Validate_Long_Max_Value()
        {
            Assert.AreEqual(long.MaxValue, NumericLiteralSyntax.LongMaxValue);
        }

        [TestMethod]
        public void Validate_OneMillionDollars()
        {
            Assert.AreEqual(1_000_000, NumericLiteralSyntax.OneMillionDollars);
        }
    }
}
