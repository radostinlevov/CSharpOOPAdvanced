using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Startup
    {
        static void Main()
        {
            SortedSet<Person> peopleSortedByName = new SortedSet<Person>(new NameComparer());
            SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new AgeComparer());

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personDetails = Console.ReadLine().Split();
                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);

                Person person = new Person(name, age);

                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopleSortedByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleSortedByAge));

        }
    }
}
