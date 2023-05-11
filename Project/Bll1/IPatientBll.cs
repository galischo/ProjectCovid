using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   
    public interface IPatientBll
    {
        public void post(PatientDto patient);
        public List<PatientDto> getAll();
        public PatientDto getById(string id);
        public bool AddpatientVaccine(string tz, CoronaDto corona);

    }
}
