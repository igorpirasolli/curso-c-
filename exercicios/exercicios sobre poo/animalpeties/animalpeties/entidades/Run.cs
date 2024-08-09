using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalpeties.entidades
{
    internal class Run
    {
        public PetApp PetApp { get; set; }

        public void run()
        {
            string menuSelection;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                menuSelection = Console.ReadLine()?.ToLower();

                switch (menuSelection)
                {
                    case "1":
                        PetApp.ListAnimals();
                        break;

                    case "2":
                        PetApp.AddAnimal();
                        break;

                    case "3":
                        PetApp.ensureCompleteInformation();
                        break;

                    case "4":
                        PetApp.EnsureCompleteInformacoes();
                        break;

                    case "5":
                        PetApp.EditAge();
                        break;

                    case "6":
                        PetApp.EditPersonalityDescripition();
                        break;

                    case "7":
                        PetApp.DisplayCats();
                        break;

                    case "8":
                        PetApp.DisplayDogs();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");
        }
    }
}
