namespace Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            List<int> stones = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake(stones);

            List<int> orderedStones = new List<int>();

            foreach (var stone in lake)
            {
                orderedStones.Add(stone);
            }

            Console.WriteLine(string.Join(", ", orderedStones));
        }
    }
}
