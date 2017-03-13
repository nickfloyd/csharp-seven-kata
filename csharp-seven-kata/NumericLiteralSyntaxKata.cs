using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#numeric-literal-syntax-improvements
     Misreading numeric constants can make it harder to understand code when reading it for the first time. 
     This often occurs when those numbers are used as bit masks or other symbolic rather than numeric values. 
     C# 7 includes two new features to make it easier to write numbers in the most readable fashion for the intended use: binary literals, and digit separators.
     For those times when you are creating bit masks, or whenever a binary representation of a number makes the most readable code, write that number in binary.
     */
    public class NumericLiteralSyntax
    {
        // KATA: Write the following ints from their respective format to a binary literal format
        // Note: Make sure to use the '0b' at the beginning of the constant value
        // Note: The digit separator can be used with decimal, float and double types

        public const int OneDecimalFormat = 0b00000001;
        public const int TwoDecimalFormat = 0b00000010;
        public const int FourDecimalFormat = 0b00000100;
        public const int EightDecimalFormat = 0b00001000;
        public const int SixteenDecimalFormat = 0b00010000;
        public const int ThirtyTwoDecimalFormat = 0b00100000;
        public const int SixtyFourDecimalFormat = 0b01000000;

        public const int OneHexFormat = 0b00000001;
        public const int TwoHexFormat = 0b00000010;
        public const int FourHexFormat = 0b00000100;
        public const int EightHexFormat = 0b00001000;
        public const int SixteenHexFormat = 0b00010000;
        public const int ThirtyTwoHexFormat = 0b00100000;
        public const int SixtyFourHexFormat = 0b01000000;

        public const int OneBitShiftFormat = 0b00000001;
        public const int TwoBitShiftFormat = 0b00000010;
        public const int FourBitShiftFormat = 0b00000100;
        public const int EightBitShiftFormat = 0b00001000;
        public const int SixteenBitShiftFormat = 0b00010000;
        public const int ThirtyTwoBitShiftFormat = 0b00100000;
        public const int SixtyFourBitShiftFormat = 0b01000000;

        // KATA: Convert the long.MaxValue to a decimal representation using the "digit separator"
        public const long LongMaxValue = 9_223_372_036_854_775_807; //9,223,372,036,854,775,807

        // KATA: Convert the 100000000 to a decimal representation using the "digit separator"
        public const int OneMillionDollars = 1_000_000;

    }
}
