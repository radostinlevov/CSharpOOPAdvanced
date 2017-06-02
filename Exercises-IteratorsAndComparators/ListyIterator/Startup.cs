namespace ListyIterator
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {

            ListyIterator<string> customList = new ListyIterator<string>();

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                try
                {
                    string[] inputTokens = inputLine.Split();
                    string command = inputTokens[0];

                    switch (command)
                    {
                        case "Create":
                            List<string> collection = new List<string>();

                            for (int i = 1; i < inputTokens.Length; i++)
                            {
                                collection.Add(inputTokens[i]);
                            }

                            customList = new ListyIterator<string>(collection);
                            break;
                        case "Move":
                            Console.WriteLine(customList.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(customList.HasNext());
                            break;
                        case "Print":
                            customList.Print();
                            break;
                        case "PrintAll":
                            Console.WriteLine(string.Join(" ", customList.Collection));
                            break;

                    }

                    inputLine = Console.ReadLine();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            
        }
    }
}

