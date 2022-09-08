using GraphQLDemo.Context;
using GraphQLDemo.Enums;
using GraphQLDemo.Models;

namespace GraphQLDemo.Extensions
{
    public static class SeedData
    {
        public static void EnsurePopulated(this IApplicationBuilder app)
        {
            EnsurePopulated(
            app.ApplicationServices.GetRequiredService<ApplicationContext>());
        }
        public static void EnsurePopulated(ApplicationContext context)
        {
            if (!context.users.Any())
            {
                System.Console.WriteLine("Creating Seed Data...");
                context.users.AddRange(
                new User() { Id = 1, Name = "Watersports", Age = 24, Address = "Bangalore", Phone = 900 },
                new User() { Id = 2, Name = "Wet", Age = 26, Address = "Mumbai", Phone = 800 },
                new User() { Id = 3, Name = "Cold", Age = 27, Address = "Nagpur", Phone = 700 }
                );
                context.SaveChanges();
            }
            if(!context.accounts.Any())
            {
                System.Console.WriteLine("Creating Seed Data...");
                context.accounts.AddRange(
                new Account() { Id = 100, Type = TypeOfAccount.SAVINGS, OwnerId = 1 },
                new Account() { Id = 200, Type = TypeOfAccount.CURRENT, OwnerId = 1 },
                new Account() { Id = 300, Type = TypeOfAccount.SAVINGS, OwnerId = 1 },
                new Account() { Id = 400, Type = TypeOfAccount.SAVINGS, OwnerId = 2 },
                new Account() { Id = 500, Type = TypeOfAccount.CURRENT, OwnerId = 2 },
                new Account() { Id = 600, Type = TypeOfAccount.SAVINGS, OwnerId = 2 },
                new Account() { Id = 700, Type = TypeOfAccount.SAVINGS, OwnerId = 3 },
                new Account() { Id = 800, Type = TypeOfAccount.CURRENT, OwnerId = 3 },
                new Account() { Id = 900, Type = TypeOfAccount.SAVINGS, OwnerId = 3 }
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Seed Data Not Required...");
            }
        }
    }
}
