using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Input 1 : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operator Sign : ");
            Char symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Input 2 : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Add(input1,symbol,input2);
            Subtract(input1, symbol, input2);
            Multiply(input1, symbol, input2);
            Divide(input1, symbol, input2);
        }
        public static void Add(int input1, char symbol, int input2)
        {
         if(symbol == '+')
            {
                int result = input1 + input2;
                Console.WriteLine("Answer : " + result);
            }
        }
        public static void Subtract(int input1, char symbol, int input2)
        {
            if (symbol == '-')
            {
                int result = input1 - input2;
                Console.WriteLine("Answer : " + result);
            }
        }
        public static void Multiply(int input1, char symbol, int input2)
        {
            if (symbol == '*')
            {
                int result = input1 * input2;
                Console.WriteLine("Answer : " + result);
            }
        }
        public static void Divide(int input1, char symbol, int input2)
        {
            if (symbol == '/')
            {
                int result = input1 / input2;
                Console.WriteLine("Answer : " + result);
            }
        }
    }
}
