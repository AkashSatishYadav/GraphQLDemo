using GraphQL;
using GraphQL.Types;
using GraphQLDemo.Contacts;
using GraphQLDemo.GraphQlTypes;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQlMutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation(IUserRepository repository)
        {
            Field<UserType>("CreateUser",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserInputType>> { Name = "user" }),
                resolve: context =>
                {
                    var user = context.GetArgument<User>("user");
                    return repository.CreateUser(user);
                });
        }
    }
}
