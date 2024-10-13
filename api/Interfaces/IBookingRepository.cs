using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sigovia_backend.api.Models;

namespace sigovia_backend.api.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetAllAsync();

        Task<Booking> CreateAsync(Booking booking); 
    }
}