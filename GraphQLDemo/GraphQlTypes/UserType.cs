using GraphQL.Types;
using GraphQLDemo.Contacts;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQlTypes
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType(IAccountRepository repository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.Address);
            Field(x => x.Phone);
            Field<ListGraphType<AccountType>>("accounts", resolve: context => repository.GetAccountsByOwnerId(context.Source.Id));
        }
    }
}
