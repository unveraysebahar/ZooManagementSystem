using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Jaguar:Mammal, ISwim
    {
        public string NutritionTypes { get; set; }

        public string Habitat { get; set; }

        public Jaguar(string nutritionTypes, string habitat, string breathingPattern, string formOfPoliferation, string internalSkeletonStructure, string circulatorySystemType, string muscleType)
            : base(breathingPattern, formOfPoliferation, internalSkeletonStructure, circulatorySystemType, muscleType)
        {
            this.NutritionTypes = nutritionTypes;
            this.Habitat = habitat;
        }

        public virtual string Nutrition()
        {
            return "Like all cats, the jaguar is a meat-only carnivore. They eat an average of 10 kg of meat per day. ";
        }

        public virtual string HabitatInfo()
        {
            return "Panthers generally live in the rainforests of America.";
        }

        public string Swim()
        {
            return "They like to swim.";
        }

    }
}
