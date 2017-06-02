﻿namespace BirthdayCelebrations.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            Id = id;
        }

        public string Model { get; }

        public string Id { get; }
    }
}
