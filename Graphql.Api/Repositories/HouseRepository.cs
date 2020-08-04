using System.Collections.Generic;
using System.Linq;
using Graphql.Api.Entities;
using Graphql.Api.Repositories.Data;

namespace Graphql.Api.Repositories
{
    public class HouseRepository: IHouseRepository
    {
        public House GetById(int id) => 
            StaticHouseData.ListHouse.FirstOrDefault(x => x.Id.Equals(id));

        public IEnumerable<House> GetAll() => StaticHouseData.ListHouse;
    }
}