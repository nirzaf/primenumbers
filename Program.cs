using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Word to Translate to Alien Language : ");
            string input = Console.ReadLine();
            Console.WriteLine(AlienLanguage(input));
        }  
        static string AlienLanguage(string input)
        {
            char[] characterArray = input.ToCharArray();
            Array.Reverse(characterArray);
            return new string(characterArray);

        }
    }
}
