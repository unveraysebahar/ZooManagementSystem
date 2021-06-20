using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Leon:Mammal
    {
        public string NutritionTypes { get; set; }

        public string Habitat { get; set; }

        public Leon(string nutritionTypes, string habitat, string breathingPattern, string formOfPoliferation, string internalSkeletonStructure, string circulatorySystemType, string muscleType)
            : base(breathingPattern,formOfPoliferation,internalSkeletonStructure, circulatorySystemType, muscleType)
        {
            this.NutritionTypes = nutritionTypes;
            this.Habitat = habitat;
        }

        public virtual string Nutrition()
        {
            return "They eat an average of 15 kg of meat per day.";
        }

        public virtual string HabitatInfo()
        {
            return "They live in scattered populations in Sub-Saharan Africa. Lions prefer grassy plains and savannahs, live in plains bordering rivers and open wooded bushes.";
        }
    }
}
