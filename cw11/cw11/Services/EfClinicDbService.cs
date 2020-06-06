using System.Collections.Generic;
using System.Linq;
using cw11.Models;

namespace cw11.Services
{
    public class EfClinicDbService : IClinicDbService
    {
        private readonly ClinicDbContext _context;

        public EfClinicDbService(ClinicDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetDoctors() => _context.Doctors.ToList();

        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            var retrievedDoctor = _context.Doctors.FirstOrDefault(d => d.IdDoctor == doctor.IdDoctor);
            if (retrievedDoctor == default) throw new ObjectNotFoundException();
            retrievedDoctor.FirstName = doctor.FirstName;
            retrievedDoctor.LastName = doctor.LastName;
            retrievedDoctor.Email = doctor.Email;
            _context.SaveChanges();
        }

        public void RemoveDoctor(int doctorId)
        {
            var retrievedDoctor = _context.Doctors.FirstOrDefault(d => d.IdDoctor == doctorId);
            if(retrievedDoctor == default) throw new ObjectNotFoundException();
            
            _context.Doctors.Remove(retrievedDoctor);
            _context.SaveChanges();
        }
    }
}