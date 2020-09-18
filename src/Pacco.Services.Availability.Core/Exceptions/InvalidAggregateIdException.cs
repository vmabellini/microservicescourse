using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class InvalidAggregateIdException : DomainException
    {
        public InvalidAggregateIdException(Guid id) : base($"Invalid aggregate id: '{id.ToString()}'.")
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}