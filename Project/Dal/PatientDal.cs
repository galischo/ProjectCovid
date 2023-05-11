using Entities;
using Entities.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public class PatientDal : IPatientDal
    {
        public Hmo hmo;
        public PatientDal(Hmo hmo)
        {
            this.hmo = hmo;
        }
        public bool AddpatientVaccine(string tz, Corona corona)
        {

            var patient = hmo.Patients.Include(p => p.coronaDates).Where(p => p.tz == tz).FirstOrDefault();
            if (patient != null)
            {
                corona.patient = patient;
                corona.patientId = patient.id;
                if (patient.coronaDates != null)
                {
                    if (patient.coronaDates.Count() <= 3)
                    {
                        patient.coronaDates.Add(corona);
                        hmo.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    patient.coronaDates = new List<Corona>();
                    patient.coronaDates.Add(corona);
                    hmo.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public void AddPatient(Patient patient)
        {
            hmo.Patients.Add(patient);
            hmo.SaveChanges();
        }

        public List<Patient> GetAllPatients()
        {
            return hmo.Patients.ToList();
        }

        public Patient GetPatientById(string patientId)
        {
            return hmo.Patients.FirstOrDefault(p => p.tz.Equals(patientId));
        }


    }
}
