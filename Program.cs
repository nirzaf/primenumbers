using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Price in Pesos : ");
            int pesos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Price in Dollars : ");
            int dollars = Convert.ToInt32(Console.ReadLine());
            int pesosInDollars = pesos / 50;
            if( dollars > pesosInDollars)
            {
                Console.WriteLine("Pesos");
            }
            else if( dollars < pesosInDollars)
            {
                Console.WriteLine("Dollars");
            }
        }  
    }
}
