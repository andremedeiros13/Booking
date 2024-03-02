using Booking.Application.Dto;
using System.Collections.Generic;

namespace Booking.Application.Common.Interfaces
{
    public interface IBookingMockService
    {
        List<BookingDto> GetMockBookings();
        BookingDto GetBookingById(int bookingId);
    }
}
