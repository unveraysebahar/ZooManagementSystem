using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class LargeCheckeredSkipper:Arthropod,IFly
    {
        public string AverageLifeSpan { get; set; }

        public LargeCheckeredSkipper(string averageLifeSpan, string bodyparts, string formOfPoliferation, string internalSkeletonStructure, string circulatorySystemType)
            : base(bodyparts, formOfPoliferation, internalSkeletonStructure, circulatorySystemType)
        {
            this.AverageLifeSpan = averageLifeSpan;
        }

        public string Fly()
        {
            return "They fly.";
        }
    }
}
