namespace TrafficLights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<string> listOfLights = new List<string>();

            string[] lights = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var light in lights)
            {
                listOfLights.Add(light);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string lastElement = listOfLights.Last();

                listOfLights.Remove(lastElement);
                listOfLights.Insert(0, lastElement);

                Console.WriteLine(string.Join(" ", listOfLights));
            }
        }
    }
}
