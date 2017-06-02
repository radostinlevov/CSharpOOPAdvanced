namespace FoodShortage.Models
{
    public abstract class Person : IBuyer
    {
        private string name;
        private int age;

        protected Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public int Food { get; protected set; }

        public abstract void BuyFood();

    }
}
