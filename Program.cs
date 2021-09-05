using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Animal Sound : ");
            string animalSound = Console.ReadLine();
            
                if (animalSound == "Grr")
                {
                    Console.WriteLine("Lion ");
                }
                else if (animalSound == "Rawr")
                {
                    Console.WriteLine("Tiger ");
                }
                else if (animalSound == "Ssss")
                {
                    Console.WriteLine("Snake ");
                }
                else if (animalSound == "Chirp")
                {
                    Console.WriteLine("Bird ");
                }
            
        } 
        
    }
}
