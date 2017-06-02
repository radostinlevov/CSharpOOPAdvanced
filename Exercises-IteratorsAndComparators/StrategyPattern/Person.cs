﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Person
    {
        private string name;
        private int age;
        
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;

        public int Age => this.age;

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
