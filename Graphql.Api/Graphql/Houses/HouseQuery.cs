using GraphQL;
using Graphql.Api.GraphQL.Houses.Types;
using Graphql.Api.Repositories;
using GraphQL.Types;

namespace Graphql.Api.GraphQL.Houses
{
    public class HouseQuery : ObjectGraphType
    {
        public HouseQuery(IHouseRepository houseRepository)
        {
            Field<HouseType>("house",
                arguments:
                new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "id"}),
                resolve: context =>
                    houseRepository.GetById(context.GetArgument<int>("id"))
            );

            Field<ListGraphType<HouseType>>("houses",
                resolve: context => 
                    houseRepository.GetAll());
        }
     }
 }