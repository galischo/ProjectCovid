using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ICoronaBll
    {
        public List<CoronaDto> getAll();
        public List<CoronaDto> getById(string id);
    }
}
