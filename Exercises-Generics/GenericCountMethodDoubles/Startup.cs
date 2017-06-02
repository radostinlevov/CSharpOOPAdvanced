using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    class Startup
    {
        static void Main()
        {
            List<Box<double>> listOfData = new List<Box<double>>();

            int numberOfdoubles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfdoubles; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                listOfData.Add(box);
            }

            double element = double.Parse(Console.ReadLine());

            int count = Box<double>.CountGreaterElements(listOfData, element);

            Console.WriteLine(count);
        }
    }
}
