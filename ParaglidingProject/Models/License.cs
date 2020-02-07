using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class License
    {
        public int LicenseID { get; set; }
        public string Title { get; set; }
        public ICollection<Obtaining> Obtainings { get; set; }
        public ICollection<Course> Courses { get; set; }
        public Level Level { get; set; }
    }
}
