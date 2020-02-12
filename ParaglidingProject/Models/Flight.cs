﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Flight
    {
        public int FlightID { get; set; }

        public DateTime FlightDate { get; set; }

        public float FlightDuration { get; set; }
        public Pilot Pilot { get; set; }
        public Paragliding Paragliding { get; set; }
        public LandingSite LandingSite { get; set; }
        public TakeOffSite TakeOffSites { get; set; }


    }
}
