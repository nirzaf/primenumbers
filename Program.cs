using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int sum = 0;
            //     Console.Write("Input ypur Natural Number : "); 
            //     int input = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("The first {0} Natural Numbers are : " , input);
            //     for (int x = 1; x <= input; x++)
            //    {             
            //          Console.Write(x + " ");
                    
            //          sum += x;
            //    } 
            //     Console.WriteLine("\nThe sum is : {0}" , sum);  

        //    int multiple;
        //    Console.Write("Input Your Number : ");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    for(int x = 1; x <= 10; x++)
        //    {
        //       multiple = x * input;
        //        Console.WriteLine("{0} * {1} = {2}", x , input , multiple ); 
        //    }
            Console.WriteLine("Enter Your Input");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n All primae numbers within your input value \n");
            for (int x = 2; x < input; x++)
            {
         
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if(isPrime == 2) break;
                }
                if(isPrime != 2)
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }  
    }
}
