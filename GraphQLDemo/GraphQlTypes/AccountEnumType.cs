using GraphQL.Types;
using GraphQLDemo.Enums;

namespace GraphQLDemo.GraphQlTypes
{
    public class AccountEnumType : EnumerationGraphType<TypeOfAccount>
    {
        public AccountEnumType()
        {
            Name = "Type";
            Description = "Enumeration for the account type object.";
        }
    }
}
