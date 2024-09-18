using Numerals.Domain;

namespace Numerals.Core;

public class Numeral(int arabicNumber)
{
    private readonly int _arabicNumber = arabicNumber;

    public static Numeral FromArabic(int arabic)
    {
        return new Numeral(arabic);
    }

    public string ToRoman()
    {
        RomanConversionStrategy strategy = new();
        return strategy.Convert(_arabicNumber);
    }

    public string ToHexadecimal()
    {
        HexConversionStrategy strategy = new();
        return strategy.Convert(_arabicNumber);
    }

    public string ToBinary()
    {
        BinaryConversionStrategy strategy = new();
        return strategy.Convert(_arabicNumber);
    }
}
