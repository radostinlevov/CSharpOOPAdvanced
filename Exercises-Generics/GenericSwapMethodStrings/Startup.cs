using System;
using System.Collections.Generic;

namespace GenericSwapMethodStrings
{
    class Startup
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

            string[] swapCommand = Console.ReadLine().Split();
            int firstIndex = int.Parse(swapCommand[0]);
            int secondIndex = int.Parse(swapCommand[1]);

            string firstData = listOfData[firstIndex].Value;
            string secondData = listOfData[secondIndex].Value;

            listOfData.RemoveAt(firstIndex);
            listOfData.Insert(firstIndex, new Box<string>(secondData));
            listOfData.RemoveAt(secondIndex);
            listOfData.Insert(secondIndex, new Box<string>(firstData));


            listOfData.ForEach(b => Console.WriteLine(b));
        }
    }
}
