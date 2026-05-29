using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine()!;

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine()!);

        double result = op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : throw new DivideByZeroException(),
            _ => throw new InvalidOperationException("Unknown operator")
        };

        Console.WriteLine($"Result: {result}");
    }
}