using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    class Startup
    {
        static void Main()
        {
            string[] firstTokens = Console.ReadLine().Split();
            string fullName = firstTokens[0] + " " + firstTokens[1];
            string address = firstTokens[2];
            string town = firstTokens[3];

            var firstTuple = new Tuple<string, string, string>(fullName, address, town);

            string[] secondTokens = Console.ReadLine().Split();

            string name = secondTokens[0];
            double litersOfBeer = double.Parse(secondTokens[1]);
            string drunkOrNot = secondTokens[2];
            bool isDrunk;

            if (drunkOrNot == "drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }

            var secondTuple = new Tuple<string, double, bool>(name, litersOfBeer, isDrunk);

            string[] thirdTokens = Console.ReadLine().Split();

            name = thirdTokens[0];
            double accountBalance = double.Parse(thirdTokens[1]);
            string bankName = thirdTokens[2];

            var thirdTuple = new Tuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine($"{firstTuple.Item1} -> {firstTuple.Item2} -> {firstTuple.Item3}");
            Console.WriteLine($"{secondTuple.Item1} -> {secondTuple.Item2} -> {secondTuple.Item3}");
            Console.WriteLine($"{thirdTuple.Item1} -> {thirdTuple.Item2} -> {thirdTuple.Item3}");

        }
    }
}
