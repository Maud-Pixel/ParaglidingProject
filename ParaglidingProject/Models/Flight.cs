using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Flight
    {
        public int FlightID { get; set; }

        public int PilotID { get; set; }

        public int ParaglidingID { get; set; }
        
        [DateType(Datetype.Date)]
        public DateTime FlightDate { get; set; }
       
        [DateType(DateType.Time)]
        public DateTime FlightDuration { get; set; }
        // sauf si on inscrit la durée en float 
        public Pilot Pilot { get; set; }

        public Paragliding Paragliding { get; set; }
    }
}
