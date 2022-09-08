using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQlTypes
{
    public class AccountType : ObjectGraphType<Account>
    {
        public AccountType()
        {
            Field(x => x.Id);
            Field(x => x.OwnerId);
            Field<AccountEnumType>("Type", "Enumeration for the account type object.");
        }
    }
}
