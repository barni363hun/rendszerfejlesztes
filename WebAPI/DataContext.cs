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
        public DbSet<ClassLibrary.Model.Task> Tasks => Set<ClassLibrary.Model.Task>();
        public DbSet<Project_Type> Project_Types => Set<Project_Type>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Manager> Managers => Set<Manager>();
        public DbSet<Developer> Developers => Set<Developer>();
    }
}
