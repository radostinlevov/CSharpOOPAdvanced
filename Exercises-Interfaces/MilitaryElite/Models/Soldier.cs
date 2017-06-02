namespace MilitaryElite.Models
{
    public abstract class Soldier
    {
        protected Soldier()
        {
            
        }
        protected Soldier(string typeOfSoldier, uint id, string firstName, string lastName)
        {
            this.TypeOfSoldier = typeOfSoldier;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string TypeOfSoldier { get; protected set; }

        public uint Id { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }
    }
}