using System;
using System.Diagnostics.Metrics;

class Factorial
{
    public static int CalculateFactorial(int Number)
    {
        int factorial = 1;
        if(Number < 0)
        {
            throw new ArgumentException("Number must be non-negative");
        }
        for (int i = 1; i <= Number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    /// <summary>
    /// Explaination: This method calculates the factorial of a number using recursion.
    /// Each call creates a stack frame:
    /// f(4) → waiting for f(3)
    /// f(3) → waiting for f(2)
    /// f(2) → waiting for f(1)
    /// f(1) → returns 1

    /// After f(1) returns:
    /// f(2) resumes → returns 2
    /// f(3) resumes → returns 6
    /// f(4) resumes → returns 24

    public static int CalculateFactorialRecursive(int Number)
    {
        if(Number < 0)
        {
            throw new ArgumentException("Number must be non-negative");
        }
        if (Number <= 1)
        {
            return 1;
        }
        return Number * CalculateFactorialRecursive(Number - 1);
    }
}

class Program
{
    public static void Main()
    {
        int number = 5;
        int resultIterative = Factorial.CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} (Iterative): {resultIterative}");
        int resultRecursive = Factorial.CalculateFactorialRecursive(number);
        Console.WriteLine($"Factorial of {number} (Recursive): {resultRecursive}");
    }
}
