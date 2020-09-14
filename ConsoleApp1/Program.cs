using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int i, k, j;
            Console.WriteLine("Enter the length of the longest wanted starline:");
            int num = int.Parse(Console.ReadLine());

            for(i = 1; i<=num; num--)
            {
                if(num % 2 != 0)
                {
                    for(j=1; j<num; j++)
                    {
                        Console.Write(" ");
                    }
                    for(k=1; k<=num-i+1; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }

                
                

            
        }
    }
}
