﻿using GraphQLDemo.Contacts;
using GraphQLDemo.Context;
using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.users.ToList();
        }

        public User GetUser(int id)
        {
            return _context.users.Find(id);
        }
    }
}
