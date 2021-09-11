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
        } 
        
    }
}
