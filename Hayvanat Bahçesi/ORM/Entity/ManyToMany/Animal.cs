using Hayvanat_Bahçesi.ORM.Entity.ConditionalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.ManyToMany
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string Vaccine { get; set; }
        public string Disease { get; set; }
        public virtual List<Veterinary> Veterinaries { get; set; }
        public virtual List<Zookeeper> Zookeepers { get; set; }
        public virtual List<Cage> Cages { get; set; }
        public virtual List<Animal_Baby> Animal_Babies { get; set; }
    }

}