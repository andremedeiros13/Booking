using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Models;
using Booking.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Booking.Application.Bookings.Queries.BooksQueryById
{
    public class BookingQueryById : IRequestWrapper<BookingDto>
    {
        public int BookingId { get; set; }
    }

    public class BookingsQueryByIdHandler : IRequestHandlerWrapper<BookingQueryById, BookingDto>
    {
        private readonly IBookingMockService _bookingMockService;
        public BookingsQueryByIdHandler(IBookingMockService bookingMockService)
        {
            _bookingMockService = bookingMockService;
        }

        public Task<ServiceResult<BookingDto>> Handle(BookingQueryById request, CancellationToken cancellationToken)
        {
            var booking = _bookingMockService.GetBookingById(request.BookingId);

            return booking != null ? Task.FromResult(ServiceResult.Success(booking)) : Task.FromResult(ServiceResult.Failed<BookingDto>(ServiceError.NotFound));
        }
    }
}
