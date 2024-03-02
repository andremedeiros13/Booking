using Booking.Application.Common.Interfaces;
using Booking.Application.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Booking.Application.Common.Models
{
    public class BookingMockService : IBookingMockService
    {
        private readonly IConfiguration _configuration;
        public BookingMockService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<BookingDto> GetMockBookings()
        {
            var bookings = new List<BookingDto>();

            var bookingData = new List<BookingDto>
{
            new BookingDto
            {
                BookingId = 2,
                StartDate = new DateTime(2024, 3, 2),
                EndDate = new DateTime(2024, 3, 6),
                CustomerId = 2,
                VehicleId = 1,
                RatingStatus = false,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 3,
                StartDate = new DateTime(2024, 3, 3),
                EndDate = new DateTime(2024, 3, 7),
                CustomerId = 3,
                VehicleId = 2,
                RatingStatus = true,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 4,
                StartDate = new DateTime(2024, 3, 4),
                EndDate = new DateTime(2024, 3, 8),
                CustomerId = 4,
                VehicleId = 3,
                RatingStatus = false,
                CommentStatus = false,
            },
            new BookingDto
            {
                BookingId = 5,
                StartDate = new DateTime(2024, 3, 5),
                EndDate = new DateTime(2024, 3, 9),
                CustomerId = 5,
                VehicleId = 4,
                RatingStatus = true,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 6,
                StartDate = new DateTime(2024, 3, 6),
                EndDate = new DateTime(2024, 3, 10),
                CustomerId = 6,
                VehicleId = 5,
                RatingStatus = false,
                CommentStatus = false,
            },
            new BookingDto
            {
                BookingId = 7,
                StartDate = new DateTime(2024, 3, 7),
                EndDate = new DateTime(2024, 3, 11),
                CustomerId = 3,
                VehicleId = 6,
                RatingStatus = true,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 8,
                StartDate = new DateTime(2024, 3, 8),
                EndDate = new DateTime(2024, 3, 12),
                CustomerId = 5,
                VehicleId = 4,
                RatingStatus = false,
                CommentStatus = false,
            },
            new BookingDto
            {
                BookingId = 9,
                StartDate = new DateTime(2024, 3, 9),
                EndDate = new DateTime(2024, 3, 13),
                CustomerId = 3,
                VehicleId = 2,
                RatingStatus = true,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 10,
                StartDate = new DateTime(2024, 3, 10),
                EndDate = new DateTime(2024, 3, 14),
                CustomerId = 7,
                VehicleId = 3,
                RatingStatus = false,
                CommentStatus = false,
            },
            new BookingDto
            {
                BookingId = 11,
                StartDate = new DateTime(2024, 3, 11),
                EndDate = new DateTime(2024, 3, 15),
                CustomerId = 1,
                VehicleId = 8,
                RatingStatus = true,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 12,
                StartDate = new DateTime(2024, 3, 12),
                EndDate = new DateTime(2024, 3, 16),
                CustomerId = 5,
                VehicleId = 9,
                RatingStatus = false,
                CommentStatus = false,
            },
            new BookingDto
            {
                BookingId = 13,
                StartDate = new DateTime(2024, 3, 13),
                EndDate = new DateTime(2024, 3, 17),
                CustomerId = 6,
                VehicleId = 5,
                RatingStatus = true,
                CommentStatus = true,
            },
            new BookingDto
            {
                BookingId = 14,
                StartDate = new DateTime(2024, 3, 14),
                EndDate = new DateTime(2024, 3, 18),
                CustomerId = 2,
                VehicleId = 3,
                RatingStatus = false,
                CommentStatus = false,
            },
            new BookingDto
            {
                BookingId = 15,
                StartDate = new DateTime(2024, 3, 15),
                EndDate = new DateTime(2024, 3, 19),
                CustomerId = 7,
                VehicleId = 9,
                RatingStatus = true,
                CommentStatus = true,
            }
        };



            var customerData = new List<CustomerDto>
            {
                new CustomerDto { CustomerId = 1, Name = "Jane Smith" },
                new CustomerDto { CustomerId = 2, Name = "Michael Johnson" },
                new CustomerDto { CustomerId = 3, Name = "Emily Brown" },
                new CustomerDto { CustomerId = 4, Name = "David Lee" },
                new CustomerDto { CustomerId = 5, Name = "Sarah Williams" },
                new CustomerDto { CustomerId = 6, Name = "Robert Jones" },
                new CustomerDto { CustomerId = 7, Name = "Amanda Davis" }
            };

            var vehicleData = new List<VehicleDto>
            {
                new VehicleDto { VehicleId = 1, Model = "Toyota Corolla" },
                new VehicleDto { VehicleId = 2, Model = "Honda Civic" },
                new VehicleDto { VehicleId = 3, Model = "Ford F-150" },
                new VehicleDto { VehicleId = 4, Model = "Chevrolet Silverado" },
                new VehicleDto { VehicleId = 5, Model = "Volkswagen Golf" },
                new VehicleDto { VehicleId = 6, Model = "BMW 3 Series" },
                new VehicleDto { VehicleId = 7, Model = "Mercedes-Benz C-Class" },
                new VehicleDto { VehicleId = 8, Model = "Audi A4" },
                new VehicleDto { VehicleId = 9, Model = "Jeep Wrangler" }
            };

            foreach (var bookingDto in bookingData)
            {
                var customer = customerData.Find(c => c.CustomerId == bookingDto.CustomerId);
                var vehicle = vehicleData.Find(v => v.VehicleId == bookingDto.VehicleId);

                bookingDto.Customer = customer;
                bookingDto.Vehicle = vehicle;

                bookings.Add(bookingDto);
            }
            return bookings;
        }

        public BookingDto GetBookingById(int bookingId)
        {
            var allBookings = GetMockBookings();
            return allBookings.FirstOrDefault(b => b.BookingId == bookingId);
        }
    }
}
