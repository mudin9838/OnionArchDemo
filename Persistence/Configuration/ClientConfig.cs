using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.LastName)
                    .HasMaxLength(80)
                    .IsRequired();

            builder.Property(p => p.DateOfBirth)
                   .IsRequired();

            builder.Property(p => p.PhoneNumber)
                     .HasMaxLength(9)
                     .IsRequired();

            builder.Property(p => p.Email)
                    .HasMaxLength(9);

            builder.Property(p => p.Address)
                    .HasMaxLength(120)
                    .IsRequired();


            builder.Property(p => p.CreatedBy)
                   .HasMaxLength(30);


            builder.Property(p => p.LastModifiedBy)
                  .HasMaxLength(30);

        }
    }
}
