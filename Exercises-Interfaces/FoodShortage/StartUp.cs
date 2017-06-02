using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage.Models;

namespace FoodShortage
{
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] entrantInfo = Console.ReadLine().Split();

                if (entrantInfo.Length > 3)
                {
                    string name = entrantInfo[0];
                    int age = int.Parse(entrantInfo[1]);
                    string id = entrantInfo[2];
                    string birthdate = entrantInfo[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    people.Add(citizen);
                }
                else
                {
                    string name = entrantInfo[0];
                    int age = int.Parse(entrantInfo[1]);
                    string group = entrantInfo[2];

                    Rabel rabel = new Rabel(name, age, group);
                    people.Add(rabel);
                }
            }

            string nameOfBuyer = Console.ReadLine().Trim();

            while (nameOfBuyer != "End")
            {
                if (people.Any(p => p.Name == nameOfBuyer))
                {
                    people.First(p => p.Name == nameOfBuyer).BuyFood();
                }

                nameOfBuyer = Console.ReadLine().Trim();
            }

            int totalAmount = 0;

            foreach (var person in people)
            {
                totalAmount += person.Food;
            }

            Console.WriteLine(totalAmount);
        }
    }
}
