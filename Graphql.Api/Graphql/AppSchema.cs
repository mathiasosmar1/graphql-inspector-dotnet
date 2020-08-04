using System;
using Graphql.Api.GraphQL.Houses;
using GraphQL.Types;
using GraphQL.Utilities;

namespace Graphql.Api.GraphQL
{
    public class AppSchema: Schema
    {
        public AppSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<HouseQuery>();
        }
    }
}