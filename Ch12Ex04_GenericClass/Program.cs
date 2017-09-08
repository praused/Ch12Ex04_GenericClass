using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex04_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Jack"));
            farm.Animals.Add(new Chicken("Vera"));
            farm.Animals.Add(new Chicken("Sally"));
            farm.Animals.Add(new SuperCow("Kevin"));
            farm.MakeNoises();

            Farm<Cow> dairyFarm = farm.GetCows();
            //More flexible to use our generic method for this, as we do here for chickens...
            Farm<Chicken> poultryFarm = farm.GetSpecies<Chicken>();

            Console.WriteLine("Feeding cows");
            dairyFarm.FeedTheAnimals();
            Console.WriteLine("Feeding chickens");
            poultryFarm.FeedTheAnimals();

            foreach (Cow cow in dairyFarm)
            {
                if (cow is SuperCow)
                {
                    (cow as SuperCow).Fly();
                }
            }
            Console.ReadKey();
        }
    }
}
