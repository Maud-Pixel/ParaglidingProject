using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int PilotID { get; set; }
        public int SubsciptionID { get; set; }
        public decimal SubscriptionPrice { get; set; }
        public bool IsPay { get; set; }
        public Pilot Pilot { get; set; }
        public Subscription Subscription { get; set; }
    }
}
