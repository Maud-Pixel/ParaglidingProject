using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Models
{
    public enum Role
    {
        Président,
        Trésorier,
        Secrétaire
    }
    public class Pilot
    {
        public int PilotID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }

        public string PhoneNumber { get; set; }

        public int Weight { get; set; }

        public Role? Role { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public ICollection<Landing> Landings { get; set; }
        public ICollection<TakeOff> TakeOffs { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Participation> Participations { get; set; }
        public ICollection<Teaching> Teachings { get; set; }
        public ICollection<Obtaining> Obtainings { get; set; }
    }
}
