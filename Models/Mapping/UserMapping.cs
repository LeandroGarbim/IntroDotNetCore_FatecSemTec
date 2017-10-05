using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Watchlist.Models.Mappings
{
    public class UserMapping
    {
        public UserMapping(EntityTypeBuilder<User> builder)
        {
            //ToTable é opcional, serve só pra mudar o nome.
            builder
            .ToTable("Users");

            //Também é opcional pois quando se tem "ida" na definição o EF já reconhece como ID.
            builder
            .HasKey(u => u.Id);

            builder
            .Property(u => u.Id)
            .ValueGeneratedOnAdd();

            builder
            .Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(200);

            builder
            .Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(255);

            builder
            .HasMany(u => u.Movies)
            .WithOne(m => m.User)
            .HasForeignKey(m => m.UserId);

        }
    }
}
