using cw11.Configurations;
using Microsoft.EntityFrameworkCore;

namespace cw11.Models
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        public ClinicDbContext()
        {
        }

        public ClinicDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PatientEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionMedicamentEntityTypeConfiguration());
        }
    }
}