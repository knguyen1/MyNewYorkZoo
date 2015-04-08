using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewYorkZoo
{
    //we define our class animal, this function is generic enough to be reused and inherited by
    //other animal classes: bear, horse, tigers, etc.  It is the aim of the program to let different
    //animals perform different actions.  We don't want a boring zoo, do we? :)
    public class Animal
    {
        private string name = "no name"; //default animal

        public string Name
        {
            get
            { 
                return name; 
            }
            set
            {
                name = value;
            }
        }

        private Animal() { }

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void Perform(Action action)
        {
            Console.WriteLine("Animal " + Name + " " + action.Name);
        }

        public virtual void Perform()
        {
            Console.WriteLine("Animal " + Name + " wags its tail.");
        }
    }
}
