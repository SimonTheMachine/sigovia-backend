using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sigovia_backend.api.Data;
using sigovia_backend.api.Dtos.Booking;
using sigovia_backend.api.Interfaces;
using sigovia_backend.api.Mappers;
using sigovia_backend.api.Models;

namespace sigovia_backend.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController: ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly IBookingRepository _bookingRepository;
        public BookingController(ApplicationDBContext context, IBookingRepository bookingRepository)
        {
            _context = context;
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookings = await _bookingRepository.GetAllAsync();
            return Ok(bookings);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookingDto booking)
        {
            var bookingModel = booking.ToBookingFromCreateDTO();
            await _bookingRepository.CreateAsync(bookingModel);
            return Ok(booking);
        }
    }
}