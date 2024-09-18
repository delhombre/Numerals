using FluentAssertions;
using Numerals.Core;

namespace Numerals.Tests.Core;

public class NumeralsTest
{
    [Fact]
    public void ShouldConvert10IntoA()
    {
        string result = Numeral.FromArabic(10).ToHexadecimal();
        result.Should().Be("A");
    }

    [Fact]
    public void ShouldConvert10Into1010()
    {
        string result = Numeral.FromArabic(10).ToBinary();
        result.Should().Be("1010");
    }

    [Fact]
    public void ShouldConvert10IntoX()
    {
        string result = Numeral.FromArabic(10).ToRoman();
        result.Should().Be("X");
    }
}
