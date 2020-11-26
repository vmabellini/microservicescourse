﻿using System.Threading.Tasks;
using Convey;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Pacco.Services.Availability.Application;
using Pacco.Services.Availability.Infrastructure.Mongo;

namespace Pacco.Services.Availability.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
            => await CreateWebHostBuilder(args)
                .Build()
                .RunAsync();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
            => WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddControllers().AddNewtonsoftJson();
                    services
                        .AddConvey()
                        .AddInfrastructure()
                        .AddApplication()
                        .Build();
                })
                .Configure(app =>
                {
                    app.UseInfrastructure();
                    app.UseRouting()
                        .UseEndpoints(e => e.MapControllers());
                });
    }
}