using Hayvanat_Bahçesi.ORM.Entity.TableSplitting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.ManyToMany
{
    public enum Gender
    {
        Male, Female
    }

    public class Zookeeper
    {
        public int ZookeeperID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string KindOfAnimalCaredFor { get; set; }
        public virtual List<Animal> Animals { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
