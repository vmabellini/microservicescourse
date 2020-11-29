using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class CannotExpropriateReservationException : DomainException
    {
        public CannotExpropriateReservationException(Guid resourceId, DateTime dateTime)
            : base(message: $"Cannot expropriate the resource with ID: '{resourceId}' reservation at: {dateTime.Date}")
        {
        }
    }
}