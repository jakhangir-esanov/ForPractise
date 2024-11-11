namespace Conversion.Console;

public sealed class Rational
{
    private int numerator;
    private int denominator;

    // Constructs a Rational from an Int32 (integer), setting denominator to 1
    public Rational(int num)
    {
        numerator = num;
        denominator = 1;
    }

    // Constructs a Rational from a Single (floating-point), approximating as a fraction
    public Rational(float num)
    {
        // Approximate the floating-point as a fraction
        // For simplicity, we'll assume two decimal places and scale up by 100
        denominator = 100;
        numerator = (int)(num * denominator);
        Simplify();
    }

    // Convert a Rational to an Int32 by performing integer division
    public int ToInt32()
    {
        return numerator / denominator;
    }

    // Convert a Rational to a Single by performing float division
    public float ToSingle()
    {
        return (float)numerator / denominator;
    }

    // Implicitly converts an Int32 to a Rational
    public static implicit operator Rational(int num)
    {
        return new Rational(num);
    }

    // Implicitly converts a Single to a Rational
    public static implicit operator Rational(float num)
    {
        return new Rational(num);
    }

    // Explicitly converts a Rational to an Int32
    public static explicit operator int(Rational r)
    {
        return r.ToInt32();
    }

    // Explicitly converts a Rational to a Single
    public static explicit operator float(Rational r)
    {
        return r.ToSingle();
    }

    // Helper method to simplify the fraction by finding the GCD
    private void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    // Helper method to calculate the Greatest Common Divisor (GCD)
    private static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
