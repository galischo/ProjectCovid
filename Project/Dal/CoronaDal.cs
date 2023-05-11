using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public class CoronaDal : ICoronaDal
    {
        public Hmo hmo;
        public CoronaDal(Hmo hmo)
        {
            this.hmo = hmo;
        }

        public List<Corona> GetAllCoronas()
        {
            return hmo.Coronas.ToList();
        }

        public List<Corona> GetCoronaById(string patientId)
        {
            return hmo.Coronas.Where(p =>p.patient.tz .Equals(patientId)).ToList();
        }



    }
}
