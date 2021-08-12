using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("input your number : ");
            MultiplicationTable mt = new();

            mt.input = Convert.ToInt32(Console.ReadLine());         
            mt.PrintNumbers();
            MultiplicationTable mt2 = new();

            mt2.input = mt.Calculate();
            Console.WriteLine("Calculated value {0}", mt.Calculate());
            mt2.PrintNumbers();

            //Console.ReadLine();
        }

        public class MultiplicationTable
        {
            public int input;
            private int multiple;

            public void PrintNumbers()
            {
                for (int x = 1; x <= 10; x++)
                {
                    multiple = x * input;
                    Console.WriteLine("{0} * {1} = {2}", x, input, multiple);
                }
            }

            public int Calculate()
            {
                return input * 5;
            }
        }

    }
}
