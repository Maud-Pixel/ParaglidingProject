﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Paragliding
    {
        public int ParaglidingID { get; set; }
        public DateTime DateOfCommissioning { get; set; }
        public DateTime DateOfLastRevision { get; set; }
        public ModelParagliding ModelParagliding { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
