using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class LandingSite
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Orientation { get; set; }
        public string DescriptionAproach { get; set; }
        public int LevelID { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public Level RequiseLevel { get; set; }
    }
}
