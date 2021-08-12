using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter Your Input : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            for ( int x = 1; x <= input1; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    int multiple = x * y;
                    if (y != 10)
                    {
                      Console.Write("{0} * {1} = {2} , ", y , x , multiple);
                    } 
                    else
                    {
                     Console.Write("{0} * {1} = {2} ,\n", y , x , multiple);
                    }
                }    
            }
          
        }  
    }
}
