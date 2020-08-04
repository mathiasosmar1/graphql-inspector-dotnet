using Graphql.Api.GraphQL;
using Graphql.Api.Repositories;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Graphql.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddScoped<AppSchema>();
            services.TryAddScoped<IHouseRepository, HouseRepository>();

            services.AddGraphQL()
                .AddSystemTextJson(
                    deserializerSettings => { }, 
                    serializerSettings => { }
                    )
                .AddDataLoader()
                .AddGraphTypes(typeof(AppSchema), ServiceLifetime.Scoped);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGraphQL<AppSchema>("/graphql");
            
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                GraphQLEndPoint = "/graphql",
                Path = "/api-docs/graphql"
            });
        }
    }
}