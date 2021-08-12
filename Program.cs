using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("input ypur natural number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write("the first {0} natural numbers are : ", input);
            for (int x = 1; x <= input; x++)
            {
                Console.Write(x + " ");

                sum += x;
            }
            Console.WriteLine("\nthe sum is : {0}", sum);




        }
    }
}