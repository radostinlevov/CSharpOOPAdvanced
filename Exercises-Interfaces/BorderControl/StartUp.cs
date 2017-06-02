using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorderControl.Models;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            List<IIdentifiable> entrants = new List<IIdentifiable>();

            string entrant = Console.ReadLine();

            while (entrant != "End")
            {
                string[] entrantInfo = entrant.Split();

                if (entrantInfo.Length > 2)
                {
                    string name = entrantInfo[0];
                    int age = int.Parse(entrantInfo[1]);
                    string id = entrantInfo[2];

                    Citizen citizen = new Citizen(name, age, id);
                    entrants.Add(citizen);
                }
                else
                {
                    string model = entrantInfo[0];
                    string id = entrantInfo[1];

                    Robot robot = new Robot(model, id); 
                    entrants.Add(robot);
                }

                entrant = Console.ReadLine();
            }

            string fakeIds = Console.ReadLine();

            var detained = entrants.Where(i => i.Id.EndsWith(fakeIds)).ToList();

            detained.ForEach(e => Console.WriteLine(e.Id));
        }
    }
}
