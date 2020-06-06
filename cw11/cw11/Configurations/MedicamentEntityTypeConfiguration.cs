using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class MedicamentEntityTypeConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament);
            builder.Property(e => e.IdMedicament)
                .UseIdentityColumn();

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.Type)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}