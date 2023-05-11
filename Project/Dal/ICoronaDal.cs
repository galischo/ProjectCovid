using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public interface ICoronaDal
    {
        public List<Corona> GetAllCoronas();
        public List<Corona> GetCoronaById(string Id);
    }
}
