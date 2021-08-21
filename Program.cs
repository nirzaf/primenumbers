using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
              Demo a = new(50, 50);
              Demo b = a;
              a.x = 100;
              Console.WriteLine("Value of a.x = " + a.x);
              Console.WriteLine("Value of b.x = " + b.x);
        }  
    }

    //creating structure
    public struct Demo
    {
        public int x, y;
        //parameterized constructor
        public Demo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
