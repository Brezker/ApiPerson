using ApiPerson.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPerson.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Person> People { get; set; }

    }
}
