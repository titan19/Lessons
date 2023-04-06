using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{

    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public abstract void MakeSound(); 
    }

    public enum Size
    {
        Small, Medium, SmallLarge,
    }

    public class Dog : Animal
    {
        public Size DogSize { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Pug : Dog
    {
        public Pug()
        {
            DogSize = Size.Small;
        }
    }
}
