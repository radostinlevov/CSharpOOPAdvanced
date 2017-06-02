using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    class Statrup
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

            listOfData.ForEach(b => Console.WriteLine(b));
        }
    }
}
