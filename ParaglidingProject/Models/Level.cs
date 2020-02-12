using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Level
    {
        public int LevelID { get; set; }
        public string Name { get; set; }
        public ICollection<string> Skills { get; set; }
        public ICollection<License> Licenses { get; set; }
        public ICollection<LandingSite> LandingSite { get; set; }
    }
}
