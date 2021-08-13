using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the No.Of Terms : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int y = input + input;
            Console.WriteLine("The Odd Numbers upto {0} are : ", input);
            int sum = 0;
            for (int x = 1; x <= y; x++)
            {
                 if (x % 2 == 1)
                {
                   Console.Write(x + " ");
                    sum += x;
                }
                
                
            }
            Console.WriteLine("\nThe Sum of Odd Numbers are : {0}", sum);

        }   
    }
}
