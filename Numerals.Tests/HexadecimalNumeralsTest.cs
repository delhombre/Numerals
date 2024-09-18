using FluentAssertions;

namespace Numerals.Tests;

public class HexadecimalNumeralsTest
{
    [Fact]
    public void ShouldConvert10IntoA()
    {
        string result = Numerals.FromArabic(10).ToHexadecimal();
        result.Should().Be("A");
    }

    [Fact]
    public void ShouldConvert11IntoB()
    {
        string result = Numerals.FromArabic(11).ToHexadecimal();
        result.Should().Be("B");
    }

    [Fact]
    public void ShouldConvert255IntoFF()
    {
        string result = Numerals.FromArabic(255).ToHexadecimal();
        result.Should().Be("FF");
    }

    [Fact]
    public void ShouldConvert256Into100()
    {
        string result = Numerals.FromArabic(256).ToHexadecimal();
        result.Should().Be("100");
    }

    [Fact]
    public void ShouldConvert1024Into400()
    {
        string result = Numerals.FromArabic(1024).ToHexadecimal();
        result.Should().Be("400");
    }

    [Fact]
    public void ShouldConvert2398Into95E()
    {
        string result = Numerals.FromArabic(2398).ToHexadecimal();
        result.Should().Be("95E");
    }

    [Fact]
    public void ShouldThrowExceptionWhenNumberIsNegative()
    {
        Action action = () => Numerals.FromArabic(-1).ToHexadecimal();
        action
            .Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be positive*");
    }
}
