using GraphQLDemo.DbAcess;
using GraphQLDemo.Models;

namespace GraphQLDemo.Extensions
{
    public static class SeedData
    {
        public static void EnsurePopulated(this IApplicationBuilder app)
        {
            EnsurePopulated(
            app.ApplicationServices.GetRequiredService<UserDbContext>());
        }
        public static void EnsurePopulated(UserDbContext context)
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
            else
            {
                System.Console.WriteLine("Seed Data Not Required...");
            }
        }
    }
}
