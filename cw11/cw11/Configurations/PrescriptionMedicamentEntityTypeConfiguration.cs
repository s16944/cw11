using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class PrescriptionMedicamentEntityTypeConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.ToTable("Prescription_Medicament");
            
            builder.HasKey(e => new {e.IdMedicament, e.IdPrescription});

            builder.Property(e => e.Details)
                .IsRequired();
            
            builder.HasOne(e => e.Prescription)
                .WithMany(prescription => prescription.PrescriptionMedicaments)
                .HasForeignKey(e => e.IdPrescription);
            
            builder.HasOne(e => e.Medicament)
                .WithMany(medicament => medicament.PrescriptionMedicaments)
                .HasForeignKey(e => e.IdMedicament);
        }
    }
}