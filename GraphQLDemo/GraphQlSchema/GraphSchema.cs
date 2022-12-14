using GraphQL.Types;
using GraphQLDemo.GraphQlMutation;
using GraphQLDemo.GraphQlQuery;

namespace GraphQLDemo.GraphQlSchema
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<RootQuery>();
            Mutation = provider.GetRequiredService<RootMutation>();
        }
    }
}
