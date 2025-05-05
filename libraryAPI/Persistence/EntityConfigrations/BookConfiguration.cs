using libraryAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace libraryAPI.Persistence.EntityConfigrations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(255);


            //Relations
            builder.HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId); 
            
            
            builder.HasMany(b => b.BorrowRecord)
                .WithOne(bw => bw.Book)
                .HasForeignKey(b => b.BookId);

        }
    }
}
