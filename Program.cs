using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiple;
            Console.Write("input your number : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            for (int x = 1; x <= 10; x++)
            {
                multiple = x * input1;
                Console.WriteLine("{0} * {1} = {2}", x, input1, multiple);
            }
            Console.ReadLine();
        }  
    }
}
