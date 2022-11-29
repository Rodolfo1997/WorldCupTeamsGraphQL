using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupTeamsGraphQL.GraphQL;
using WorldCupTeamsGraphQL.GraphQL.Types;
using WorldCupTeamsGraphQL.Service;
using WorldCupTeamsGraphQL.Services;

namespace WorldCupTeamsGraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
               .AddGraphQLServer()
               .AddType<TeamsTypes>()
               .AddType<PlayersTypes>()
               .AddQueryType<Query>();

            services.AddSingleton<IWorldCupService, WorldCupService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions
                {
                    QueryPath = "/api",
                    Path = "/graphql"
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(x => x.MapGraphQL("/api"));

        }
    }
}
