# Numerals

[![Build and Test](https://github.com/delhombre/Numerals/actions/workflows/tests.yml/badge.svg)](https://github.com/delhombre/Numerals/actions/workflows/tests.yml)

## Description

This is a simple program that converts arabic based numbers to roman numerals, hexadecimal and binary.

## Installation

```bash
git clone https://github.com/delhombre/Numerals.git

cd Numerals

dotnet restore

dotnet build
```

## Usage

```csharp

string roman = Numeral.FromArabic(1234).ToRoman(); // MCCXXXIV
string hex = Numeral.FromArabic(1234).ToHex(); // 4D2
string binary = Numeral.FromArabic(1234).ToBinary(); // 10011010010

```

If you want to use a syntax like this:

```csharp

1234.ToRoman(); // MCCXXXIV
1234.ToHex(); // 4D2
1234.ToBinary(); // 10011010010

```

You can create an extension method 😜
