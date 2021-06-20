using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Entity
{
    public class Visitor
    {
        public int VisitorID { get; set; }
        public string VisitorName { get; set; }
        public string VisitDate { get; set; }
        public string DayOfVisit { get; set; }
        public string VisitTime { get; set; }
        public string PaidTicket { get; set; }
    }
}
