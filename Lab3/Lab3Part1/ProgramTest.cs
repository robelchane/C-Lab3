using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Dog's name:");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter Dog's colour:");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter Dog's age:");
            int dogAge = int.Parse(Console.ReadLine());

            // Dog object
            Dog d1 = new Dog(dogName, dogColour, dogAge);
            d1.Eat();


            Console.WriteLine("\nEnter Cat's name:");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter Cat's colour:");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter Cat's age:");
            int catAge = int.Parse(Console.ReadLine());

            // Cat object
            Cat c1 = new Cat(catName, catColour, catAge);
            c1.Eat();

        }
    }
}
