using System.Text;

namespace Numerals.Domain;

public class BinaryConversionStrategy : IConversionStrategy
{
    public string Convert(int number)
    {
        StringBuilder result = new();
        while (number > 0)
        {
            result.Insert(0, number % 2);
            number /= 2;
        }

        return result.ToString();
    }
}
