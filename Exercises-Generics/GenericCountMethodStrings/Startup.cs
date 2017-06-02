using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    class StartUp
    {
        static void Main()
        {
            List<Box<string>> listOfData = new List<Box<string>>();

            int numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                listOfData.Add(box);
            }

            string element = Console.ReadLine();

            int count = Box<string>.CountGreaterElements(listOfData, element);

            Console.WriteLine(count);
        }
    }
}
