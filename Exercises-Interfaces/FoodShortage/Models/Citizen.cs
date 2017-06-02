using FoodShortage.Models;

namespace FoodShortage.Models
{
    public class Citizen : Person
    {
        public Citizen(string name, int age, string id, string birthdate) 
            : base (name, age)
        {
            this.Birthdate = birthdate;
            this.Id = id;
        }
        
        public string Birthdate { get; }
        public string Id { get; }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}
