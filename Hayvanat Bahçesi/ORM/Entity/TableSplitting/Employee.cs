using Hayvanat_Bahçesi.ORM.Entity.ConditionalMapping;
using Hayvanat_Bahçesi.ORM.Entity.EntitySplitting;
using Hayvanat_Bahçesi.ORM.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.TableSplitting
{
    public enum Title
    {
        TicketClerk, CleaningStaff, Manager, TechnicalServicePerson, Plumber, Secretary, Guard, SecurityGuard
    }
    public enum GenderE
    {
        Male, Female
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderE GenderE { get; set; }
        public Title Title { get; set; }
        public virtual EmployeeContactDetail EmployeeContactDetail { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
        public virtual List<Veterinary> Veterinaries {get;set;}
        public virtual List<Zookeeper> Zookeepers { get; set; }
    }

    public class EmployeeContactDetail
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public virtual Employee Employee { get; set; }
        public int EmployeeID { get; set; }
    }

}

