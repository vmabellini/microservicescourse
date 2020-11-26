using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using Pacco.Services.Availability.Application.Commands;
using Pacco.Services.Availability.Application.DTO;
using Pacco.Services.Availability.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacco.Services.Availability.Api.Controllers
{
    [ApiController]
    [Route(template: "api/[controller]")]
    public class ResourcesController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public ResourcesController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet(template: "{resourceId}")]
        public async Task<ActionResult<ResourceDto>> Get([FromRoute] GetResource query)
        {
            var resource = await _queryDispatcher.QueryAsync(query);
            if (resource is { })
            {
                return resource;
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> Post(AddResource command)
        {
            await _commandDispatcher.SendAsync(command);

            return Created($"api/resources/{command.ResourceId}", null);
        }
    }
}