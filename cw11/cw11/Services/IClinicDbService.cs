using System;
using System.Collections.Generic;
using cw11.Models;

namespace cw11.Services
{
    public interface IClinicDbService
    {
        IEnumerable<Doctor> GetDoctors();
        void AddDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void RemoveDoctor(int doctorId);
    }
    public class ObjectNotFoundException : Exception {}
}