using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Enter first Value : ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Operator Symbol : ");
                char b = Convert.ToChar(Console.ReadLine());
                bool validInput = OperatorValidator(b.ToString());

                while (!validInput)
                {
                    Console.WriteLine("Invalid Symbol! Please Try again");
                    Console.Write("Enter Operator Symbol : ");
                    b = Convert.ToChar(Console.ReadLine());
                    validInput = OperatorValidator(b.ToString());
                }

                Console.Write("Enter Second Value : ");
                double c = Convert.ToDouble(Console.ReadLine());
                double answer = Calculator(a, b, c);
                Console.WriteLine("Answer is : {0} {1} {2} = {3}", a, b, c, answer);
            }
            
        }

        public static bool OperatorValidator(string op)
        {
            if (op == "+" || op == "-" || op == "*" || op == "/")
            {
                return true;
            }
            else 
            {
                return false;
            }        
        }

        public static double Calculator(double x, char o, double y)
        {
            double result = 0;

            if (o == '+')
            {
                result = x + y;
            }
            else if (o == '-')
            {
                result = x - y;
            }
            else if (o == '*')
            {
                result = x * y;
            }
            else if (o == '/')
            {
                result = x / y;
            }
            else {
                Console.WriteLine("Invalid Input Operator");
            }
            return result;
        }

    }
}
