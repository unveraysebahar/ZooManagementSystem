using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.ManyToMany
{
    public class Cage
    {
        [Key]
        public int CageID { get; set; }
        public string CageName { get; set; }
        public string Size { get; set; }
        public string Heat { get; set; }
        public string FloorMaterial { get; set; }
        public string AnimalSpeciesInCage { get; set; }
        public string Location { get; set; }
        public virtual List<Animal> Animals { get; set; }
    }
}
