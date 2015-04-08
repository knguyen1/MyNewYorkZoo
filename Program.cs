using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewYorkZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The purpose of this program is to simulate a zoo visit.
            //Our zoo will have a constant size (it will have a fixed number of exhibits for fish, mammals, amphibians, reptiles, etc.
            //You start with a fixed amount of stamina points. Visiting an exhibit will cost you a fixed amount of stamina points.
            //Later revisions can include depletion of stamina based on distances between exhibits, say.
            //When you deplete your stamina, you must exit the zoo.
            //Program ends when you exit the zoo.

            //user stats
            int stamina = 100;

            #region populate zoo

            //Let's populate our zoo.  This will be in a List object containing the Animals class.
            List<Animal> animals = new List<Animal>();

            //animals of different classes will all inherit the Animal class
            //within each class are overrides specific for those Types
            Bird parrot = new Bird("Iago");
            Mammal bear = new Mammal("Smokey the Bear");
            Mammal tiger = new Mammal("Tigger");
            Reptile snake = new Reptile("Kaa");
            Fish shark = new Fish("Bruce the Shark");

            //add it to the list of animals
            animals.Add(parrot);
            animals.Add(bear);
            animals.Add(snake);
            animals.Add(shark);
            animals.Add(tiger);

            #endregion

            //for simplicity's sake, let us randomly visit the exhibits
            //make a new random object.  this shouldn't live inside the while loop
            Random rand = new Random();

            //keep a running list of exhibits already visited
            List<int> alreadyVisited = new List<int>();

            while(stamina > 30) //each visit will cost 30 stamina, so we can visit 3 exhibit
            {
                int thisVisit = 0;

                //don't visit the same exhibit twice
                do
                {
                    thisVisit = rand.Next(animals.Count);
                }
                while (alreadyVisited.Contains(thisVisit));

                //got a valid interger, visit this animal
                Animal thisAnimal = animals[thisVisit];

                string animalName = thisAnimal.Name;
                string animalType = thisAnimal.GetType().Name;

                //visit the exhibit
                Console.WriteLine("You visit {0}. {0} is a {1}.", animalName, animalType);

                //perform the action
                if (animalName == "Smokey the Bear")
                {
                    Action action = new Action("warns you about forest fires.");
                    thisAnimal.Perform(action);
                }
                else
                {
                    thisAnimal.Perform();
                }

                //already visited, add to running list
                alreadyVisited.Add(thisVisit);

                //decrease stamina
                stamina -= 30;
            }

            Console.WriteLine("Stamina depleted!  You must leave the zoo.  Enter the gift shop?  Y/N");

            string willVisit = Console.ReadLine();
            bool validResponse = IsValidResponse(willVisit);

            //invalid input
            while (!validResponse)
            {
                Console.WriteLine("Invalid input.  Enter Y or N only.");
                willVisit = Console.ReadLine();
                validResponse = IsValidResponse(willVisit);
            }

            if(willVisit.ToLower().Equals("y"))
                VisitGiftShop();

            Console.WriteLine("\n\nGoodbye!  Press any key.");
            Console.ReadLine();
        }

        public static void VisitGiftShop()
        {
            Console.WriteLine("You visit the gift shop and you buy a toy snake.");
            //
        }

        public static bool IsValidResponse(string resp)
        {
            string respLower = resp.ToLower();
            return (respLower == "y") | (respLower == "n");
        }
    }
}
