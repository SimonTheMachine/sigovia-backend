using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sigovia_backend.api.Dtos.Booking;
using sigovia_backend.api.Models;

namespace sigovia_backend.api.Mappers
{
    public static class BookingMappers
    {
        public static Booking ToBookingFromCreateDTO(this CreateBookingDto createBookingDto) {
            return new Booking {
                Name = createBookingDto.Name,
                StartDate = createBookingDto.StartDate,
                EndDate = createBookingDto.EndDate
            };
        }
    }
}