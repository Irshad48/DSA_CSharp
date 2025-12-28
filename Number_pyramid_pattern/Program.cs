for (int i = 0; i < 4; i++)
{
    for(int j=4; j>i+1; j--)
    {
         Console.Write(" ");
    }
    for(int k=1; k<=i+1; k++)
    {
        Console.Write(k);
    }
    for(int l=i; l>=1; l--)
    {   
        Console.Write(l);
    }
    Console.WriteLine();
}