using libraryAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace libraryAPI.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions option):base(option) {  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
                   

       }


       public  DbSet<Book> Books{ get; set; }
       public  DbSet<Category> Categories { get; set; }
       public  DbSet<BorrowRecord>  BorrowRecords  { get; set; }


        
    }
}



