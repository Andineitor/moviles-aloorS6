using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aloorS6.Model
{
    public class Booking
    {
        public long BookingId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; } = false;

        public bool Deleted { get; set; } = false;
    }
}
