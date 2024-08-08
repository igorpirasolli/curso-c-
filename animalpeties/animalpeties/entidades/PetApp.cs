using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalpeties.entidades
{
    internal class PetApp
    {
        List<Animal> animals { get; set; } = new List<Animal>();



        public void AdddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void AddAnimal()
        {
            int count = animals.Count + 1;
            Console.WriteLine("entre com 'cachorro ou gato' para começar:  ");
            string speciess = Console.ReadLine().ToLower();

            string id = speciess.Substring(0, 1) + count.ToString();

            Console.WriteLine("entre com a idade do animal: ");
            string age = Console.ReadLine();

            Console.WriteLine("Insira uma descrição física do animal de estimação (tamanho, cor, sexo, peso, domesticado): ");
            string physicalDescription = Console.ReadLine().ToLower();

            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
            string personalityDescription = Console.ReadLine()?.ToLower();

            Console.WriteLine("Enter a nickname for the pet");
            string nickname = Console.ReadLine()?.ToLower();

            Animal animal = new Animal(id, speciess, age, physicalDescription, personalityDescription, nickname);
            animals.Add(animal);

            Console.WriteLine("quer adicionar mais um bichinho de estimaçao(sim/nao): ");
            string resp = Console.ReadLine().ToLower();

            if (resp == "sim")
            {
                AddAnimal();
            }

        }

        public void ListAnimals()
        {
            foreach (Animal animal in animals)
            {
                if (animal != null)
                {

                    Console.WriteLine($"id: {animal.ID}\n" +
                    $"specie: {animal.Species}\n" +
                    $"age: {animal.Age}\n" +
                    $"Physical description: {animal.PhysicalDescription}\n" +
                    $"personality description: {animal.PersonalityDescription}\n" +
                    $"nickname: {animal.Nickname}");
                }
                else
                {
                    Console.WriteLine("numeros nulos");
                }
                Console.WriteLine(); ;

            }
        }

        public void ensureCompleteInformation()
        {
            bool completas = true;

            foreach (Animal animal in animals)
            {
                bool imcomplete = false;
                if (string.IsNullOrWhiteSpace(animal.Age))
                {
                    Console.WriteLine($"informaçoes da idade do id: {animal.ID} estao incompletas");
                    imcomplete = true;
                }

                if (string.IsNullOrWhiteSpace(animal.PhysicalDescription))
                {
                    Console.WriteLine($"as informaçoes de descriçao psicologicas do id: {animal.ID} estao imcompletas");
                    imcomplete = true;
                }

                if (imcomplete)
                {
                    completas = false;
                }
            }

            if (completas)
            {
                Console.WriteLine("todas as informaçoes estao completas");
            }
        }

        public void EnsureCompleteInformacoes()
        {
            bool completas = true;
            foreach (Animal animal in animals)
            {
                bool imcomplete = false;
                if (string.IsNullOrWhiteSpace(animal.Nickname))
                {
                    Console.WriteLine($"complete o nickname do id: {animal.ID}");
                    imcomplete = true;
                }
                if (string.IsNullOrWhiteSpace(animal.PersonalityDescription))
                {
                    Console.WriteLine($"complete a descriçao de personalidade do id {animal.ID}");
                    imcomplete = true;
                }
                if (imcomplete)
                {
                    completas = false;
                }
            }
            if (completas)
            {
                Console.WriteLine("informaçoes completas!");
            }

        }

        public void EditAge()
        {
            Console.WriteLine("entre com o nickname do animal que deseja alterar a idade: ");
            string nickname = Console.ReadLine().ToLower().Trim();

            Animal animal1 = animals.FirstOrDefault(x => x.Nickname == nickname);

            if (animal1 != null)
            {
                Console.WriteLine("digite uma nova idade:");
                string idade = Console.ReadLine();
                animal1.Age = idade;
            }
            else
            {
                Console.WriteLine("nao existe nenhum animal com esse apelido.");
            }
        }

        public void EditPersonalityDescripition()
        {
            Console.WriteLine("entre com o apelido referenete ao naimal que dejesa trocar a descriçao de personalidade:");
            string nickname = Console.ReadLine().ToLower().Trim();

            Animal animal = animals.FirstOrDefault(y => y.Nickname.ToLower() == nickname);

            if (animal != null)
            {
                Console.WriteLine($"digite a nova descriçao da personalidade do {animal.Nickname}");
                string newDescripition = Console.ReadLine();

                if (!string.IsNullOrEmpty(newDescripition))
                {
                    animal.PersonalityDescription = newDescripition;
                    Console.WriteLine("descriçao de personalidade alterada com sucesso!");

                }
                else
                {
                    Console.WriteLine("descriçao nao pode ser vazia.");
                }
            }
            else { Console.WriteLine("esse nickname nao existe. "); }
        }

        public void DisplayCats()
        {
            string gato = "gato";
            var result = animals.Where(x => x.Species == gato);

            foreach (Animal animal in result)
            {
                Console.WriteLine(animal);
            }
        }

        public void DisplayDogs()
        {
            string dogs = "cachorro";
            IEnumerable<Animal> result = animals.Where(x => x.Species == dogs);

            foreach (Animal animal in result)
            {
                Console.WriteLine(animal);
            }
        }






    }
}
