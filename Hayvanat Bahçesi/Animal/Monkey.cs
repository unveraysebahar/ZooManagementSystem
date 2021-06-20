using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    class Monkey:Mammal
    {
        public string NutritionTypes { get; set; }

        public string Habitat { get; set; }

        public Monkey(string nutritionTypes, string habitat, string breathingPattern, string formOfPoliferation, string internalSkeletonStructure, string circulatorySystemType, string muscleType)
            : base(breathingPattern, formOfPoliferation, internalSkeletonStructure, circulatorySystemType, muscleType)
        {
            this.NutritionTypes = nutritionTypes;
            this.Habitat = habitat;
        }

        public virtual string Nutrition()
        {
            return "They feed on fruits, leaves, insects, flowers, small mammals, reptiles, amphibians and crabs.";
        }

        public virtual string HabitatInfo()
        {
            return "Monkeys are grouped in two groups according to where they live: New World monkeys living in South America and Old World Monkeys from Africa and Asia.";
        }

    }
}
