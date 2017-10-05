using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Watchlist.Models.Mappings
{
    public class MovieMapping
    {
        public MovieMapping(EntityTypeBuilder<Movie> builder )
        {
            builder
            .ToTable("Movies");

            builder
            .HasKey(m => m.Id);

            builder
            .Property(m => m.Id)
            .ValueGeneratedOnAdd();

            builder
            .Property(m => m.title)
            .IsRequired()
            .HasMaxLength(255);

            builder
            .HasOne(m => m.User)
            .WithMany(U => U.Movies)
            .HasForeignKey(m => m.UserId);

            // builder
            // .Property(m => m.Watched)
            // .;

            // builder
            // .Property(m => m.Image)
            // .IsRequired()
            // .HasMaxLength(600);

            // builder
            // .Property(m => m.Grade)
            // .HasMaxLength(200);

            // builder
            // .Property(m => m.)






            
        }
    }
}