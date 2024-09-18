using System.Text;

namespace Numerals;

public class Numerals(int arabicNumber)
{
    private readonly int _arabicNumber = arabicNumber;

    public static Numerals FromArabic(int arabic)
    {
        return new Numerals(arabic);
    }

    public string ToRoman()
    {
        RomanConversionStrategy strategy = new();
        return strategy.Convert(_arabicNumber);
    }
}
