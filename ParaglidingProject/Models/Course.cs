using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Participation> Participations { get; set; }
        public ICollection<Teaching> Teachings { get; set; }
        public License License { get; set; }
    }
}
