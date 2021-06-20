using Hayvanat_Bahçesi.ORM.Entity.ManyToMany;
using Hayvanat_Bahçesi.ORM.Entity.TableSplitting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.ConditionalMapping
{
    public enum GenderV
    {
        Male, Female
    }

    public class Veterinary
    {
        public int VeterinaryID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderV GenderV { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string GraduateUniversity {get;set;}
        public string Profession { get; set; }
        public virtual List<ManyToMany.Animal> Animals { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
