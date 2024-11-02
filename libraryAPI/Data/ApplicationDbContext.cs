using libraryAPI.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace libraryAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option):base(option) {  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationship: One-to-Many between Author and Book
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Book)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
           .HasOne(b => b.Category)
           .WithMany(c => c.Books)
           .HasForeignKey(b => b.CategoryId);


            modelBuilder.Entity<BorrowRecord>()
             .HasOne(br => br.Member)
             .WithMany(m => m.BorrowRecords)
             .HasForeignKey(br => br.MemberId);

            // Relationship: One-to-Many between Book and BorrowRecord
            modelBuilder.Entity<BorrowRecord>()
                .HasOne(br => br.Book)
                .WithMany(b => b.BorrowRecord)
                .HasForeignKey(br => br.BookId);
        }


        public  DbSet<Author> Authors { get; set; }
       public  DbSet<Book> Books{ get; set; }
       public  DbSet<Category> Categories { get; set; }
       public  DbSet<BorrowRecord>  BorrowRecords  { get; set; }
       public  DbSet<Member> Members  { get; set; }


        
    }
}



