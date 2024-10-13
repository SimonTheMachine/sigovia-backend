using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sigovia_backend.api.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required DateTime StartDate { get; set; }

        public required DateTime EndDate { get; set; }
    }
}