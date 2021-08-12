using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Your Input");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n All primae numbers within your input value \n");
            for (int x = 2; x < input; x++)
            {

                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.WriteLine(x);
            }
            Console.ReadKey();
        }  
    }
}
