using System;

namespace MethodOverLoading;

internal class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(Add(8.3m, 9.2m));

        Console.WriteLine(Add(0, 1, true));
        Console.WriteLine();

        Console.WriteLine(Add(5, 5, true));
        Console.WriteLine();

        Console.WriteLine(Add(5, 5, false));
        Console.WriteLine();
    }

    public static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static decimal Add(decimal num1, decimal num2)
    { 
        return num1 + num2; 
    }

    public static string Add(int num1, int num2, bool isTrue)
    { 
        var sum = num1 + num2;

        if (isTrue && sum > 1)
        {
            return $"{sum} dollars";
        }
        else if (isTrue && sum == 1)
        {
            return $"{sum} dollar";
        }
        else
        {
            return $"{sum}";
        }
    }
}