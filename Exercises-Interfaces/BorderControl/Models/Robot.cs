using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.Model = model;
            Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; }
    }
}
