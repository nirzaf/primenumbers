using System;

namespace app2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Demo a = new(50, 50);
            //Demo b = a;
            //a.x = 100;
            //Console.WriteLine("Value of a.x = " + a.x);
            //Console.WriteLine("Value of b.x = " + b.x);
            Gen<string> g1= new();
            Gen<int> g2 = new();
            Gen<double> g3 = new();
            Gen<char> g4 = new();

            Gen<Book> g5 = new();

            Book b1 = new()
            {
                BookId = 1,
                BookName = "BookName",
                Author = "Auth"
            };

            g1.Print("Fazrin");
            g2.Print(50);
            g3.Print(100.05121);
            g4.Print('A');
            g5.Print(b1);

        }  
    }

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }

    //creating structure
    public struct Demo
    {
        public int x, y;
        //parameterized constructor
        public Demo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Gen<T>
    { 
        public void Print(T m)
        {
            Console.WriteLine(m.ToString());
        }
    }
}
