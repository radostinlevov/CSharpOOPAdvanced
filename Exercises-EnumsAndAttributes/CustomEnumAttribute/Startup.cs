using System;
using System.Reflection;

namespace CustomEnumAttribute
{
    public class Startup
    {
        public static void Main()
        {
            string target = Console.ReadLine();
            Type type = null;

            if (target == "Rank")
            {
                type = typeof(Rank);
            }
            else
            {
                type = typeof(Suit);
            }

            var attributes = type.GetCustomAttributes();

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
