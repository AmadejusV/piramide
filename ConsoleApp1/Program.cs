using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num, i, j, k;
            Console.Write("enter the level:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    for (j = 1; j < num - i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {

                        Console.Write("*");
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }



            }
        }
    }
}
