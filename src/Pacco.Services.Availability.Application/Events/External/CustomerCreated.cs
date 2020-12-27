using Convey.CQRS.Events;
using Convey.MessageBrokers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Application.Events.External
{
    //Indica que a mensagem será obtida da exchange customers
    [Message(exchange: "customers")]
    public class CustomerCreated : IEvent
    {
        public Guid CustomerId { get; }

        public CustomerCreated(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}