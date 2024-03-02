using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Models;
using Booking.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Booking.Application.Bookings.Queries.AllBooksQuery
{
    public class AllBookingQuery : IRequestWrapper<List<BookingDto>>
    {
    }

    public class AllBookingQueryHandler : IRequestHandlerWrapper<AllBookingQuery, List<BookingDto>>
    {
        private readonly IBookingMockService _bookingMockService;
        public AllBookingQueryHandler(IBookingMockService bookingMockService)
        {
            _bookingMockService = bookingMockService;
        }

        public Task<ServiceResult<List<BookingDto>>> Handle(AllBookingQuery request, CancellationToken cancellationToken)
        {
            var list = _bookingMockService.GetMockBookings();

            return list.Count > 0 ? Task.FromResult(ServiceResult.Success(list)) : Task.FromResult(ServiceResult.Failed<List<BookingDto>>(ServiceError.NotFound));
        }
    }
}
