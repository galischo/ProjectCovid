using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IPatientDal
    {
        public List<Patient> GetAllPatients();
        public void AddPatient(Patient patient);
        public Patient GetPatientById(string Id);
        public bool AddpatientVaccine(string tz, Corona corona);
    }
}
