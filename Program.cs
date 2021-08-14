using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (int x = 1; x <= 4; x++)
            {
                for(int y = 1; y <= x; y++)
                {
                    number++;
                    Console.Write(number);
                   
                }
                Console.WriteLine();
            }
        }  
    }
}
