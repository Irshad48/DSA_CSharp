for(int i=0; i<4; i++)
{
    for(int j=0; j<i+1; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < 4 - (i + 1); j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 4 - (i + 1); j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < (i + 1); j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4 - i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 4 - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}