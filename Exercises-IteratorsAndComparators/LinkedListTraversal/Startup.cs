using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraversal
{
    class Startup
    {
        static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>(); 

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInfo = Console.ReadLine().Split();

                string command = commandInfo[0];
                int number = int.Parse(commandInfo[1]);

                switch (command)
                {
                    case "Add":
                        linkedList.Add(number);
                        break;
                    case "Remove":
                        linkedList.Remove(number);
                        break;
                }
            }

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(string.Join(" ", linkedList));
        }
    }
}
