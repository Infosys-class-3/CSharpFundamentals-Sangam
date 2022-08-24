class Patterns()
{
     internal void P1()
{
    
for (int  i = 1; i<=6; ++i )
{
    for(int j = 1; j<=i; ++j )
    {
    Console.Write("#");

    }
Console.WriteLine();

}
        Console.ReadLine();

}


  internal void P2()
    {
        for (int i = 2; i <= 6; i++)
        {
            for (int j = 1; j <i; j++)
            {
               Console. Write(j);
            }
            COnsole.WriteLine();
        }
        Console.ReadLine();
    }


    internal void P3()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= (5-i); j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k < i * 2; k++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }



    internal void P4()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= (5 - i); j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k < i * 2; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}