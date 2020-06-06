using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class PatientEntityTypeConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient);
            builder.Property(e => e.IdPatient)
                .UseIdentityColumn();

            builder.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.Birthdate)
                .IsRequired()
                .HasColumnType("Date");
        }
    }
}