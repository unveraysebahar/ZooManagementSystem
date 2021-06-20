using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Vertebrate
    {
        private string _internalSkeletonStructure;
        protected string _circulatorySystemType;
        protected string _muscleType;

        public Vertebrate(string internalSkeletonStructure, string circulatorySystemType, string muscleType)
        {
            _internalSkeletonStructure = internalSkeletonStructure;
            _circulatorySystemType = circulatorySystemType;
            _muscleType = muscleType;
        }

        public string InternalSkeletonStructure
        {
            get { return this._internalSkeletonStructure; }
            set { this._internalSkeletonStructure = value; }
        }

        public string CirculatorySystemType
        {
            get { return this._circulatorySystemType; }
            set { this._circulatorySystemType = value; }
        }

        public string MuscleType
        {
            get { return this._muscleType; }
            set { _muscleType = value; }
        }

        public virtual string InternalSkeletonStructureInfo()
        {
            return "They have articulated inner skeleton made of cartilage and bone.";
        }

        public virtual string CirculatorySystemTypeInfo()
        {
            return "They have a closed circulatory system.";
        }

        public virtual string MuscleTypeInfo()
        {
            return "The movement is done in striped muscles. " + "\nSmooth muscles are located in internal organs.";
        }
    }
}
