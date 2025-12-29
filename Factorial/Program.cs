using System;

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
