using System;
using System.Reflection.Metadata.Ecma335;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 Names :");
            Person p = new Person();
            for(int i =0; i < 3; i++)
            {
                string names3 = Console.ReadLine();
                p.name[i] = names3;
            }

            p.PrintName();
        }

        class Person
        {
            public string[] name = new string[3];
           
            public void PrintName()
            {
                foreach (var message in name )
                {
                    Console.WriteLine("Hello! My name is " + message);
                }
            }
        }
    }
}
