using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Events
{
    public class ReservationCancelled : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; }

        public ReservationCancelled(Resource resource, Reservation reservation)
        {
            Resource = resource;
            Reservation = reservation;
        }
    }
}