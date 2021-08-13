using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the No.Of Terms : ");
            OddNumbers odd = new OddNumbers();
            odd.input = Convert.ToInt32(Console.ReadLine());

            odd.PrintOddNumbers();
            //int input = Convert.ToInt32(Console.ReadLine());
            //int y = input + input;
            //Console.WriteLine("The Odd Numbers upto {0} are : ", input);
            //int sum = 0;
            //for (int x = 1; x <= y; x++)
            //{
            //    if (x % 2 == 1)
            //    {
            //        Console.Write(x + " ");
            //        sum += x;
            //    }            
            //}
            //Console.WriteLine("\nThe Sum of Odd Numbers are : {0}", sum);

        }

        public class OddNumbers 
        { 
            public int input { get; set; }

            public void PrintOddNumbers()
            {
                Console.WriteLine("Enter your input: ");

                int oddNumbers = 1;
                int sum = 0;

                for (int i = 1; i <= input; i++)
                {
                    sum += oddNumbers;
                    Console.Write(oddNumbers + ", ");
                    oddNumbers += 2;
                }

                Console.WriteLine("\n Sum of all odd numbers : {0}" , sum);
            }
                    
        }
    }
}
