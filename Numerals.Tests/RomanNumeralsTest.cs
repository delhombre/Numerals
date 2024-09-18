using FluentAssertions;

namespace Numerals.Tests;

public class RomanNumeralsTest
{
    [Fact]
    public void ShouldConvert1IntoI()
    {
        string result = Numerals.FromArabic(1).ToRoman();
        result.Should().Be("I");
    }

    [Fact]
    public void ShouldConvert2IntoII()
    {
        string result = Numerals.FromArabic(2).ToRoman();
        result.Should().Be("II");
    }

    [Fact]
    public void ShouldConvert3IntoIII()
    {
        string result = Numerals.FromArabic(3).ToRoman();
        result.Should().Be("III");
    }

    [Fact]
    public void ShouldConvert4IntoIV()
    {
        string result = Numerals.FromArabic(4).ToRoman();
        result.Should().Be("IV");
    }

    [Fact]
    public void ShouldConvert5IntoV()
    {
        string result = Numerals.FromArabic(5).ToRoman();
        result.Should().Be("V");
    }

    [Fact]
    public void ShouldConvert6IntoVI()
    {
        string result = Numerals.FromArabic(6).ToRoman();
        result.Should().Be("VI");
    }

    [Fact]
    public void ShouldConvert9IntoIX()
    {
        string result = Numerals.FromArabic(9).ToRoman();
        result.Should().Be("IX");
    }

    [Fact]
    public void ShouldConvert10IntoX()
    {
        string result = Numerals.FromArabic(10).ToRoman();
        result.Should().Be("X");
    }

    [Fact]
    public void ShouldConvert11IntoXI()
    {
        string result = Numerals.FromArabic(11).ToRoman();
        result.Should().Be("XI");
    }

    [Fact]
    public void ShouldConvert14IntoXIV()
    {
        string result = Numerals.FromArabic(14).ToRoman();
        result.Should().Be("XIV");
    }

    [Fact]
    public void ShouldConvert19IntoXIX()
    {
        string result = Numerals.FromArabic(19).ToRoman();
        result.Should().Be("XIX");
    }

    [Fact]
    public void ShouldConvert27IntoXXVII()
    {
        string result = Numerals.FromArabic(27).ToRoman();
        result.Should().Be("XXVII");
    }

    [Fact]
    public void ShouldConvert48IntoXLVIII()
    {
        string result = Numerals.FromArabic(48).ToRoman();
        result.Should().Be("XLVIII");
    }

    [Fact]
    public void ShouldConvert59IntoLIX()
    {
        string result = Numerals.FromArabic(59).ToRoman();
        result.Should().Be("LIX");
    }

    [Fact]
    public void ShouldConvert93IntoXCIII()
    {
        string result = Numerals.FromArabic(93).ToRoman();
        result.Should().Be("XCIII");
    }

    [Fact]
    public void ShouldConvert141IntoCXLI()
    {
        string result = Numerals.FromArabic(141).ToRoman();
        result.Should().Be("CXLI");
    }

    [Fact]
    public void ShouldConvert163IntoCLXIII()
    {
        string result = Numerals.FromArabic(163).ToRoman();
        result.Should().Be("CLXIII");
    }

    [Fact]
    public void ShouldConvert402IntoCDII()
    {
        string result = Numerals.FromArabic(402).ToRoman();
        result.Should().Be("CDII");
    }

    [Fact]
    public void ShouldConvert575IntoDLXXV()
    {
        string result = Numerals.FromArabic(575).ToRoman();
        result.Should().Be("DLXXV");
    }

    [Fact]
    public void ShouldConvert911IntoCMXI()
    {
        string result = Numerals.FromArabic(911).ToRoman();
        result.Should().Be("CMXI");
    }

    [Fact]
    public void ShouldConvert1024IntoMXXIV()
    {
        string result = Numerals.FromArabic(1024).ToRoman();
        result.Should().Be("MXXIV");
    }

    [Fact]
    public void ShouldConvert3999IntoMMMCMXCIX()
    {
        string result = Numerals.FromArabic(3999).ToRoman();
        result.Should().Be("MMMCMXCIX");
    }

    [Fact]
    public void ShouldThrowExceptionWhenNumberIsZero()
    {
        Action action = () => Numerals.FromArabic(0).ToRoman();
        action.Should().Throw<ArgumentOutOfRangeException>("Number must be between 1 and 3999");
    }

    [Fact]
    public void ShouldThrowExceptionWhenNumberIsOver3999()
    {
        Action action = () => Numerals.FromArabic(4000).ToRoman();
        action.Should().Throw<ArgumentOutOfRangeException>("Number must be between 1 and 3999");
    }
}
