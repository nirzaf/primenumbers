using System;
using System.Collections.Generic;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Animal Sound : ");
            string animalSound = Console.ReadLine();
            animalSound = animalSound.Replace("Grr", "Lion");
            animalSound = animalSound.Replace("Rawr", "Tiger");
            animalSound = animalSound.Replace("Ssss", "Snake");
            animalSound = animalSound.Replace("Chirp", "Bird");
            Console.WriteLine(animalSound);

            Console.Write("Enter the Animal Sound : ");
            string animalSound = Console.ReadLine();
            var data = animalSound.Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Contains("Grr"))
                {
                    Console.Write("Lion ");
                }
                if (data[i].Contains("Rawr"))
                {
                    Console.Write("Tiger ");
                }
                if (data[i].Contains("Ssss"))
                {
                    Console.Write("Snake ");
                }
                if (data[i].Contains("Chirp"))
                {
                    Console.Write("Bird ");
                }
            }
        } 
        
    }
}
