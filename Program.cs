using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[50];
            string[] stringArray = new string[50];

           // int[] Numbers = { 12, 22, 33, 11, 33 };


            //int x = 5;
            //for (int i = 49; i >= 0; i--)
            //{
            //    intArray[i]= x;  // intArray[49] = 5; 
            //    x += 5;
            //}

            //for(int a = 0; a<50; a++)
            //{
            //    Console.WriteLine(intArray[a] + ", ");
            //}

            for (int i = 0; i <= 49; i++)
            {
                stringArray[i] = Faker.Name.FullName();
            }

            for (int i = 0; i < 50; i++)
            {
                int a = i + 1;
                Console.WriteLine( a.ToString() + ") " + stringArray[i]);
            }

        }  
    }
}
