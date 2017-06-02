namespace CustomList
{
    using System;

    class Startup
    {
        static void Main()
        {
            CustomList<string> customList = new CustomList<string>();

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string[] inputTokens = inputLine.Split();
                string command = inputTokens[0];

                switch (command)
                {
                    case "Add":
                        string element = inputTokens[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        int index = int.Parse(inputTokens[1]);
                        string currentElement = customList.Remove(index);
                        break;
                    case "Contains":
                        element = inputTokens[1];
                        Console.WriteLine(customList.Contains(element));
                        break;
                    case "Swap":
                        int firstIndex = int.Parse(inputTokens[1]);
                        int secondIndex = int.Parse(inputTokens[2]);
                        customList.Swap(firstIndex, secondIndex);
                        break;
                    case "Greater":
                        element = inputTokens[1];
                        Console.WriteLine(customList.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        foreach (var item in customList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "Sort":
                        customList.ListOfData =  Sorter<string>.Sort(customList);
                        break;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
