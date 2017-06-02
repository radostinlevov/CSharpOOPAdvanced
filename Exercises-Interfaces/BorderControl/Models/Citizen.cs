using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            Id = id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; }
    }
}
