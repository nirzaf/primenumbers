﻿using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime(); 

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31); 

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
 
            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            DateTime dt = new DateTime(636370000000000000); 
            var minTicks = DateTime.MinValue.Ticks;  //min value of ticks
            var maxValue = DateTime.MaxValue.Ticks; // max value of ticks

            Console.WriteLine(dt);
            Console.WriteLine(minTicks);
            Console.WriteLine(maxValue);
            Console.WriteLine("       ");
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            DateTime timeSpan = new(2015, 12, 31);
           
            TimeSpan ts = new(25,20,55);
            DateTime newDate = timeSpan.Add(ts);
            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM
        }  
    }
}
