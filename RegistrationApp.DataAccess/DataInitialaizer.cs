using RegistrationApp.Services;
using System.Data.Entity;

namespace RegistrationApp.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context) => context.Users.Add(new Models.User
        {
            Login = "Admin",
            Password = SecurityHasher.HashPassword("Admin")
        });
    }
}
