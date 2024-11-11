using Conversion.Console;

var obj1 = new Rational(1);
var obj2 = new Rational(2.1f);

// Using the explicit converter to get an Int32 from obj2
int intValue = (int)obj2; // Explicit conversion from Rational to Int32

// Using the explicit converter to get a Single from obj1
float floatValue = (float)obj1; // Explicit conversion from Rational to Single

// Using implicit conversion to create a Rational from an Int32
Rational obj3 = 5; // Implicitly converts Int32 to Rational

// Using implicit conversion to create a Rational from a Single
Rational obj4 = 3.5f; // Implicitly converts Single to Rational


Console.WriteLine(intValue);
Console.WriteLine(floatValue);
Console.WriteLine(obj3);
Console.WriteLine(obj4);