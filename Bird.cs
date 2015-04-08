using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewYorkZoo
{
    public class Bird : Animal
    {
        //bird is a type of animal, it will inherit animal
        public Bird(string name) : base(name) { }

        public override void Perform(Action action)
        {
            Console.WriteLine("Bird " + Name + " " + action.Name);
        }

        public override void Perform()
        {
            Console.WriteLine("Bird " + Name + " flies around in his cage.");
        }

        //maybe the mammal exhibit has children members, they need to do something too.
        public virtual void Feed(Bird[] children)
        {
            foreach (var child in children)
            {
                Console.WriteLine("Bird " + Name + " regurgitate and feeds " + child.Name);
            }
        }
    }
}
