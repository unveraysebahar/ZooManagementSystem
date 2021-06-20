using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Bird:Vertebrate
    {
        public string BreathingPattern { get; set; }
        public string FormOfProliferation { get; set; }
        public int WingWidth { get; set; }
        public int BeakLength { get; set; }
        public string Habitat { get; set; }
        public string ModeOfAction { get; set; }

        public Bird(string breathingPattern, string formOfPoliferation, int wingwidth, int beaklength, string habitat, string modeofaction, string internalSkeletonStructure, string circulatorySystemType, string muscleType)
            : base(internalSkeletonStructure, circulatorySystemType, muscleType)
        {
            this.BreathingPattern = breathingPattern;
            this.FormOfProliferation = formOfPoliferation;
            this.WingWidth = wingwidth;
            this.BeakLength = beaklength;
            this.Habitat = habitat;
            this.ModeOfAction = modeofaction;
        }

        public virtual string BreathingPatternInfo()
        {
            return "They make lung breathing.";
        }

        public virtual string FormOfProliferationInfo()
        {
            return "They multiply with eggs.";
        }

    }
}
