using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Landing
    {
        public int LandingID { get; set; }
        public int PilotID { get; set; }
        public int LandingSiteID { get; set; }
        public Pilot Pilot { get; set; }
        public LandingSite LandingSite { get; set; }
    }
}

