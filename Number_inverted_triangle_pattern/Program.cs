for (int i = 1; i <= 4; i++)
{
    for(int j=1; j<i; j++)
    {
        Console.Write(" ");
    }
    for(int k=4; k>=i; k--)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}
