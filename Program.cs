using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Console.Write("Enter the No.Of Term : ");
              int input = Convert.ToInt32(Console.ReadLine());
              int square;
              int sum = 0;
              Console.Write("The Square Numbers upto {0} Terms ", input + " are :");
              for ( int x = 1; x <= input; x++)
              {
                  square = x * x;
                  Console.Write(square + " ");
                  sum += square;

              }
              Console.WriteLine("\nThe Sum of Square Numbers upto {0}", input +" Terms are :" + sum); */

            Console.Write("Enter the Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Square Numbers in {0} ", input + " are :");
            int square;
            for (int x = 1; x <= input; x++)
            {
                square = x * x;
                Math.Sqrt(square);
                Console.Write(square + " ");

            }
        }  
    }
}
