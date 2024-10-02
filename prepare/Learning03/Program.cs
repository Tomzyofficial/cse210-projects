using System;

class Program
{
  static void Main(string[] args)
  {
    Fraction f1 = new Fraction();
    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f1.GetDecimalValue());

    Fraction f2 = new Fraction(5);
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f2.GetDecimalValue());

    Fraction f3 = new Fraction(3, 4);
    Console.WriteLine(f3.GetFractionString());
    Console.WriteLine(f3.GetDecimalValue());

    Fraction f4 = new Fraction(1, 3);
    Console.WriteLine(f4.GetFractionString());
    Console.WriteLine(f4.GetDecimalValue());

  }
}

public class Fraction
{
  private int _numerator;
  private int _denominator;
  public Fraction()
  {
    _numerator = 1;
    _denominator = 1;
  }
  public Fraction(int numerator)
  {
    _numerator = numerator;
    _denominator = 1;
  }

  public Fraction(int numerator, int denominator)
  {
    _numerator = numerator;
    _denominator = denominator;
  }

  public int GetNumerator()
  {
    return _numerator;
  }

  public void SetNumerator(int numerator)
  {
    _numerator = numerator;
  }
  public int GetDenominator()
  {
    return _denominator;
  }

  public void SetDenominator(int denominator)
  {
    _denominator = denominator;
  }
  public string GetFractionString()
  {
    return $"{_numerator}/{_denominator}";
  }
  public double GetDecimalValue()
  {
    return (double)_numerator / _denominator;
  }
}
