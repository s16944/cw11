namespace cw11.Models
{
    public class PrescriptionMedicament
    {
        public int? Dose { get; set; }
        public string Details { get; set; }
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        public Medicament Medicament { get; set; }
        public Prescription Prescription { get; set; }
    }
}