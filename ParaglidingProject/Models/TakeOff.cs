using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class TakeOff
    {
        public int TakeOffID { get; set; }
        public int PilotID { get; set; }
        public int TakeOffSiteID { get; set; }
        public Pilot Pilot { get; set; }
        public TakeOffSite TakeOffSite { get; set; }
    }
}
