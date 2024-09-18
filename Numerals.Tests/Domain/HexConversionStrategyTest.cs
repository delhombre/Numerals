using FluentAssertions;
using Numerals.Domain;

namespace Numerals.Tests.Domain;

public class HexConversionStrategyTest
{
    private readonly HexConversionStrategy _strategy = new();

    [Fact]
    public void ShouldConvert10IntoA()
    {
        string result = _strategy.Convert(10);
        result.Should().Be("A");
    }

    [Fact]
    public void ShouldConvert11IntoB()
    {
        string result = _strategy.Convert(11);
        result.Should().Be("B");
    }

    [Fact]
    public void ShouldConvert255IntoFF()
    {
        string result = _strategy.Convert(255);
        result.Should().Be("FF");
    }

    [Fact]
    public void ShouldConvert256Into100()
    {
        string result = _strategy.Convert(256);
        result.Should().Be("100");
    }

    [Fact]
    public void ShouldConvert1024Into400()
    {
        string result = _strategy.Convert(1024);
        result.Should().Be("400");
    }

    [Fact]
    public void ShouldConvert2398Into95E()
    {
        string result = _strategy.Convert(2398);
        result.Should().Be("95E");
    }

    [Fact]
    public void ShouldThrowExceptionWhenNumberIsNegative()
    {
        Action action = () => _strategy.Convert(-1);
        action
            .Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be positive*");
    }
}
