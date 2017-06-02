using System;

namespace Tuple
{
    class Startup
    {
        static void Main()
        {
            string[] firstTokens = Console.ReadLine().Split();
            string fullName = firstTokens[0] + " " + firstTokens[1];
            string address = firstTokens[2];

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);

            string[] secondTokens = Console.ReadLine().Split();

            string name = secondTokens[0];
            double litersOfBeer = double.Parse(secondTokens[1]);

            Tuple<string, double> secondTuple = new Tuple<string, double>(name, litersOfBeer);

            string[] thirdTokens = Console.ReadLine().Split();

            int integer = int.Parse(thirdTokens[0]);
            double number = double.Parse(thirdTokens[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(integer, number);

            Console.WriteLine($"{firstTuple.Item1} -> {firstTuple.Item2}");
            Console.WriteLine($"{secondTuple.Item1} -> {secondTuple.Item2}");
            Console.WriteLine($"{thirdTuple.Item1} -> {thirdTuple.Item2}");
        }
    }
}