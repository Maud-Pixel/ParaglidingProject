using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public int Year { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
