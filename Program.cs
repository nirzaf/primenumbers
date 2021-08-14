using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[50];
            string[] stringArray = new string[50];
            int x = 5;
            for (int i = 49; i > 0; i--)
            {
                intArray[i]= x;
                x += 5;
            }

            for(int a = 0; a<50; a++)
            {
                Console.Write(intArray[a] + ", ");
            }
           
        }  
    }
}
