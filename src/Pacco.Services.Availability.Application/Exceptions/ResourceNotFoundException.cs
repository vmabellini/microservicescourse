using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Application.Exceptions
{
    public class ResourceNotFoundException : AppException
    {
        public ResourceNotFoundException(Guid id) : base(message: $"Resource with ID: '{id}' not found.")
        {
        }
    }
}