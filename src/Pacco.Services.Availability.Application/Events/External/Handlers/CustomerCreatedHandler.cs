using Convey.CQRS.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pacco.Services.Availability.Application.Events.External.Handlers
{
    internal sealed class CustomerCreatedHandler : IEventHandler<CustomerCreated>
    {
        public Task HandleAsync(CustomerCreated @event)
        {
            return Task.CompletedTask;
        }
    }
}