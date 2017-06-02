using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public  class Private : Soldier
    {
        public Private()
        {
            
        }
        public Private(string typeOfSoldier, uint id, string firstName, string lastName, double salary)
            : base(typeOfSoldier, id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; protected set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F}";
        }
    }
}