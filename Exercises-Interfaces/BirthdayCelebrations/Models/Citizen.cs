namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            Birthdate = birthdate;
            Id = id;
        }

        public string Name { get;}
        public int Age { get;}
        public string Birthdate { get; }
        public string Id { get; }
    }
}
