using System;
using System.Collections.Generic; 

namespace GenericSwapMethodIntegers
{
    class StartUp
    {
        static void Main()
        {

            List<Box<int>> listOfData = new List<Box<int>>();
            int numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                listOfData.Add(box);
            }

            string[] swapCommand = Console.ReadLine().Split();
            int firstIndex = int.Parse(swapCommand[0]);
            int secondIndex = int.Parse(swapCommand[1]);

            int firstData = listOfData[firstIndex].Value;
            int secondData = listOfData[secondIndex].Value;

            listOfData.RemoveAt(firstIndex);
            listOfData.Insert(firstIndex, new Box<int>(secondData));
            listOfData.RemoveAt(secondIndex);
            listOfData.Insert(secondIndex, new Box<int>(firstData));


            listOfData.ForEach(b => Console.WriteLine(b));
        }
    }
}
