using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier
    {
        public Engineer()
        {
            
        }
        public Engineer(string typeOfSoldier, uint id, string firstName, string lastName, double salary, Corps corps) : base(typeOfSoldier, id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<Repair>();
        }

        public List<Repair> Repairs { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:F}");
            sb.Append(Environment.NewLine);
            sb.Append($"Corps: {base.Corps}");
            sb.Append(Environment.NewLine);
            sb.Append("Repairs:");
            if (this.Repairs.Count != 0)
            {
                sb.Append(Environment.NewLine);
            }

            for (int i = 0; i < this.Repairs.Count; i++)
            {
                sb.Append($"  Part Name: {this.Repairs[i].PartName} Hours Worked: {this.Repairs[i].HoursWorked}");

                if (i < this.Repairs.Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
    }
}