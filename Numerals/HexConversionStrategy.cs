namespace Numerals;

public class HexConversionStrategy : IConversionStrategy
{
    public string Convert(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be positive");
        }

        return number.ToString("X");
    }
}
