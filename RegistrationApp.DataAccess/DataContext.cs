namespace RegistrationApp.DataAccess
{
    using RegistrationApp.Models;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<User> Users { get; set; }

    }
}