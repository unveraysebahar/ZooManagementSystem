using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Arthropod:Invertebrate
    {
        public string BodyParts { get; set; }
        public string FormOfProliferation { get; set; }

        public Arthropod(string bodyparts, string formOfPoliferation, string internalSkeletonStructure, string circulatorySystemType)
            : base(internalSkeletonStructure, circulatorySystemType)
        {
            this.BodyParts = bodyparts;
            this.FormOfProliferation = formOfPoliferation;
        }

        public virtual string Class()
        {
            return "They belong to the class of arthropod.";
        }

        public virtual string FormOfProliferationInfo()
        {
            return "Breeding forms are separate sexual.";
        }
    }
}
