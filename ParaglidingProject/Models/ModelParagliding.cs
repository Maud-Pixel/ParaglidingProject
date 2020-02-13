using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class ModelParagliding
    {
        public int ID { get; set; }
        public string HeightParagliding { get; set; }
        public int MaxWeightPilot { get; set; }
        public int MinWeightPilot { get; set; }
        public string AprovalNumber { get; set; }
        public DateTime AprovalDate { get; set; }
        public ICollection<Paragliding> Paraglidings { get; set; }
    }
}
