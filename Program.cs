using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 0;
            for(int x = 1; x <= 4; x++)
            {
                for(int z = 1; z <= (4-x); z++)
                {
                    Console.Write(" ");
                }
                for(int y = 1; y <= x; y++)
                {
                    // number++;
                    //number++;
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }  
    }
}
