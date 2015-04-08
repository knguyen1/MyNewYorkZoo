using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewYorkZoo
{
    public class Fish : Animal
    {
        public Fish(string name) : base(name) { }

        public override void Perform(Action action)
        {
            Console.WriteLine("Fish " + Name + " " + action.Name);
        }

        public override void Perform()
        {
            Console.WriteLine("Fish " + Name + " tries to find Nemo.");
        }
    }
}
