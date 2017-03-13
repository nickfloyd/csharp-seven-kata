using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#numeric-literal-syntax-improvements
     * Misreading numeric constants can make it harder to understand code when reading it for the first time.
     * This often occurs when those numbers are used as bit masks or other symbolic rather than numeric values.
     * C# 7 includes two new features to make it easier to write numbers in the most readable fashion for the intended use: binary literals, and digit separators.
     * For those times when you are creating bit masks, or whenever a binary representation of a number makes the most readable code, write that number in binary.
     */
    public class NumericLiteralSyntax
    {
        // KATA: Write the following ints from their respective format to a binary literal format
        // Note: Make sure to use the '0b' at the beginning of the constant value
        // Note: The digit separator can be used with decimal, float and double types

        public const int OneDecimalFormat = 1;
        public const int TwoDecimalFormat = 2;
        public const int FourDecimalFormat = 4;
        public const int EightDecimalFormat = 8;
        public const int SixteenDecimalFormat = 16;
        public const int ThirtyTwoDecimalFormat = 32;
        public const int SixtyFourDecimalFormat = 64;

        public const int OneHexFormat = 0x01;
        public const int TwoHexFormat = 0x02;
        public const int FourHexFormat = 0x04;
        public const int EightHexFormat = 0x08;
        public const int SixteenHexFormat = 0x10;
        public const int ThirtyTwoHexFormat = 0x20;
        public const int SixtyFourHexFormat = 0x40;

        public const int OneBitShiftFormat = 1 << 0;
        public const int TwoBitShiftFormat = 1 << 1;
        public const int FourBitShiftFormat = 1 << 2;
        public const int EightBitShiftFormat = 1 << 3;
        public const int SixteenBitShiftFormat = 1 << 4;
        public const int ThirtyTwoBitShiftFormat = 1 << 5;
        public const int SixtyFourBitShiftFormat = 1 << 6;

        // KATA: Convert the long.MaxValue to a decimal representation using the "digit separator"
        public const long LongMaxValue = long.MaxValue; //9,223,372,036,854,775,807

        // KATA: Convert the 100000000 to a decimal representation using the "digit separator"
        public const int OneMillionDollars = 1000000;

    }
}
