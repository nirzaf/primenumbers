using System;
using System.Collections;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            Queue q1 = new Queue();

            for (int i = 0; i < 50; i++)
            {
                Books b1 = new Books
                {
                    BookId = i,
                    BookName = Faker.Name.Middle(),
                    Author = Faker.Name.First()
                };

                st.Push(b1);
                q1.Enqueue(b1);
            }

            Console.WriteLine("Stack loaded");
            Console.ReadLine();

        }  
    }

    public class Books 
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }

}
