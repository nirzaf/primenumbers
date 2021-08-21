using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType());

            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("Type of dbl is {0}", dbl.GetType());

            var isValid = true;
            Console.WriteLine("Type of isValid is {0}", isValid.GetType());

            var ano = new { name = "Steve" };
            Console.WriteLine("Type of ano is {0}", ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("Type of arr is {0}", arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine("Type of file is {0}", file.GetType());

            // string collection
            IList<string> stringList = new List<string>() { 
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java" 
            };

            // LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("C++") 
                         select s;

            foreach(var s in stringList)
            {
                Console.WriteLine(s);
            }
        }  
    }
}
