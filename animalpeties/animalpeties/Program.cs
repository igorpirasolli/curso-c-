using animalpeties.entidades;

namespace animalpeties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("d1", "cachorro", "2", 
                "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
                "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.", 
                "lola");
            PetApp petApp = new PetApp();
            petApp.AdddAnimal(animal1);

            Animal animal2 = new Animal("d2",
                "cachorro",
                "9",
                "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
                "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.",
                "loki");
            petApp.AdddAnimal(animal2);

            Animal animal3 = new Animal("c3",
                "gato",
                "1",
                "small white female weighing about 8 pounds. litter box trained.",
                "friendly",
                "puss");
            petApp.AdddAnimal(animal3);

            Animal animal4 = new Animal("c4",
                "gato", 
                "5",
                "lindo",
                "feio",
                "romeu");
            petApp.AdddAnimal(animal4);

            

            
            Run run = new Run();
            run.run();
        }
    }
}