using GraphQL;
using GraphQL.Types;
using GraphQLDemo.DbAcess;
using GraphQLDemo.GraphQlTypes;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQlQuery
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(UserDbContext context)
        {
            Field<ListGraphType<UserType>>("users", resolve:
                _context => context.users.ToList());
            Field<UserType>("user", arguments: new QueryArguments(
            new QueryArgument<IdGraphType> { Name = "id" }
            ), resolve: _context =>
            {
                var id = _context.GetArgument<int>("id");
                return context.users.Find(id);
            });
        }
    }
}
