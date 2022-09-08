using GraphQLDemo.Contacts;
using GraphQLDemo.Context;
using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _context;

        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Account> GetAccountsByOwnerId(int id)
        {
            return _context.accounts.Where(a => a.OwnerId == id).ToList();
        }
    }
}
