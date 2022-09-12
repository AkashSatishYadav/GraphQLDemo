using GraphQL.Types;

namespace GraphQLDemo.GraphQlTypes
{
    public class UserInputType : InputObjectGraphType
    {
        public UserInputType()
        {
            Name = "UserInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("address");
            Field<NonNullGraphType<IntGraphType>>("age");
            Field<NonNullGraphType<IntGraphType>>("phone");
        }
    }
}
