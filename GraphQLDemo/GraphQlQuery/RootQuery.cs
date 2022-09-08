using GraphQL;
using GraphQL.Types;
using GraphQLDemo.Contacts;
using GraphQLDemo.GraphQlTypes;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQlQuery
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(IUserRepository repository)
        {
            Field<ListGraphType<UserType>>("users", resolve:
                context => repository.GetAllUsers());
            Field<UserType>("user", arguments: new QueryArguments(
            new QueryArgument<IdGraphType> { Name = "id" }
            ), resolve: context =>
            {
                var id = context.GetArgument<int>("id");
                return repository.GetUser(id);
            });
        }
    }
}
