using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier
    {
        public Commando()
        {
            
        }
        public Commando(string typeOfSoldier, uint id, string firstName, string lastName, double salary, Corps corps) 
            : base(typeOfSoldier, id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<Mission>();
        }

        public List<Mission> Missions { get; protected set; }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:F}");
            sb.Append(Environment.NewLine);
            sb.Append($"Corps: {base.Corps}");
            sb.Append(Environment.NewLine);
            sb.Append("Missions:");
            if (this.Missions.Count != 0)
            {
                sb.Append(Environment.NewLine);
            }

            for (int i = 0; i < this.Missions.Count; i++)
            {
                sb.Append($"  Code Name: {this.Missions[i].CodeName} State: {this.Missions[i].State}");

                if (i < this.Missions.Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
    }
}
