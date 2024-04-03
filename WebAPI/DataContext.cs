using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { 
        }

        //sql 
        //public DbSet<Project> Projects { get; set; }
        
        //sqlite
        public DbSet<Project> Projects => Set<Project>();
    }
}
