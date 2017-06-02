namespace FoodShortage.Models
{
    public class Rabel : Person
    {
        public Rabel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
        }
        
        public string Group { get; }

        public override void BuyFood()
        {
            base.Food += 5;
        }
    }
}
