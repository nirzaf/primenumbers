using System;
using System.Text;

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
            //StringBuilder temp = new StringBuilder();
            string t = "";
            for (int i = input.Length - 1; i >= 0 ; i--)
            {
               t += input[i];
            }

            return t;

            //char[] characterArray = input.ToCharArray();
            //Array.Reverse(characterArray);
            //return new string(characterArray);

        }
    }
}
