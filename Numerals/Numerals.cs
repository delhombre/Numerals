using System.Text;

namespace Numerals;

public class Numerals(int arabicNumber)
{
    private readonly int _arabicNumber = arabicNumber;
    private static readonly Dictionary<int, string> _romanNumerals =
        new()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };

    public static Numerals FromArabic(int arabic)
    {
        return new Numerals(arabic);
    }

    public string ToRoman()
    {
        if (_arabicNumber < 1 || _arabicNumber > 3999)
        {
            throw new ArgumentOutOfRangeException();
        }

        StringBuilder result = new();
        int remaining = _arabicNumber;

        foreach (var (arabic, roman) in _romanNumerals.OrderByDescending(x => x.Key))
        {
            while (remaining >= arabic)
            {
                result.Append(roman);
                remaining -= arabic;
            }
        }

        return result.ToString();
    }
}
