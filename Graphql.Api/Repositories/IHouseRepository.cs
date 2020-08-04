using System.Collections.Generic;
using Graphql.Api.Entities;

namespace Graphql.Api.Repositories
{
    public interface IHouseRepository
    {
        public House GetById(int id);
        public IEnumerable<House> GetAll();
    }
}