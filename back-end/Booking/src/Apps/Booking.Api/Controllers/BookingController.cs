using Booking.Application.Bookings.Queries.AllBooksQuery;
using Booking.Application.Bookings.Queries.BooksQueryById;
using Booking.Application.Common.Models;
using Booking.Application.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Booking.Api.Controllers
{
    /// <summary>
    /// Booking
    /// </summary>
    public class BookingController : BaseApiController
    {
        /// <summary>
        /// Return All Bookings
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ServiceResult<List<BookingDto>>>> AllBookings()
        {
            return Ok(await Mediator.Send(new AllBookingQuery()));
        }

        /// <summary>
        ///Bookings by Id
        /// </summary>
        /// <param name="id"></param>        
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResult<BookingDto>>> GetCityById(int id)
        {
            return Ok(await Mediator.Send(new BookingQueryById { BookingId = id }));
        }
    }
}
