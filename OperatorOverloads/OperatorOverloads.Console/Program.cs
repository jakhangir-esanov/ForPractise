using OperatorOverloads.Console;

Point p1 = new Point(2, 3);
Point p2 = new Point(4, 5);

// Using overloaded + operator
Point sum = p1 + p2;
Console.WriteLine("Sum of points: " + sum.X + " " + sum.Y);

