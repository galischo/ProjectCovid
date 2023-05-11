using Dal;
using Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.models;

namespace Bll
{
   
    public class PatientBll : IPatientBll
    {

        IPatientDal patientDal;
        IMapper mapper;
        public PatientBll(IPatientDal patientDal, IMapper mapper)
        {
            this.patientDal = patientDal;
            this.mapper = mapper;
        }
      
        public List<PatientDto> getAll()
        {
            return mapper.Map<List<PatientDto>>(this.patientDal.GetAllPatients());
        }

        public PatientDto getById(string id)
        {
            return mapper.Map<PatientDto>(this.patientDal.GetPatientById(id));
        }

        public void post(PatientDto patient)
        {
            this.patientDal.AddPatient(mapper.Map<Patient>(patient));

        }
        public bool AddpatientVaccine(string tz, CoronaDto corona)
        {
             return this.patientDal.AddpatientVaccine(tz,mapper.Map<Corona>(corona));
   

        }

    }
}
