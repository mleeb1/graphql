using CarvedRock.Api.GraphQL.Types;
using CarvedRock.Api.Repositories;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockQuery: ObjectGraphType
    {
        public CarvedRockQuery(OwnerRepository ownerRepository)
        {
            Field<ListGraphType<OwnerType>>(
                "owners", 
                resolve: context => ownerRepository.GetAll()
            );
        }
    }
}
