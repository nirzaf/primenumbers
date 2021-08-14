using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int x = 1; x <= 4; x++ )
            {
                for(int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }  
    }
}
