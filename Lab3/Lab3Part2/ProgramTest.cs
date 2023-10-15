using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class ProgramTest
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();

            //CAT
            Console.WriteLine("Enter cat name :");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter cat colour :");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter cat height :");
            double catHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cat age :");
            int catAge = int.Parse(Console.ReadLine());

            Cat c1 = new Cat(catName, catColour, catHeight, catAge);
            animals.Add(c1);
            c1.Eat();
            Console.WriteLine($"The cat says: {c1.  Cry()}");


            // DOG
            Console.WriteLine("Enter dog name :");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter dog colour :");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter dog height :");
            double dogHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter dog age :");
            int dogAge = int.Parse(Console.ReadLine());

            Dog d1 = new Dog(dogName, dogColour, dogHeight, dogAge);
            animals.Add(d1);
            d1.Eat();
            Console.WriteLine($"The dog says: {d1.Cry()}");

            Console.WriteLine("These are the names of pets that we have:");
            Console.WriteLine($"Here is {dogName}: {d1.Cry()}");
            Console.WriteLine($"Here is {catName}: {c1.Cry()}");


            foreach (var a in animals)
            {
                Console.WriteLine($"Name: {a.Name}");
                Console.WriteLine($"Colour: {a.Colour}");
                Console.WriteLine($"Heigh: {a.Height} cm");
                Console.WriteLine($"Age: {a.Age} years");
            }
            
        }
    }
}
