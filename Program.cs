using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Multiply(ref x);
            //Console.WriteLine("Reference Type Variable : {0}", x);
            int q, w;
            Deduction(out q, out w);
            Console.WriteLine(q + "  " + w);
        }

        private static void Multiply(ref int a)
        {
            a *= a;
        }

        private static void Deduction(out int a, out int b)
        {
            a = 5;
            b = 50;
        }
    }
}
