using Hayvanat_Bahçesi.ORM.Entity.TableSplitting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity.EntitySplitting
{
    [Table("Users")]
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}