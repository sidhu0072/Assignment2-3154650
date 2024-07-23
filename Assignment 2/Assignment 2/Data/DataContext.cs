using Assignment_2.Entities;

namespace Assignment_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class DbContextOptions<T>
    {
    }

    public class DbContext
    {
        private DbContextOptions<DataContext> options;

        public DbContext(DbContextOptions<DataContext> options)
        {
            this.options = options;
        }
    }
}