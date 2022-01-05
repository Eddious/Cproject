    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageTempReading
{
    class ItsHot
    {
        static void Main(string[] args)
        {
            //program to find the average temperature
            double maxtemp, mintemp, avgtemp;

            Console.WriteLine("Enter maximum and minimum temperature");

            //read the temperatures
            maxtemp = double.Parse(Console.ReadLine());
            mintemp = double.Parse(Console.ReadLine());

            avgtemp = (maxtemp + mintemp) / 2;
        
            Console.WriteLine("Average temperature is {0} ", avgtemp);
 
            Console.ReadKey();
        }
    }
}
