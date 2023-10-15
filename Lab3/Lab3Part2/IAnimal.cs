using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class IAnimal
    {
        private string name;
        private string colour;
        private double height;
        private int age;

        protected IAnimal()
        {
        }

        protected IAnimal(string name, string colour, double height, int age)
        {
            this.name = name;
            this.colour = colour;
            this.height = height;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Colour { get => colour; set => colour = value; }
        public double Height { get => height; set => height = value; }
        public int Age { get => age; set => age = value; }

        public void Eat() 
        {
        }
        public string Cry() 
        {
            return " ";
        }
    }
}
