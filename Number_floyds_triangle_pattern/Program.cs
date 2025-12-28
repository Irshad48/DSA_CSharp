int num = 1;
for(int i=0; i<4; i++)
{
    for(int j=i; j>=0; j--)
    {
        Console.Write(num+" ");
        num++;
    }
    Console.WriteLine();
}