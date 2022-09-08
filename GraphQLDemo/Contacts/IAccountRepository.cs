using GraphQLDemo.Models;

namespace GraphQLDemo.Contacts
{
    public interface IAccountRepository
    {
        List<Account> GetAccountsByOwnerId(int id);
    }
}
