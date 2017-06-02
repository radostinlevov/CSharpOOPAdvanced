using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    class Startup
    {
        static void Main()
        {
            SortedSet<Person> firstPeople = new SortedSet<Person>(new CustomComparer());
            HashSet<Person> secondPeople = new HashSet<Person>(new CustomEqualityComparer());

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personDetails = Console.ReadLine().Split();
                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);

                Person person = new Person(name, age);
                firstPeople.Add(person);
                secondPeople.Add(person);
            }

            Console.WriteLine(firstPeople.Count);
            Console.WriteLine(secondPeople.Count);

        }
    }
}
