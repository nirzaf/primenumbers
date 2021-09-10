using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBooKTest b1 = new PhotoBooKTest();

        }  
    }
    public class PhotoBook
    {
        private int numPages{get; set;}
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int pages)
        {
            numPages = pages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
     
    }
    public class BigphotoBook
    {
        public BigphotoBook()
        {
            Console.WriteLine(64);
        }

    }
    public class PhotoBooKTest
    {
        public PhotoBooKTest()
        {
            PhotoBook p1 = new PhotoBook();
            Console.WriteLine(p1.GetNumberPages());
            PhotoBook p2 = new PhotoBook (24);
            Console.WriteLine(p2.GetNumberPages());
            BigphotoBook p3 = new BigphotoBook();
        }

    }
}
