using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    class KingFisher:Bird,IFly
    {
        public KingFisher(string breathingPattern, string formOfPoliferation, int wingwidth, int beaklength, string habitat, string modeofaction, string internalSkeletonStructure, string circulatorySystemType, string muscleType)
     : base(breathingPattern, formOfPoliferation, wingwidth, beaklength, habitat, modeofaction, internalSkeletonStructure, circulatorySystemType, muscleType)
        {
            this.BreathingPattern = breathingPattern;
            this.FormOfProliferation = formOfPoliferation;
            this.WingWidth = wingwidth;
            this.BeakLength = beaklength;
            this.Habitat = habitat;
            this.ModeOfAction = modeofaction;
        }

        public override string BreathingPatternInfo()
        {
            return "They make lung breathing.";
        }

        public string Fly()
        {
            return "They mostly fly";
        }

        public override string FormOfProliferationInfo()
        {
            return "They multiply with eggs.";
        }
    }
}
