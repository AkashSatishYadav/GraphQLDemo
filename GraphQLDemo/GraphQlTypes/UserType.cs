using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQlTypes
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.Address);
            Field(x => x.Phone);
        }
    }
}
