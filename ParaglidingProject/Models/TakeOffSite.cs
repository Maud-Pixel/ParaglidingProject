using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class TakeOffSite
    {
        public int TakeOfSiteID { get; set; }
        public string Name { get; set; }
        public string Orientation { get; set; }
        public string DescriptionTakeOff { get; set; }
        public int RequiseLevel { get; set; }
        public ICollection<TakeOff> TakeOffs { get; set; }
    }
}
