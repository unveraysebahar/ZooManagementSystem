using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.Animal
{
    public class Invertebrate
    {
        private string _internalSkeletonStructure;
        protected string _circulatorySystemType;

        public Invertebrate(string internalSkeletonStructure, string circulatorySystemType)
        {
            _internalSkeletonStructure = internalSkeletonStructure;
            _circulatorySystemType = circulatorySystemType;
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

        public virtual string InternalSkeletonStructureInfo()
        {
            return "There is no skeletal system. There are other structures that will keep the body upright.";
        }

        public virtual string CirculatorySystemTypeInfo()
        {
            return "They have a opened circulatory system.";
        }

    }
}
