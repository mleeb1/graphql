using CarvedRock.Api.Data;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class PolicyTypeEnumType: EnumerationGraphType<PolicyTypeEnum>
    {
        public PolicyTypeEnumType()
        {
            Name = "Type";
            Description = "The type of policy";
        }
    }
}
