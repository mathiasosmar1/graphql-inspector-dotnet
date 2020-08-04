using System.Collections.Generic;
using Graphql.Api.Entities;

namespace Graphql.Api.Repositories.Data
{
    public static class StaticHouseData
    {
        public static IEnumerable<House> ListHouse => new List<House>
        {
            new House
            {
                Id = 1,
                Address = "Street One",
                Number = 100,
                OwnerName = "John"
            },
            
            new House
            {
                Id = 2,
                Address = "Street Two",
                Number = 200,
                OwnerName = "Paul"
            },
            new House
            {
                Id = 3,
                Address = "Street Tree",
                Number = 300,
                OwnerName = "Mary"
            }
        };
    }
}