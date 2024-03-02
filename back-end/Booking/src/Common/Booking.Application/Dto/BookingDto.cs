using System;

namespace Booking.Application.Dto
{
    public class BookingDto
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public bool? RatingStatus { get; set; }
        public bool? CommentStatus { get; set; }

        public VehicleDto Vehicle { get; set; }
        public CustomerDto Customer { get; set; }

    }
}
