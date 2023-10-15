using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class Dog:IAnimal
    {
        public Dog(string name, string colour, double height, int age) : base (name, colour, height, age)
        {

        }
        public new void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public new string Cry()
        {
            return "Woof!";
        }
       
    }
}
