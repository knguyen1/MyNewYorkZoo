using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewYorkZoo
{
    //mammal is a type of animal, so it will inherit the animal class
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }

        public override void Perform(Action action)
        {
            Console.WriteLine("Mammal " + Name + " " + action.Name);
        }

        public override void Perform()
        {
            Console.WriteLine("Mammal " + Name + " roars with vigor!");
        }

        //maybe the mammal exhibit has children members, they need to do something too.
        public virtual void Feed(Mammal[] children)
        {
            foreach (var child in children)
            {
                Console.WriteLine("Mammal " + Name + " breast feeds " + child);
            }
        }
    }
}
