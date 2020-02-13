using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Obtaining
    {
        public int ID { get; set; }
        public int PilotID { get; set; }
        public int LicenseID { get; set; }
        public DateTime? ObtainingDate { get; set; }
        public bool IsSucced { get; set; }
        public Pilot Pilot { get; set; }
        public License License { get; set; }
        
    }
}
