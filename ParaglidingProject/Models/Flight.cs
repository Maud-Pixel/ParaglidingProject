using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Flight
    {
        public int ID { get; set; }

        public DateTime FlightDate { get; set; }

        public float FlightDuration { get; set; }
        public int PilotID { get; set; }
        public int ParaglidingID { get; set; }
        public int LandingSiteID { get; set; }
        public int TakeOffSiteID { get; set; }
        public Pilot Pilot { get; set; }
        public Paragliding Paragliding { get; set; }
        public LandingSite LandingSite { get; set; }
        public TakeOffSite TakeOffSites { get; set; }


    }
}
