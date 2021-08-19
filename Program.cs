using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Multiply(ref x);
            Console.WriteLine(x);
        }

        private static void Multiply(ref int a)
        {
            a *= a;
        }
    }
}
