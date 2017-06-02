namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            int numberOfEqualPeople = 0;
            int numberOfDifferentPeople = 0;

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string[] inputTokens = inputLine.Split();
                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                string town = inputTokens[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                inputLine = Console.ReadLine();
            }

            int indexOfPerson = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = people[indexOfPerson];

            foreach (var person in people)
            {
                int value = person.CompareTo(personToCompare);

                if (value == 0)
                {
                    numberOfEqualPeople++;
                }
                else
                {
                    numberOfDifferentPeople++;
                }
            }

            
            
            if (numberOfEqualPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfEqualPeople} {numberOfDifferentPeople} {people.Count}");
            }
        }
    }
}
