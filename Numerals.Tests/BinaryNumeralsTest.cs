using FluentAssertions;

namespace Numerals.Tests;

public class BinaryNumeralsTest
{
    [Fact]
    public void ShouldConvert10Into1010()
    {
        string result = Numerals.FromArabic(10).ToBinary();
        result.Should().Be("1010");
    }

    [Fact]
    public void ShouldConvert20Into10100()
    {
        string result = Numerals.FromArabic(20).ToBinary();
        result.Should().Be("10100");
    }

    [Fact]
    public void ShouldConvert255Into11111111()
    {
        string result = Numerals.FromArabic(255).ToBinary();
        result.Should().Be("11111111");
    }

    [Fact]
    public void ShouldConvert256Into100000000()
    {
        string result = Numerals.FromArabic(256).ToBinary();
        result.Should().Be("100000000");
    }

    [Fact]
    public void ShouldConvert1024Into10000000000()
    {
        string result = Numerals.FromArabic(1024).ToBinary();
        result.Should().Be("10000000000");
    }

    [Fact]
    public void ShouldConvert934534Into11100100001010000110()
    {
        string result = Numerals.FromArabic(934534).ToBinary();
        result.Should().Be("11100100001010000110");
    }
}
