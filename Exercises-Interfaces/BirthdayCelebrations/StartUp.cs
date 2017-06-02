using System;
using System.Collections.Generic;
using System.Linq;
using BirthdayCelebrations.Models;

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main()
        {
            List<IBirthable> entrants = new List<IBirthable>();

            string entrant = Console.ReadLine();

            while (entrant != "End")
            {
                string[] entrantInfo = entrant.Split();
                string entrantType = entrantInfo[0];

                if (entrantType == "Citizen")
                {
                    string name = entrantInfo[1];
                    int age = int.Parse(entrantInfo[2]);
                    string id = entrantInfo[3];
                    string birthdate = entrantInfo[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    entrants.Add(citizen);
                }
                else if (entrantType == "Pet")
                {
                    string name = entrantInfo[1];
                    string birthdate = entrantInfo[2];

                    Pet pet = new Pet(name, birthdate);
                    entrants.Add(pet);
                }

                entrant = Console.ReadLine();
            }

            string specificYear = Console.ReadLine();

            var celebrating = entrants.Where(e => e.Birthdate.EndsWith(specificYear)).ToList();

            celebrating.ForEach(e => Console.WriteLine(e.Birthdate));
        }
    }
}
