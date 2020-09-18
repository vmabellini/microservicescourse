﻿using Pacco.Services.Availability.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pacco.Services.Availability.Core.Repositories
{
    public interface IResourcesRepository
    {
        Task<Resource> GetAsync(AggregateId id);

        Task AddAsync(Resource resource);

        Task UpdateAsync(Resource resource);

        Task DeleteAsync(AggregateId id);
    }
}