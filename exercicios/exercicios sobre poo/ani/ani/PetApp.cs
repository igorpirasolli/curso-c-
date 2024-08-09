using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ani
{
    internal class PetApp
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void MostrarAnimais()
        {
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal);
            }
        }


    }
}
