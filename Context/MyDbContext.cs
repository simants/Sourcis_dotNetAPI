using Microsoft.EntityFrameworkCore;
using Sourcis_dotNetAPI.Models;

namespace Sourcis_dotNetAPI.Context{
    public class MyDbContext : DbContext{
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        public DbSet<Person> Person { get; set; }
        public DbSet<Car> Car { get; set; }
    }

}

