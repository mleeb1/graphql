using CarvedRock.Api.Data.Entities;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class PolicyType: ObjectGraphType<Policy>
    {
        public PolicyType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field<PolicyTypeEnumType>("Type", "The type of policy");
        }
    }
}
