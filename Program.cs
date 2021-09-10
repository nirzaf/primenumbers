using System;
using System.Linq;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "some text";
            // Console.WriteLine(a.Length); // Length = 9
            // Console.WriteLine(a.IndexOf('t')); // IndexOf = 5
            // a = a.Insert(0, "This is ");
            //Console.WriteLine(a); // This is some text
            // a = a.Replace("This is ", "I am ");
            //Console.WriteLine(a); // I am some text
            //if(a.Contains("some"))
            // Console.WriteLine("found"); // found
             //Console.WriteLine(a.Remove(4)); // some
            Console.WriteLine(a.Substring(2)); // me text
        } 
        
        
    }
}
