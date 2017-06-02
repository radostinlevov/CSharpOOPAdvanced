using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
   public class Repair: Engineer
    {
        public Repair(string partName, int hoursWorked) 
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }
    }
}
