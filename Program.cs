using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Total No.Of Criminals Present : ");
            int criminals = Convert.ToInt32(Console.ReadLine());
            if (criminals < 5)
            {
                Console.WriteLine("I got this!");
            }
            else if (criminals <= 10)
            {
                Console.WriteLine("Help me Batman");
            }
            else
            {
                Console.WriteLine("Good Luck out there!");
            }

        } 
        
       
    }
}
