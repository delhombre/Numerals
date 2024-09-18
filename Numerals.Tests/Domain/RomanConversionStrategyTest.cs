using FluentAssertions;
using Numerals.Domain;

namespace Numerals.Tests.Domain;

public class RomanConversionStrategyTest
{
    private readonly RomanConversionStrategy _strategy = new();

    [Fact]
    public void ShouldConvert1IntoI()
    {
        string result = _strategy.Convert(1);
        result.Should().Be("I");
    }

    [Fact]
    public void ShouldConvert2IntoII()
    {
        string result = _strategy.Convert(2);
        result.Should().Be("II");
    }

    [Fact]
    public void ShouldConvert3IntoIII()
    {
        string result = _strategy.Convert(3);
        result.Should().Be("III");
    }

    [Fact]
    public void ShouldConvert4IntoIV()
    {
        string result = _strategy.Convert(4);
        result.Should().Be("IV");
    }

    [Fact]
    public void ShouldConvert5IntoV()
    {
        string result = _strategy.Convert(5);
        result.Should().Be("V");
    }

    [Fact]
    public void ShouldConvert6IntoVI()
    {
        string result = _strategy.Convert(6);
        result.Should().Be("VI");
    }

    [Fact]
    public void ShouldConvert9IntoIX()
    {
        string result = _strategy.Convert(9);
        result.Should().Be("IX");
    }

    [Fact]
    public void ShouldConvert10IntoX()
    {
        string result = _strategy.Convert(10);
        result.Should().Be("X");
    }

    [Fact]
    public void ShouldConvert11IntoXI()
    {
        string result = _strategy.Convert(11);
        result.Should().Be("XI");
    }

    [Fact]
    public void ShouldConvert14IntoXIV()
    {
        string result = _strategy.Convert(14);
        result.Should().Be("XIV");
    }

    [Fact]
    public void ShouldConvert19IntoXIX()
    {
        string result = _strategy.Convert(19);
        result.Should().Be("XIX");
    }

    [Fact]
    public void ShouldConvert27IntoXXVII()
    {
        string result = _strategy.Convert(27);
        result.Should().Be("XXVII");
    }

    [Fact]
    public void ShouldConvert48IntoXLVIII()
    {
        string result = _strategy.Convert(48);
        result.Should().Be("XLVIII");
    }

    [Fact]
    public void ShouldConvert59IntoLIX()
    {
        string result = _strategy.Convert(59);
        result.Should().Be("LIX");
    }

    [Fact]
    public void ShouldConvert93IntoXCIII()
    {
        string result = _strategy.Convert(93);
        result.Should().Be("XCIII");
    }

    [Fact]
    public void ShouldConvert141IntoCXLI()
    {
        string result = _strategy.Convert(141);
        result.Should().Be("CXLI");
    }

    [Fact]
    public void ShouldConvert163IntoCLXIII()
    {
        string result = _strategy.Convert(163);
        result.Should().Be("CLXIII");
    }

    [Fact]
    public void ShouldConvert402IntoCDII()
    {
        string result = _strategy.Convert(402);
        result.Should().Be("CDII");
    }

    [Fact]
    public void ShouldConvert575IntoDLXXV()
    {
        string result = _strategy.Convert(575);
        result.Should().Be("DLXXV");
    }

    [Fact]
    public void ShouldConvert911IntoCMXI()
    {
        string result = _strategy.Convert(911);
        result.Should().Be("CMXI");
    }

    [Fact]
    public void ShouldConvert1024IntoMXXIV()
    {
        string result = _strategy.Convert(1024);
        result.Should().Be("MXXIV");
    }

    [Fact]
    public void ShouldConvert3999IntoMMMCMXCIX()
    {
        string result = _strategy.Convert(3999);
        result.Should().Be("MMMCMXCIX");
    }

    [Fact]
    public void ShouldThrowExceptionWhenNumberIsZero()
    {
        Action action = () => _strategy.Convert(0);
        action.Should().Throw<ArgumentOutOfRangeException>("Number must be between 1 and 3999");
    }

    [Fact]
    public void ShouldThrowExceptionWhenNumberIsOver3999()
    {
        Action action = () => _strategy.Convert(4000);
        action.Should().Throw<ArgumentOutOfRangeException>("Number must be between 1 and 3999");
    }
}
