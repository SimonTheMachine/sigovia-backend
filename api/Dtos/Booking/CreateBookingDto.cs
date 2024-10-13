using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sigovia_backend.api.Dtos.Booking
{
    public class CreateBookingDto
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        public required DateTime StartDate { get; set; }
        [Required]
        public required DateTime EndDate { get; set; }
    }
}