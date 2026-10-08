using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public abstract class Animal
    {
        public double? Weight { get; set; }
        public string? Name { get; set; }
        protected string? Description;

        public abstract string SayHello();
                
    }


    public class Dog : Animal
    {
        public static int counter = 0;

        public Dog()
        {
            counter++;
        }

        public static string DoSomething()
        {
            return "Static method ready!";
        }
        public override string SayHello()
        {
            return $"woof! I am a dog named {Name} and I weight {Weight}.";

        }
    }

    public class Cat : Animal
    {
        public override string SayHello()
        {
            return $"Myau! I am a Cat named {Name}.";

        }


    }

    public class Bear : Animal
    {
        public override string SayHello()
        {
            return $"ahhhhh! I am a Bear named {Name}.";

        }


    }

    public class Donkey : Animal
    {
        public override string SayHello()
        {
            return $"eaeaea! I am a Donkey named {Name}.";

        }


    }

    public class Horse : Animal
    {
        public void Jamp()
        {
            Console.WriteLine($"{Name} : Jamp"); 
        }

        public override string SayHello()
        {
            return $"{Name} : Igo-go!";
        } 

    }

    

}
