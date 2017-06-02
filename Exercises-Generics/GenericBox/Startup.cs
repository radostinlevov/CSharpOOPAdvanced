using System;

namespace GenericBox
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();

            int number = 0;

            int.TryParse(input, out number);
           
            if (number != 0)
            {
                Box<int> box = new Box<int>(number);

                Console.WriteLine(box);
            }
            else
            {
                Box<string> box = new Box<string>(input);

                Console.WriteLine(box);
            }
        }
    }
}
