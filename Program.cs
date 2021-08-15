using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = Tuple.Create("Fazrin", 2, 5656, "Nirzaf");
            Console.WriteLine(t1.Item1);  
            Console.WriteLine(t1.Item2);  
            Console.WriteLine(t1.Item3);  
            Console.WriteLine(t1.Item4);

        //Usage of Tuple

        //When you want to return multiple values from a method without using ref or out parameters.
        //When you want to pass multiple values to a method through a single parameter.
        //When you want to hold a database record or some values temporarily without creating a separate class.


        //Tuple Limitations:

        //The Tuple is a reference type and not a value type.It allocates on heap and could result in CPU intensive operations.
        //The Tuple is limited to include eight elements.You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
        //The Tuple elements can be accessed using properties with a name pattern Item<elementNumber>, which does not make sense.


        }  
    }
}
