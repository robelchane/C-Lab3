using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class Cat : IAnimal
    {
        public Cat(string name, string colour, double height, int age) : base(name, colour, height, age)
        {

        }
        public new void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public new string Cry()
        {
            return "Meow!";
        }

    }
}
