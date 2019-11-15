using CarvedRock.Api.Data.Entities;
using CarvedRock.Api.Repositories;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class OwnerType: ObjectGraphType<Owner>
    {
        public OwnerType(PolicyRepository policyRepository)
        {
            Field(t => t.Id);
            Field(t => t.Name);

            Field<ListGraphType<PolicyType>>(
                "policies",
                resolve: context =>
                {
                    return policyRepository.GetForOwner(context.Source.Id);
                }
            );
        }
    }
}
