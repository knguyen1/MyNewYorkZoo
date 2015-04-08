using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewYorkZoo
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name) { }

        public override void Perform(Action action)
        {
            Console.WriteLine("Reptile " + Name + " " + action.Name);
        }

        public override void Perform()
        {
            Console.WriteLine("Reptile " + Name + " slithers around and tests the air for predators.");
        }
    }
}
