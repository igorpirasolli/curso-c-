using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ani
{
    internal class Animal
    {
        public string ID { get; set; }
        public string Species { get; set; }
        public string Age { get; set; }
        public string PhysicalDescription { get; set; }
        public string PersonalityDescription { get; set; }
        public string Nickname { get; set; }

        public Animal(string id, string species, string age, string physicalDescription, string personalityDescription, string nickname)
        {
            ID = id;
            Species = species;
            Age = age;
            PhysicalDescription = physicalDescription;
            PersonalityDescription = personalityDescription;
            Nickname = nickname;
        }

        
        public override string ToString()
        {
            return $"id: {ID}\n" +
                $"specie: {Species}\n" +
                $"age: {Age}\n" +
                $"Physical description: {PhysicalDescription}\n" +
                $"personality description: {PersonalityDescription}\n" +
                $"nickname: {Nickname}\n";

        }
    }
}
