using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.ManyToMany
{
    public class Animal_Baby
    {
        [Key]
        public int AnimalBabyID { get; set; }
        public string DateOfBirth { get; set; }
        public string BirthWeight { get; set; }
        public virtual List<Animal> Animals { get; set; }
    }
}
