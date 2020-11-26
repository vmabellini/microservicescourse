﻿using Convey;
using Convey.CQRS.Queries;
using Convey.Persistence.MongoDB;
using Convey.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Pacco.Services.Availability.Core.Repositories;
using Pacco.Services.Availability.Infrastructure.Exceptions;
using Pacco.Services.Availability.Infrastructure.Mongo.Documents;
using Pacco.Services.Availability.Infrastructure.Mongo.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Infrastructure.Mongo
{
    public static class Extensions
    {
        public static IConveyBuilder AddInfrastructure(this IConveyBuilder builder)
        {
            builder.Services.AddTransient<IResourcesRepository, ResourcesMongoRepository>();

            builder
                .AddErrorHandler<ExceptionToResponseMapper>()
                .AddQueryHandlers()
                .AddInMemoryQueryDispatcher()
                .AddMongo()
                .AddMongoRepository<ResourceDocument, Guid>("resources");

            return builder;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            //Executa os IStartupInitializers
            app.UseConvey();
            //Mapeia os erros ocorridos nos handlers para um formato amigável
            app.UseErrorHandler();

            return app;
        }
    }
}