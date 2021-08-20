using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(4);   
        } 
        static void DrawPyramid(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int x = i; x <= n; x++)
                {
                    Console.Write("  ");
                }    
                for(int y = 1; y <= 2 * i - 1; y++)
                {
                    Console.Write("* ");
                   
                }
                Console.WriteLine();
            }
           
        }
    }
}
