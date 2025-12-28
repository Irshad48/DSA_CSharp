char ch = 'A';
for(int i=0; i<4; i++)
{
    for(int j=i; j>=0; j--)
    {
        Console.Write(ch++);
    }
    Console.WriteLine();
}
