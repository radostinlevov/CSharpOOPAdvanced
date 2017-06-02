using System;
using System.Text;

namespace MilitaryElite.Models
{
    public class Spy : Soldier
    {
        public Spy(string typeOfSoldier, uint id, string firstName, string lastName, string codeNumber) 
            : base(typeOfSoldier, id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public string CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id}");
            sb.Append(Environment.NewLine);
            sb.Append($"Code Number: {this.CodeNumber}");

            return sb.ToString();
        }
    }
}