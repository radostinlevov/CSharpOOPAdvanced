namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier: Private
    {
        protected SpecialisedSoldier()
        {
            
        }
        protected SpecialisedSoldier(string typeOfSoldier, uint id, string firstName, string lastName, double salary, Corps corps) : base(typeOfSoldier, id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; protected set; }
    }
}