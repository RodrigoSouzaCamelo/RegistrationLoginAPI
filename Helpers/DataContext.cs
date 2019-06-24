using Microsoft.EntityFrameworkCore;
using RegistrationLoginAPI.Entities;

namespace RegistrationLoginAPI.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}