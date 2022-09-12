using GraphQLDemo.Models;

namespace GraphQLDemo.Contacts
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(int id);
        User CreateUser(User user);
    }
}
