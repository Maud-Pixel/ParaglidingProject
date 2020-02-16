using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Subscription
    {
        [Key]
        public int Year { get; set; }
        public decimal Price { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
