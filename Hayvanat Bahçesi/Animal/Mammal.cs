using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Mammal:Vertebrate
    {
        public string BreathingPattern { get; set; }
        public string FormOfProliferation { get; set; }

        public Mammal(string breathingPattern, string formOfPoliferation, string internalSkeletonStructure, string circulatorySystemType, string muscleType)
            : base(internalSkeletonStructure, circulatorySystemType, muscleType)
        {
            this.BreathingPattern = breathingPattern;
            this.FormOfProliferation = formOfPoliferation;
        }

        public virtual string Class()
        {
            return "They belong to the class of mammals.";
        }

        public virtual string BreathingPatternInfo()
        {
            return "They make lung breathing.";
        }

        public virtual string FormOfProliferationInfo()
        {
            return "They reproduce by giving birth. They feed its offspring with milk.";
        }
    }
}
