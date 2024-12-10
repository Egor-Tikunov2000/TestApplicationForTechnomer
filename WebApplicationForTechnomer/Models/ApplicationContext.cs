//using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace WebApplicationForTechnomer.Models {

public class ApplicationContext : DbContext
 {
     //public DbSet<User> Users { get; set; }
    
     public ApplicationContext (DbContextOptions<> options)
            : base(options)
        {
        }
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=TaskManager; Username=postgres; Password=s5!sz52x");
    }
 }

}