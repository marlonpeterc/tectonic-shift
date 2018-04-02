using Microsoft.EntityFrameworkCore;
using TectonicShift.API.Models;

namespace TectonicShift.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}