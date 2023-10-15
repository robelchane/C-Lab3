using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    public  abstract class Animal
    {
        private string name;
        private string colour;
        private int age;

        public Animal()
        {
        }

        public Animal(string name, string colour, int age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Colour { get => colour; set => colour = value; }
        public int Age { get => age; set => age = value; }

        public abstract void Eat();
    }
}
