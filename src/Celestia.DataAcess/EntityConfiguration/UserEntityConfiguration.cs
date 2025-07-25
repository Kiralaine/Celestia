using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Celestia.DataAccess.Entities;
namespace Celestia.DataAcess.EntityConfiguration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("UserTable");
            builder.HasKey(u => u.UserId);
            builder.Property(u => u.Password).IsRequired();

            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email).IsRequired();

            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(u => u.Username).IsRequired();

        }
    }
}
