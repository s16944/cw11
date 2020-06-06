using System;
using System.Collections.Generic;

namespace cw11.Models
{
    public static class DataGenerator
    {
        public static IEnumerable<Doctor> GenerateDoctors() => new[]
        {
            new Doctor {IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jankowalski@gmail.com"},
            new Doctor {IdDoctor = 2, FirstName = "Anna", LastName = "Nowak", Email = "annanowak@gmail.com"}
        };

        public static IEnumerable<Patient> GeneratePatients() => new[]
        {
            new Patient
            {
                IdPatient = 1, FirstName = "Michał", LastName = "Wiśniewski", Birthdate = new DateTime(1965, 12, 1)
            },
            new Patient
            {
                IdPatient = 2, FirstName = "Tomasz", LastName = "Wójcik", Birthdate = new DateTime(1991, 05, 23)
            }
        };

        public static IEnumerable<Prescription> GeneratePrescriptions() => new[]
        {
            new Prescription
            {
                IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdPatient = 1,
                IdDoctor = 1
            },
            new Prescription
            {
                IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdPatient = 1,
                IdDoctor = 2
            },
            new Prescription
            {
                IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdPatient = 2,
                IdDoctor = 2
            },
            new Prescription
            {
                IdPrescription = 4, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdPatient = 2,
                IdDoctor = 1
            }
        };

        public static IEnumerable<Medicament> GenerateMedicaments() => new[]
        {
            new Medicament {IdMedicament = 1, Name = "Noliprel", Description = "Lek na nadciśnienie", Type = "Na receptę"},
            new Medicament {IdMedicament = 2, Name = "Clatra", Description = "Lek na alergię", Type = "Na receptę"}
        };

        public static IEnumerable<PrescriptionMedicament> GeneratePrescriptionMedicaments() => new[]
        {
            new PrescriptionMedicament {IdMedicament = 1, IdPrescription = 1, Dose = 1, Details = "Rano"},
            new PrescriptionMedicament {IdMedicament = 2, IdPrescription = 1, Dose = 2, Details = "Rano i wieczorem"},
            new PrescriptionMedicament {IdMedicament = 1, IdPrescription = 2, Dose = 1, Details = "Wieczorem"},
            new PrescriptionMedicament {IdMedicament = 2, IdPrescription = 3, Dose = 3, Details = "Co 4 h"},
            new PrescriptionMedicament {IdMedicament = 2, IdPrescription = 4, Dose = 4, Details = "Po każdym posiłku"}
        };
    }
}