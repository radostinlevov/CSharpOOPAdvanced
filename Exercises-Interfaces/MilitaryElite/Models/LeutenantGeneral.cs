using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Models
{
    public class LeutenantGeneral : Private
    {
        public LeutenantGeneral(string typeOfSoldier, uint id, string firstName, string lastName, double salary)
            : base(typeOfSoldier, id, firstName, lastName, salary)
        {
            this.Ids = new List<int>();
            this.Privates = new List<Private>();
        }

        public List<int> Ids { get; set; }

        public List<Private> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:F}");
            sb.Append(Environment.NewLine);
            sb.Append("Privates:");
            sb.Append(Environment.NewLine);

            for (int i = 0; i < this.Ids.Count; i++)
            {
                var currentPrivate = this.Privates.First(p => p.Id == this.Ids[i]);
                sb.Append(
                    $"  Name: {currentPrivate.FirstName} {currentPrivate.LastName} Id: {currentPrivate.Id} Salary: {currentPrivate.Salary:F}");
                if (i < this.Ids.Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
    }
}