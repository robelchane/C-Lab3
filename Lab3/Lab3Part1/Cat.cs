﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    public class Cat : Animal
    {
        public Cat(string name, string colour, int age) : base(name, colour, age)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
