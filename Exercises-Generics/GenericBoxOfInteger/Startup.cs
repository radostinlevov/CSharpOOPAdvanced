using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfInteger
{
    class Startup
    {
        static void Main()
        {
            List<Box<int> > listOfData = new List<Box<int>>();

            int numberOfIntegers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));

                listOfData.Add(box);
            }

            listOfData.ForEach(b => Console.WriteLine(b));
        }
    }
}
