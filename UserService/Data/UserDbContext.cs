using System.Data.Entity;
using UserService.Models;

namespace UserService.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base(nameOrConnectionString: "UserManagement")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<UserDbContext>());
        }

        public DbSet<User> Users { get; set; }
    }
}
