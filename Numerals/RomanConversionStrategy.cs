using System.Text;

namespace Numerals;

public class RomanConversionStrategy : IConversionStrategy
{
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

    public string Convert(int number)
    {
        if (number < 1 || number > 3999)
        {
            throw new ArgumentOutOfRangeException();
        }

        StringBuilder result = new();
        int remaining = number;

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
