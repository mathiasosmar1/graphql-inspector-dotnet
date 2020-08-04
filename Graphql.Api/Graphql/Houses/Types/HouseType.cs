using Graphql.Api.Entities;
using GraphQL.Types;

namespace Graphql.Api.GraphQL.Houses.Types
{
    public sealed class HouseType: ObjectGraphType<House>
    {
        public HouseType()
        {
            Name = "House";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("House Id");
            Field(x => x.Number).Description("House number");
            // Field(x => x.Address).Description("House address");
            Field(x => x.OwnerName).Description("House owner");
        }
    }
}