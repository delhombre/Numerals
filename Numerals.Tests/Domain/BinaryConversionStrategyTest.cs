using FluentAssertions;
using Numerals.Domain;

namespace Numerals.Tests.Domain;

public class BinaryConversionStrategyTest
{
    private readonly BinaryConversionStrategy _strategy = new();

    [Fact]
    public void ShouldConvert10Into1010()
    {
        string result = _strategy.Convert(10);
        result.Should().Be("1010");
    }

    [Fact]
    public void ShouldConvert20Into10100()
    {
        string result = _strategy.Convert(20);
        result.Should().Be("10100");
    }

    [Fact]
    public void ShouldConvert255Into11111111()
    {
        string result = _strategy.Convert(255);
        result.Should().Be("11111111");
    }

    [Fact]
    public void ShouldConvert256Into100000000()
    {
        string result = _strategy.Convert(256);
        result.Should().Be("100000000");
    }

    [Fact]
    public void ShouldConvert1024Into10000000000()
    {
        string result = _strategy.Convert(1024);
        result.Should().Be("10000000000");
    }

    [Fact]
    public void ShouldConvert934534Into11100100001010000110()
    {
        string result = _strategy.Convert(934534);
        result.Should().Be("11100100001010000110");
    }
}
