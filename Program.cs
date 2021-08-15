using System;
using System.Collections;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            Books b1 = new Books();

            for (int i = 0; i < 50; i++)
            {
                b1.BookId = i;
                b1.BookName = Faker.
            }

        }  
    }

    public class Books 
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }

}
