using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class PrescriptionEntityTypeConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription);
            builder.Property(e => e.IdPrescription)
                .UseIdentityColumn();

            builder.Property(e => e.Date)
                .IsRequired()
                .HasColumnType("Date");
            
            builder.Property(e => e.DueDate)
                .IsRequired()
                .HasColumnType("Date");

            builder.HasOne(e => e.Doctor)
                .WithMany(doctor => doctor.Prescriptions)
                .HasForeignKey(e => e.IdDoctor);
            
            builder.HasOne(e => e.Patient)
                .WithMany(patient => patient.Prescriptions)
                .HasForeignKey(e => e.IdPatient);
        }
    }
}