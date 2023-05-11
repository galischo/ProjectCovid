using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.models
{
    public class Corona
    {
        public int id { get; set; }
        public DateTime vaccinationDate { get; set; }
        public string vaccineManufacturer { get; set; }
        public int patientId { get; set; }
        public Patient patient { get; set; }

    }
}
