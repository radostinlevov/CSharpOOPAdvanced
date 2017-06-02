using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Smartphones;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                Smartphone smartphone = new Smartphone();

                Console.WriteLine(smartphone.Call(number));
            }

            string[] sites = Console.ReadLine().Split();

            foreach (var site in sites)
            {
                Smartphone smartphone = new Smartphone();

                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
