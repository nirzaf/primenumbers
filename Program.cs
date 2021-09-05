using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Points you Scored from Playing : ");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cost of the Squirt Gun (in tickets) : ");
            int squirtGun = Convert.ToInt32(Console.ReadLine());
            int tickets = points / 12;
            if(squirtGun <= tickets)
            {
                Console.WriteLine("Buy it!");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }  
    }
}
